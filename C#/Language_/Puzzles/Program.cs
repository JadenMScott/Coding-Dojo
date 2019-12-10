using System;

namespace Puzzles
{
    class Program
    {
        //Random Array
            //Create a function called RandomArray() that returns an integer array
            //Place 10 random integer values between 5-25 into the array
            //Print the min and max values of the array
            //Print the sum of all the values
        static void RandomArray(){
            int[] numbers=new int [10];
            Random rand=new Random();
            int min=numbers[0];
            int max=numbers[0];
            int sum =0;
            for(int i=0;i<11;i++){
                numbers[i]=rand.Next(5,25);
                sum += numbers[i];
                if(numbers[i]>max){
                    max=numbers[i];
                }
                if(numbers[i]>min){
                    min=numbers[i];
                }
            }
            Console.WriteLine($"Max:{max},Min:{min},Sum:{sum}");
        }
        //Coin Flip
            //Create a function called TossCoin() that returns a string
            //Have the function print "Tossing a Coin!"
            //Randomize a coin toss with a result signaling either side of the coin 
            //Have the function print either "Heads" or "Tails"
            //Finally, return the result
            //Create another function called TossMultipleCoins(int num) that returns a Double
            //Have the function call the tossCoin function multiple times based on num value
            //Have the function return a Double that reflects the ratio of head toss to total toss
        static void CoinFlip(){

        }

        //Names
            //Build a function Names that returns a list of strings.  In this function:
            //Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            //Shuffle the list and print the values in the new order
            //Return a list that only includes names longer than 5 characters
        static void Names(){

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string rand_num= RandomArray();
        }
    }
}
