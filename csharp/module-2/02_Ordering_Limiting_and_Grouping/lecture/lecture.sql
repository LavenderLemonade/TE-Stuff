-- ORDERING RESULTS

-- Populations of all states from largest to smallest.
--SELECT population, state_abbreviation FROM state ORDER BY population DESC

-- States sorted alphabetically (A-Z) within their census region. The census regions are sorted in reverse alphabetical (Z-A) order.
--SELECT state_name, census_region FROM state ORDER BY state_name, census_region DESC;

-- The biggest park by area
--SELECT TOP 1 * FROM park ORDER BY area DESC


-- LIMITING RESULTS

-- The 10 largest cities by populations

--SELECT TOP 10 city_name, population FROM city ORDER BY population DESC

-- The 20 oldest parks from oldest to youngest in years, sorted alphabetically by name.

 --SELECT park_name, (YEAR(GETDATE()) - YEAR(date_established)) AS age_in_years FROM park ORDER BY age_in_years DESC, park_name;

--SELECT TOP 20 park_name, date_established FROM park ORDER BY date_established , park_name ;



-- CONCATENATING OUTPUTS

-- All city names and their state abbreviation.
--SELECT city_name + ',' +  state_abbreviation AS city_state FROM city;

-- All park names and area
--SELECT park_name + CAST(area AS VARCHAR) AS park_area FROM park

-- The census region and state name of all states in the West & Midwest sorted in ascending order.

--SELECT census_region + ' ' + state_name AS region_name FROM state WHERE census_region IN ('West', 'Midwest') ORDER BY census_region ASC

-- AGGREGATE FUNCTIONS

-- Average population across all the states. Note the use of alias, common with aggregated values.
--SELECT AVG(population) FROM state;

-- Total population in the West and South census regions
--SELECT SUM(population) FROM state WHERE census_region IN ('West', 'South');

-- The number of cities with populations greater than 1 million
--SELECT COUNT(*) FROM city WHERE population > 1000000;

-- The number of state nicknames.
--SELECT COUNT(state_nickname) FROM state

-- The area of the smallest and largest parks.
--SELECT MAX(area) AS smallest_park, MIN(area) AS biggest_park, park_name FROM park GROUP BY park_name;



-- GROUP BY

-- Count the number of cities in each state, ordered from most cities to least.
--SELECT state_abbreviation, COUNT(city_name) FROM city GROUP BY state_abbreviation ORDER BY COUNT(city_name) DESC;



-- Determine the average park area depending upon whether parks allow camping or not.
--SELECT AVG(area), has_camping FROM park GROUP BY has_camping

-- Sum of the population of cities in each state ordered by state abbreviation.
--SELECT state_abbreviation, SUM(population) FROM city GROUP BY state_abbreviation ORDER BY state_abbreviation

-- The smallest city population in each state ordered by city population.

--SELECT state_abbreviation, MIN(population) AS min_city_pop FROM city GROUP BY state_abbreviation ORDER BY state_abbreviation

-- Miscelleneous

-- While you can use TOP to limit the number of results returned by a query,
-- it's recommended to use OFFSET and FETCH if you want to get
-- "pages" of results.
-- For instance, to get the first 10 rows in the city table
-- ordered by the name, you could use the following query.
-- (Skip 0 rows, and return only the first 10 rows from the sorted result set.)



-- SUBQUERIES (optional)

-- Include state name rather than the state abbreviation while counting the number of cities in each state,
SELECT COUNT(city_name) AS num_of_cities, state_abbreviation,
(
	SELECT state_name FROM state AS state_table WHERE state_table.state_abbreviation = city_table.state_abbreviation
)
AS state_name
FROM city AS city_table
GROUP BY state_abbreviation
ORDER BY num_of_cities DESC;


-- Include the names of the smallest and largest parks


-- List the capital cities for the states in the Northeast census region.

