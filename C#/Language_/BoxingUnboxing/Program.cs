using System;
using System.Collections.Generic;
namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List <object> obj=new List<object>();
            obj.Add(7);
            obj.Add(28);
            obj.Add(-1);
            obj.Add(true);
            obj.Add("chair");

            for(int i =0;i<obj.Count;i++){
                Console.WriteLine(obj[i]);
            
                int count =0;
                foreach(int num in obj){
                    if(obj[i] is int){
                        count += int(obj[i]);
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
