using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
//*****************************************ARRAYS*****************************************************
            //int array
            int[] array={1,2,3,4,5,6,7,8,9};
            //string array with "Tim","Martin","Nikki","Sara"
            string[] names=new string[] {"Tim","Martin","Nikki","Sara"};
            //boolean array w/ alternating arrays starting with true

//*****************************************LISTS*****************************************************
            //Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> iceCream = new List<string>();
            iceCream.Add("Vanilla");
            iceCream.Add("Chocolate");
            iceCream.Add("Strawberry");
            iceCream.Add("Mint Chocolate Chip");
            iceCream.Add("Butter Pecan");
            iceCream.Add("Peanut Butter Cup");
            iceCream.Add("Cookie Monster");
            iceCream.Add("Butter Brickle");
            iceCream.Add("Strawberry Blondie");
            iceCream.Add("Pistachio");
            iceCream.Add("Circus Cookie");
            iceCream.Add("Bubblegum");
            iceCream.Add("Eggnog");
            iceCream.Add("Pecans Praline and Cream");
            iceCream.Add("Cherry Pecans and Praline");
            iceCream.Add("Rocky Road");
            iceCream.Add("Cherry Amaretto");
            iceCream.Add("Chocolate Chip Cookie Dough");
            iceCream.Add("Vanilla Bean");
            iceCream.Add("French Vanilla");
            iceCream.Add("Homestyle Vanilla");
            iceCream.Add("Gingerbread");
            iceCream.Add("Raspberry Ganache");
            iceCream.Add("Birthday Cake");
            iceCream.Add("Brownie");
            //Output the length of this list after building it
            int length=iceCream.Count;
            Console.WriteLine(length);

            //Output the third flavor in the list, then remove this value
            string word=iceCream[2];
            iceCream.Remove(word);
            //Output the new length of the list (It should just be one fewer!)
            int newLength=iceCream.Count;
            Console.WriteLine(newLength);
//*****************************************DICTIONARIES*****************************************************
            //Create a dictionary that will store both string keys as well as string values
            
            //Add key/value pairs to this dictionary where:
                //each key is a name from your names array
                //each value is a randomly select a flavor from your flavors list.
            
            //Loop through the dictionary and print out each user's name and their associated ice cream flavor

            Random rand = new Random();
            for(int val = 0; val < 10; val++)
            {
                //Prints the next random value between 2 and 8
                Console.WriteLine(rand.Next(2,8));
            }
        }
    }
}
