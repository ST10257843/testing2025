using System;

namespace CyberSecurityAwarenessBot
{
    /*
     * Developer information:
     * ST10257843
     * Litiyana Monique Mohanlall
     * litiyana5@gmail.com
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot: CyberSavvy"; //Displays the name of the chatbox

            AudioHelper.PlayGreeting(); //Ensures wav file is played
            AsciiArtLoader.DisplayAsciiArt(); //Ensures ascii text is diaplyed
            Console.WriteLine();

            // Prompts the user for their name and ensures the input is not empty
            string userName = UserInteraction.GetUserName();

            // Displays a personalized welcome message with instructions
            UserInteraction.DisplayWelcomeMessage(userName);

            //Responds to users questions on cybersecurity
            CyberBot.ChatLoop(userName);

            // Prints a goodbye message before exiting the program
            UserInteraction.ExitMessage();
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
    * Nakov, S. and Kolev, V. 2013. Fundamentals of Computer Programming with C#. Sofia: [ebook]. Available at: http://www.introprogramming.info [Accessed 16 April 2024].
    * Patorjk. n.d. Text to ASCII art generator (TAAG). [online]. Available at: https://patorjk.com/software/taag/ [Accessed 10 April 2025].
    * W3Schools. 2024. C# Tutorial. [online]. Available at: https://www.w3schools.com/cs/index.php [Accessed 10 April 2025].
    */
}
