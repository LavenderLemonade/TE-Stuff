-- 9. The titles of movies directed by James Cameron, sorted alphabetically.
-- (6 rows)

SELECT DISTINCT title FROM movie
JOIN movie_actor ON movie_actor.movie_id = movie.movie_id
JOIN person ON person.person_id = movie_actor.actor_id
WHERE director_id = 2710



