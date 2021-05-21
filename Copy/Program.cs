using System;

namespace Copy_constructors
{
    class employee
    {
        private string name;
        private int age;
        public employee(employee emp)   
        {
            name = emp.name;
            age = emp.age;
        }
        public employee(string name, int age)   
        {
            this.name = name;
            this.age = age;
        }
        public string Details      
        {
            get
            {
                return " The age of " + name + " is " + age.ToString();
            }
        }
    }
    class empdetail
    {
        static void Main()
        {
            employee emp1 = new employee("Vithal", 23);    
            employee emp2 = new employee(emp1);            
            Console.WriteLine(emp2.Details);
            Console.ReadLine();
        }
    }
}
