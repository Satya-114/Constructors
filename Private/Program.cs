using System;

namespace Private_constructor
{
     public class Counter
    {
        private Counter()     
        {
        }
        public static int currentview;
        public static int visitedCount()
        {
            return ++currentview;
        }
    }
    class viewCountedetails
    {
        static void Main()
        {
            
            Console.WriteLine();
            Counter.currentview = 500;
            Counter.visitedCount();
            Console.WriteLine("Now the view count is: {0}", Counter.currentview);
            Console.ReadLine();
        }
    }
}  
        
