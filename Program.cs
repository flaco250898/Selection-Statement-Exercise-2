namespace SelectionStatementExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "math":
                    Console.WriteLine("Math is my second language!");
                    break;

                case "History":
                    Console.WriteLine("History is one of my developer's favorite genre!!!");
                    break;

                case "PE":
                    Console.WriteLine("Having fun and exercise is considered a school subject? Wow I'm amazed!");
                    break;

                case "Economy":
                    Console.WriteLine("Economy is a subject that should be prioritized by early ages not until high school!");
                    break;

                case "English":
                    Console.WriteLine("English was my creator's least favorite subject but also the one where he had so much fun due to the friendship he had with his teacher");
                    break;

               
                    



            }

            






        }
    }
}