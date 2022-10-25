namespace ConsoleApp3
{
    internal class Program
    {
        class Person
        {
            public string name = "hz";
            public string Surname = "kz";
            public int age;
        }
        static void Print(string result)
        {
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Person josh = new Person();
            josh.name = "Josh";
            josh.Surname = "Boleslava";
            josh.age = 15;
            Print($"{josh.Surname} {josh.name} is {josh.age} years old");
        }
    }
}