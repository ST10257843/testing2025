using System;

namespace CyberSecurityAwarenessBot
{
    /*
     * Developer information:
     * ST10257843
     * Litiyana Monique Mohanlall
     * litiyana5@gmail.com
     */
    public static class UserInteraction
    {
        // Prompts the user for their name with input validation.
        public static string GetUserName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; //Enhances Console UI with Visual Elements

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Name cannot be empty. Try again: "); // Input Validation: Detects and responds to invalid inputs
                name = Console.ReadLine();
            }

            return name;
        }

        // Displays a personalized welcome message with formatting.
        public static void DisplayWelcomeMessage(string name)
        {
            Console.Clear();
            AsciiArtLoader.DisplayAsciiArt();
            Console.ForegroundColor = ConsoleColor.Cyan; //Enhances Console UI with Visual Elements

            Console.WriteLine($" Hello, {name}! I'm your Cybersecurity Awareness Assistant."); //Initiates a welcoming and interactive experience.
            Console.WriteLine(" Ask me anything about password safety, phishing, or safe browsing.");
            Console.WriteLine(" Type 'exit' to leave.");

            Console.ResetColor();
        }

        // Displays a friendly goodbye message.
        public static void ExitMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red; //Enhances Console UI with Visual Elements
            Console.WriteLine("\nThank you for chatting! Stay safe online. Goodbye!");
            Console.ResetColor();
        }
    }
    /*
    References and Code Contributions:
    * Bell, D. and Parr, M. 2009. C# for students. Harlow: Pearson;
    * Deitel, P.J. and Deitel H.M. Visual C# 2010: how to program. Upper Saddle River, (NJ): Pearson Prentice Hall.
    * Doyle, B. 2016. C# programming: from problem analysis to program design. 5th ed. Boston, (MA): Cengage Learning. 
    * ElevenLabs. 2025. Text to Speech – Voice Synthesis Platform. [online]. Available at: https://elevenlabs.io/app/speech-synthesis/text-to-speech [Accessed 16 April 2025].
    * Farrell, J. 2011. Microsoft Visual C# 2010: an introduction to object-oriented programming. Mason, (OH): South-Western.
    * Lindemulder, G. and Kosinski, M. 2024. What is cybersecurity?. [online]. Available at: https://www.ibm.com/think/topics/cybersecurity [Accessed 14 April 2025].
    * Nakov, S. and Kolev, V.  2013. Fundamentals of Computer Programming with C#. Sofia: [ebook]. Available at: http://www.introprogramming.info [Accessed 16 April 2024].
    * Patorjk. n.d. Text to ASCII art generator (TAAG). [online]. Available at: https://patorjk.com/software/taag/ [Accessed 10 April 2025].
    * W3Schools. 2024. C# Tutorial. [online]. Available at: https://www.w3schools.com/cs/index.php [Accessed 10 April 2025].
    */
}
