using System;
using static System.Console;

namespace AdditionalFeatures
{
    static class AdditionalFeatures
    {
        
        // **** start of enum example **** //
        // An enums purpose is to increase code readability and consistency
            
        // Here, I'm creating an enum of dinosaurs
        // By default, Velociraptor=0
        //             Carnotaurus=1
        //             Theropods=2
        // If I had more values, each would increase to the next value (ex: 3, 4, 5, 6..)
        // Refer to the bottom of Main() to see the usage of my dinosaur enum
        enum Dinosaur { Velociraptor, Carnotaurus, Theropods }
        
        
        static void Main()
        {
            // Here I'm creating a hard-coded string array
            // this will work, but as I discussed yesterday c# will give you 
            // an information warning asking you to use a collection
            // refer to yesterday's lecture notes
            string[] items = { "I", "Am", "A", "Array" };
            
            // Here I'm creating an instance of the built-in Random class so that we can 
            // use it to randomly select an item from our list
            Random random = new Random();
            
            // using our random instance and call .Next() and passing in our array length
            // .Next() will randomly select a positive integer with a max of the passed in argument
            int index = random.Next(items.Length); // Generates a random index
            
            // Here, I'm utilizing my index that was generated from our random instance
            // to select a value from our items array
            string randomItem = items[index];
            
            // You've seen this a dozen times, if not more
            // Concatenating my string (label) with my c# variable
            WriteLine("Randomly selected item: " + randomItem);
            
            
            
            // enum example continued
            // creating myDino with a default value
            Dinosaur myDino = Dinosaur.Velociraptor;
            
            WriteLine("Choose a Dinosaur (Velociraptor, Carnotaurus, Theropods): ");
            string? input = ReadLine();

            // Try to convert string input to enum
            // Going to check if my input is equal to an existing value, true will ignore the casing of my string value
            // creating a new variable called newDino and setting myDino = to my new value
            if (Enum.TryParse(input, true, out Dinosaur newDino))
            {
                myDino = newDino;
                WriteLine("Dinosaur changed to: " + myDino);
            }
            else
            {
                // if string doesn't match an existing enum value, then we are going to output this message
                WriteLine("Invalid input! Keeping default dinosaur.");
            }
            
            // ** example showcase of using the value tied to the dinosaur
            // int dinoValue = (int)Dinosaur.Carnotaurus;
            // WriteLine(dinoValue); // Output: 1

        }
    }
}