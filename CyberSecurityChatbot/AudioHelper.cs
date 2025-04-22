using System;
using System.Media; //import that inables music to be read
using System.Threading;

namespace CyberSecurityAwarenessBot
{
    /*
     * Developer information:
     * ST10257843
     * Litiyana Monique Mohanlall
     * litiyana5@gmail.com
     */
    public static class AudioHelper
    {
        //Plays a voice greeting from a WAV file.
        public static void PlayGreeting() //Ai voice over by Mark:Natural Conversations
        {
            try
            {
                SoundPlayer player = new SoundPlayer("Assets\\welcome.wav"); //welcome audio is stored in the assets folder
                player.Play();

                string welcomeMessage = "Hello and welcome to CyberSavvy, your personal cybersecurity assistant. " +
                                        "I'm here to help you stay safe, smart, and secure online. Let's get started!";

                Console.ForegroundColor = ConsoleColor.Cyan; //Enhances Console UI with Visual Elements
                int delayPerChar = 9000 / welcomeMessage.Length; //Welcome message is parrel to audio length

                foreach (char c in welcomeMessage)
                {
                    Console.Write(c);
                    Thread.Sleep(delayPerChar);
                }

                Console.WriteLine();
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed; //Enhances Console UI with Visual Elements
                Console.WriteLine("Unable to play audio: " + ex.Message); // Input Validation: Detects and responds to invalid inputs
                Console.ResetColor();
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
