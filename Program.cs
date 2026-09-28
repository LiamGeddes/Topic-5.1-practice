namespace Topic_5._1_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = 20;
            int cats = 30;
            int dogs = 15;

            Console.WriteLine("People: " + people + "Dogs: " + dogs + "Cats: " + cats);
            if (people < cats)
            {
                Console.WriteLine("Too many cats! The world is doomed!");
            }

            if (people > cats)
            { 
                Console.WriteLine("Not many cats! The world is saved!");
            }

            if (people < dogs)
            {
                Console.WriteLine("The world is drooled on!");
            }

            if (people > dogs)
            {
                Console.WriteLine("The world is dry!");
            }
            Console.WriteLine("Press ENTER to continue. ");
            Console.ReadLine();
            Console.Clear();
            dogs += 5;    // Add 5 dogs. What does dogs equal now?
            Console.WriteLine("People: " + people + " Dogs: " + dogs + " Cats: " + cats);
            if (people >= dogs)
            {
                Console.WriteLine("People are greater than or equal to dogs.");
            }
            if (people<= dogs)
            {
                Console.WriteLine("People are less than or equal to dogs.");
            }
            if (people == dogs)
            {
                Console.WriteLine("people are dogs.");
            }

        }   

    }
}
