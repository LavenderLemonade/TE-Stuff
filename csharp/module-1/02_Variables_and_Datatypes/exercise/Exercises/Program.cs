using System;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int numOfRacoons = 3;
            int racoonsLeaving = 2;
            int racoonsLeft = numOfRacoons - racoonsLeaving;
            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int numFlowers = 5;
            int numBees = 3;
            int flowersMinusBees = numFlowers - numBees;
            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int lonelyPigeon = 1;
            int currentlyEating = lonelyPigeon + 1;
            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int numOwls = 3;
            int currentlyOnFence = numOwls + 2;

            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int numBeavers = 2;
            int currentlyBeavering = numBeavers - 1;
            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int numToucans = 2;
            int finalToucans = numToucans + 1;
            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int numSquirrels = 4;
            int numNuts = 2;
            int squirrelToNutRatio = numSquirrels - numNuts;
            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            decimal quarterValue = 0.25M;
            decimal dimeValue = 0.10M;
            decimal nickelValue = 0.05M;
            decimal totalMoneyInCents = quarterValue + dimeValue + (2 * nickelValue);
            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int briarClass = 18;
            int macadamsClass = 20;
            int flanneryClass = 17;
            int totalMuffins = briarClass + macadamsClass + flanneryClass;
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            double yoyoCost = 0.24;
            double whistleCost = 0.14;
            double totalCost = yoyoCost + whistleCost;
            /*
            13. Mrs. Hilt made 5 Rice Krispies Treats. She used 8 large marshmallows
            and 10 mini marshmallows. How many marshmallows did she use
            altogether?
            */
            int bigMarsh = 8;
            int littleMarsh = 10;
            int totalMarsh = bigMarsh + littleMarsh;
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int hiltHouseSnow = 29;
            int brecknockSnow = 17;
            int snowDifference = hiltHouseSnow - brecknockSnow;
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            double hiltWallet = 10;
            double truckCost = 3;
            double pencilCost = 2;
            double leftoverCash = hiltWallet - (truckCost + pencilCost);
            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int joshMarbles = 16;
            int lostMarbles = 7;
            int leftoverMarbles = joshMarbles - lostMarbles;
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int meganShells = 19;
            int desiredNum = 25;
            int neededSHells = desiredNum - meganShells;
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int bradBalloons = 17;
            int redBalloons = 8;
            int restOfBalloons = bradBalloons - redBalloons;
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int booksOnShelf = 38;
            int martaBooks = 10;
            int totalBooks = martaBooks + booksOnShelf;
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int beeNum = 8;
            int beeLegs = 6;
            int totalLegs = beeNum * beeLegs;
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            decimal coneCost = 0.99M;
            int numCones = 2;
            decimal totalConeCost = coneCost * numCones;
            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int rocksNeeded = 125;
            int rocksHad = 64;
            int howManyMore = rocksNeeded - rocksHad;
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int hiltMarbles = 38;
            int hiltLostMarbles = 15;
            int finalMarbleCount = hiltMarbles - hiltLostMarbles;
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int concertDistance = 78;
            int todayTrip = 32;
            int milesLeft = concertDistance - todayTrip;
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time (in minutes) did she spend shoveling snow?
            */
            int satMorning = 90;
            int satAfternoon = 45;
            int totalShoveling = satMorning + satAfternoon;
            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            decimal hotDogCost = 0.50M;
            int numDogs = 6;
            decimal allDogsCost = hotDogCost * numDogs;
            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            int hiltMoney = 50;
            int pencilsCost = 7;
            int numPencils = (hiltMoney - (hiltMoney % pencilsCost)) / pencilsCost;
            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int butterfliesSeen = 33;
            int orangeButterflies = 20;
            int redButterflies = butterfliesSeen - orangeButterflies;
            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            decimal kateMoney = 1.00M;
            decimal candyCost = 0.54M;
            decimal change = kateMoney - candyCost;
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int backyardTrees = 13;
            int addingTrees = 12;
            int totalTrees = backyardTrees + addingTrees;
            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int joyDays = 2;
            int hoursInDay = 24;
            int hoursTillGranny = joyDays * hoursInDay;
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int kimCousins = 4;
            int gumCousins = 5;
            int gumTotal = kimCousins * gumCousins;
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            decimal danMoney = 3.00M;
            decimal barCost = 1.00M;
            decimal leftoverCents = danMoney - barCost;
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int numBoats = 5;
            int peoplePerBoat = 3;
            int allPeople = numBoats * peoplePerBoat;
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int spoiledEllen = 380;
            int complacentEllen = 57;
            int lameEllen = spoiledEllen - complacentEllen;
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int neededMuffinCount = 83;
            int arthurMuffinCount = 35;
            int inBetweenMuffinCount = neededMuffinCount - arthurMuffinCount;
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willyCrayons = 1400;
            int lucyCrayons = 290;
            int crayonDisparity = willyCrayons - lucyCrayons;
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int stickersOnPage = 10;
            int numOfPages = 22;
            int howManyStickers = stickersOnPage * numOfPages;
            /*
            39. There are 100 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            decimal cupcakeCount = 100.0M;
            decimal kidCount = 8.0M;
            decimal sharingEqually = cupcakeCount/kidCount;
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies, how many
            cookies will not be placed in a jar?
            */
            int gingyCookies = 47;
            int glassJars = 6;
            int leftoverCookies = gingyCookies % glassJars;
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received an equal number of croissants,
            how many will be left with Marian?
            */
            int croissnatsCount = 59;
            int neighborCount = 8;
            int leftoverCroissants = croissnatsCount % neighborCount;
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int neededCookies = 276;
            int trayHold = 12;
            int numTrays = neededCookies / trayHold;
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int pretzelCount = 480;
            int servingSize = 12;
            int theyEating = pretzelCount/ servingSize;
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int lemonCakes = 53;
            int leftCakes = 2;
            int boxCapacity = 3;
            int givenCakes = (lemonCakes - leftCakes) / boxCapacity;
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int breakfastCarrots = 74;
            int numGuests = 12;
            int leftoverCarrots = breakfastCarrots % numGuests;
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int teddyNum = 98;
            int shelfCapacity = 7;
            int fullShelves = (teddyNum - (teddyNum % shelfCapacity)) / shelfCapacity;
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int totalPics = 480;
            int albumCapacity = 20;
            int filledAlbums = totalPics / albumCapacity;
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int tradingCards = 94;
            int fullBox = 8;
            int leftoverCards = tradingCards % fullBox;
            int filledBoxes = (tradingCards - leftoverCards) / fullBox;
            Console.WriteLine(leftoverCards);
            Console.WriteLine(filledBoxes);
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int bookTotal = 210;
            int fixedShelves = 10;
            int shelfContains = bookTotal / fixedShelves;
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            double croissantCount = 17.0;
            double houseGuests = 7.0;
            double equalServings = croissantCount/houseGuests;
            /*
            51. Bill and Jill are house painters. Bill can paint a standard room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painters working together to paint 5 standard rooms?
            Hint: Calculate the rate at which each painter can complete a room (rooms / hour), combine those rates,
            and then divide the total number of rooms to be painted by the combined rate.
            */
            double billSpeed = 1/2.15;
            double jillSpeed = 1/1.90;
            int totalRooms = 5;
            double billRate = billSpeed * totalRooms;
            double jillRate = jillSpeed * totalRooms;
            double totalRates = billRate + jillRate;
            double finishedRooms = totalRooms * totalRates;
            /*
            52. Create and assign variables to hold a first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold the full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period. Use "Grace", "Hopper, and "B" for the first name, last name, and middle initial.
            Example: "John", "Smith, "D" —> "Smith, John D."
            */
            string firstName = "Grace";
            string middleInitial = "B";
            string lastName = "Hopper";
            string fullName = lastName + ", " + firstName + " " + middleInitial + ".";
            /*
            53. The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip as a whole number (integer) has been completed?
            */
            decimal tripDistance = 800.0M;
            decimal completedDistance = 537.0M;
            int tripPercentage = (int)((completedDistance / tripDistance) * 100);
            
        }
    }
}
