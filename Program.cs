namespace Topic_5._1_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //To satisfy: "Change the values of the variables so that neither message about cats is printed."
            // Setting people and cats to equal values (20) means neither (people < cats) nor (people > cats) evaluates to true.
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

                // Task 1 

                String magicWord;

                Console.Write("What is the magic word? ");
                magicWord = Console.ReadLine();

                if (magicWord.ToLower() == "please")
                {
                    Console.WriteLine("You're welcome!");
                }

                //Task 2

                String name;
                int age;

                Console.Write("Hey, what's your name? ");
                name = Console.ReadLine();

                Console.Write("Ok, " + name + ", how old are you? ");
                int.TryParse(Console.ReadLine(), out age);

                if (age < 16)
                {
                    Console.WriteLine("You can't drive, " + name + ".");
                }



            }

        }   

    }
}
