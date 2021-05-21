using System;

namespace Static_constructor
{
    class geeks
    {

        
        static geeks()
        {

            
            Console.WriteLine("Static Constructor");
        }

        
        public geeks(int i)
        {
            Console.WriteLine("Instance Constructor " + i);
        }

        
        public string geeks_detail(string name, int id)
        {
            return "Name:" + name + " id:" + id;
        }

       
        public static void Main()
        {

            
            geeks obj = new geeks(1);

            Console.WriteLine(obj.geeks_detail("GFG", 1));

            
            geeks obj1 = new geeks(2);

            Console.WriteLine(obj1.geeks_detail("GeeksforGeeks", 2));
        }
    }
}
        