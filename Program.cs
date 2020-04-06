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
            // Console.WriteLine(planetList[2]);
            // Console.WriteLine(planetList[3]);

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

        }
    }
}