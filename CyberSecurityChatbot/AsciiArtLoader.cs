using System;
using System.IO;

namespace CyberSecurityAwarenessBot
{
    /*
     * Developer information:
     * ST10257843
     * Litiyana Monique Mohanlall
     * litiyana5@gmail.com
     */
    public static class AsciiArtLoader
    {
        //Displays cybersecurity-themed ASCII art as the header.
        public static void DisplayAsciiArt() //ascii text style: doom
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Red; //Enhances Console UI with Visual Elements
                string asciiPath = Path.Combine("Assets\\ascii.txt"); //ascii is stored in the assets folder
                string art = File.ReadAllText(asciiPath);
                Console.WriteLine(art);
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Unable to load ASCII art: " + ex.Message); // Input Validation: Detects and responds to invalid inputs
            }
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
