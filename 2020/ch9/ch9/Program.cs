using System;

namespace ch9
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person("jared", "parsons");
            var (firstName, lastName) = p;
            Console.WriteLine($"{firstName} {lastName}");

            if (p == new Person("john", "doe"))
            {
                Console.WriteLine("This is John Doe");
            }

            var p2 = p.WithLastName("Bome");
        }

        static bool IsInChat(Person p)
        {
            return p switch
            {
                ("jared", "parsons") => true,
                ("cecil", "phillip") => true,
                _ => false
            };
        }
    }
}
