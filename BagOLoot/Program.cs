using System;
using System.Collections.Generic;
using System.Linq;

namespace BagOLoot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var db = new DatabaseInterface();
            db.Check();

            Console.WriteLine ("WELCOME TO THE BAG O' LOOT SYSTEM");
            Console.WriteLine ("*********************************");
            Console.WriteLine ("1. Add a child");
            Console.WriteLine ("2. Assign toy to a child");
            Console.WriteLine ("3. Revoke toy from child");
            Console.WriteLine ("4. Review child's toy list");
            Console.WriteLine ("5. Child toy delivery complete");
            Console.WriteLine ("6. Yuletime Delivery Report");
			Console.Write ("> ");

			// Read in the user's choice
			int choice;
			Int32.TryParse (Console.ReadLine(), out choice);
            //enter child's name
            if (choice == 1)
            {
                Console.WriteLine ("Enter child name");
                Console.Write ("> ");
                string childName = Console.ReadLine();
                ChildRegister registry = new ChildRegister();
                bool childId = registry.AddChild(childName);
                Console.WriteLine(childId);
            }
            //give kid a toy
            if (choice == 2)
            {
                Console.WriteLine("Assign toy to a child");
                Console.Write("> ");
            }
            //take toy away from kid
            if (choice == 3)
            {
                Console.WriteLine("Revoke to from child");
                Console.Write("> ");
            }
            //read the kid's wish list
            if (choice == 4)
            {
                Console.WriteLine("Review child's toy list");
                Console.Write("> ");
            }
            //see who got toys
            if(choice == 5)
            {
                Console.WriteLine("Child toy delivery complete");
                Console.Write("> ");
            }
            //yuletide report
            if(choice == 6)
            {
                Console.WriteLine("Yuletime Delivery Report");
                Console.Write("> ");
            }

        }

        private static SantaHelper GetGiveToy(SantaHelper giveToy)
        {
            return giveToy;
        }
    }
}