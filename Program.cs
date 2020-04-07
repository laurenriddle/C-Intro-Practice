using System;
using System.Collections.Generic;

namespace bangazon
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime is the type of the purchaseData variable.
            DateTime purchaseDate = DateTime.Now;

            /*
                string is the type of the lastName variable. It
                tells the compiler that the lastName variable can
                ONLY hold a string value.
            */
            string lastName = "Smith";

            /*
                C# now supports implicitly typing of a variable. The
                type of the variable will be determined, by the
                compiler, at compile time.
            */
            var firstName = "Bill";

            /*
                String interpolation in C# is similar to string interpolation in JavaScript,
                but there is a different syntax.

                An equivalent statement in JavaScript would be:
                console.log(`${firstName} ${lastName} purchased on ${purchaseDate}`);
            */
            Console.WriteLine($"{firstName} {lastName} purchased on {purchaseDate}");

            /*
                Not only do you have to say what type the variable is, you also
                have to instantiate that exact same type of object on assignment.
                This may seem redundant, but it's part of the C# language compiler's
                type checking constraints.
            */
            List<string> products = new List<string>() {
                "Motorcycle",
                "Sofa",
                "Sandals",
                "Omega Watch",
                "iPhone"
            };

            /*
                A foreach loop is used to iterate over a collection.

                The code below is roughly equivalent to the following JavaScript:
                products.forEach(product => {
                    console.log(product);
                });
            */
            foreach (string product in products) {
                if (product.Length < 5) {
                    Console.WriteLine($"{product} has a short name");
                } else if (product.Length < 10) {
                    Console.WriteLine($"{product} has a medium-sized name");
                } else {
                    Console.WriteLine($"{product} has a long name");
                }
            };

            /*
                Like JavaScript, C# has a for() loop

                This code is equivalent to the foreach loop above.
            */
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i]);
            };


            // PLANETS AND SPACESHIPS EXERCISE

            // list of planets 
            List<string> planetList = new List<string>(){"Mercury", "Mars"};


            // Add() Jupiter and Saturn at the end of the list
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            // print the new planets to confirm they are in the list
            Console.WriteLine(planetList[2]);
            Console.WriteLine(planetList[3]);

            // Create another List that contains that last two planets of our solar system.
            List<string> newPlanetList = new List<string>(){"Uranus", "Neptune"};

            // Combine the two lists by using AddRange(). This joins the two lists together.
            planetList.AddRange(newPlanetList);

            // Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            // Use Add() again to add Pluto to the end of the list.
            planetList.Add("Pluto");

            // Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
            List<string> rockyPlanets = planetList.GetRange(0,4);

            // loop over each rocky planet
            foreach (string planet in rockyPlanets) {
                // print each planet
                Console.WriteLine(planet, "Rocky Planet List");
            }

            // Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
            planetList.Remove("Pluto");

            // loop over each planet
            foreach (string planet in planetList) {
                // print each planet
                Console.WriteLine(planet, "Planet List");
            }


            // RANDOM NUMBERS EXERCISE 

            Random random = new Random();
                List<int> numbers = new List<int> {
                    random.Next(6),
                    random.Next(6),
                    random.Next(6),
                    random.Next(6),
                    random.Next(6),
                    random.Next(6),
            };

            for (int i=0; i<numbers.Count; i++) {
                 // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
      
                 if (numbers.Contains(i)) {
                      Console.WriteLine($"numbers list contains {i}");
                 } else {
                      Console.WriteLine($"numbers list does not contain {i}");
                 } 
   
            }





            // DICTIONARY OF WORDS PRACTICE

            /*
                Create a dictionary with key value pairs to
                represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Great", "The feeling you get when you solve a code challenge correctly");
            wordsAndDefinitions.Add("Glorious", "The feeling of students when they graduate");
           
            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */

            Console.WriteLine(wordsAndDefinitions["Awesome"]);
            Console.WriteLine(wordsAndDefinitions["Great"]);

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                // prints the def and word for each key/value pair
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }



            // LIST OF DICTIONARIES ABOUT WORDS PRACTICE (EXTENTION OF THE LAST EXERCISE)

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();
            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list
            Dictionary<string, string> happyWord = new Dictionary<string, string>();
            happyWord.Add("word", "happy");
            happyWord.Add("definition", "feeling or showing pleasure or contentment");
            happyWord.Add("part of speech", "adjective");
            happyWord.Add("example sentence", "I am happy that we are having soup for dinner!");

            dictionaryOfWords.Add(happyWord);
            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> dict in dictionaryOfWords)
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> wordData in dict)
                {
                    Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                }
            }
        }
    }
}