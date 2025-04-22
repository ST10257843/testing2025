using System;
using System.Threading;

namespace CyberSecurityAwarenessBot
{
    /*
     * Developer information:
     * ST10257843
     * Litiyana Monique Mohanlall
     * litiyana5@gmail.com
     */
    public static class CyberBot
    {
        // Main chatbot loop to handle user questions and responses.
        public static void ChatLoop(string name)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan; //Enhances Console UI with Visual Elements
                Console.Write("\nYou: ");
                Console.ResetColor();
                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input)) //Detects and responds to invalid inputs
                {
                    Console.WriteLine("I didn’t quite understand that. Could you rephrase?"); //Input Validation 
                    continue;
                }

                //information from 'What is cybersecurity?', IBM Think Blog

                if (input.Contains("how are you"))
                    BotReply("I'm running perfectly. Thanks for asking!");
                else if (input.Contains("purpose"))
                    BotReply("My purpose is to teach South African citizens about cybersecurity.");
                else if (input.Contains("what can i ask") || input.Contains("help"))
                    BotReply("You can ask me about password safety, phishing, safe browsing, or general cybersecurity topics.");
                else if (input.Contains("what is cybersecurity") || input.Contains("cybersecurity"))
                    BotReply("Cybersecurity is the practice of protecting our digital lives—devices, systems, and data—from cyber threats. It’s critical to prevent data breaches, phishing, and other online attacks.");
                else if (input.Contains("why is cybersecurity important") || input.Contains("why is it important"))
                    BotReply("As we rely more on technology, threats like ransomware and phishing grow. Cybersecurity protects our information and ensures trust, safety, and business continuity.");
                else if (input.Contains("cybersecurity challenges") || input.Contains("why is it hard"))
                    BotReply("The digital world evolves fast—new tech, remote work, AI, and IoT all add risks. Plus, there’s a global shortage of cybersecurity professionals to manage it all.");
                else if (input.Contains("types of cybersecurity") || input.Contains("kinds of cybersecurity"))
                    BotReply("Cybersecurity covers several areas:\n" +
                             "- **AI Security**: Protecting AI systems from misuse.\n" +
                             "- **Critical Infrastructure**: Securing systems like energy, healthcare, and transportation.\n" +
                             "- **Network/Cloud/Endpoint Security**: Securing the flow of data and devices.\n" +
                             "- **Application/Mobile Security**: Ensuring software and mobile devices are secure.\n" +
                             "- **Information Security**: Protecting sensitive data.");
                else if (input.Contains("common threats") || input.Contains("types of threats") || input.Contains("threats"))
                    BotReply("Watch out for these common threats:\n" +
                             "- **Malware**: Software that damages or exploits systems.\n" +
                             "- **Ransomware**: Locks data until a ransom is paid.\n" +
                             "- **Phishing**: Fake communications to steal personal data.\n" +
                             "- **Credential Theft**: Stealing login details.\n" +
                             "- **Insider Threats**: Authorized users causing harm.\n" +
                             "- **AI Attacks**: Hackers using AI for smarter attacks.\n" +
                             "- **Cryptojacking**: Hijacking computers to mine cryptocurrency.\n" +
                             "- **DDoS Attacks**: Overloading systems to cause failures.");
                else if (input.Contains("cybersecurity myths") || input.Contains("common myths"))
                    BotReply("Here are some dangerous myths:\n" +
                             "- **'Strong passwords are enough'**: Use multi-factor authentication (MFA) for added security.\n" +
                             "- **'We know all the risks'**: New vulnerabilities emerge constantly.\n" +
                             "- **'We’ve secured all possible attack vectors'**: New tech creates new risks.\n" +
                             "- **'My industry is safe'**: No industry is immune to attacks.\n" +
                             "- **'Small businesses aren’t targets'**: 41% of small businesses experience cyberattacks.");
                else if (input.Contains("how can organizations protect"))
                    BotReply("Organizations can take steps like:\n" +
                             "- **Security awareness training** for employees.\n" +
                             "- **Data security tools** like encryption.\n" +
                             "- **Identity and access management**.\n" +
                             "- **Attack surface management** to find vulnerabilities.\n" +
                             "- **Threat detection systems** using AI and automation.\n" +
                             "- **Disaster recovery planning** for business continuity.");
                else if (input.Contains("how can i protect myself") || input.Contains("what can i do") || input.Contains("protect myself"))
                    BotReply("Here are some tips for protecting yourself:\n" +
                             "1. Use strong, unique passwords and a password manager.\n" +
                             "2. Enable multi-factor authentication (MFA) on important accounts.\n" +
                             "3. Be cautious with phishing emails, links, and texts.\n" +
                             "4. Keep your software and devices updated.\n" +
                             "5. Avoid public Wi-Fi for sensitive tasks.\n" +
                             "6. Secure your mobile devices with passcodes or biometrics.\n" +
                             "7. Back up important data regularly.\n" +
                             "8. Be mindful of your digital footprint online.\n" +
                             "9. Use antivirus and anti-malware software.\n" +
                             "10. Stay informed on cybersecurity best practices.");
                else if (input.Contains("password"))
                    BotReply("Use strong, unique passwords for each account. Consider using a password manager to generate and store them securely.");
                else if (input.Contains("phishing"))
                    BotReply("Phishing tricks you into giving up sensitive information. Always verify the sender and don't click on suspicious links.");
                else if (input.Contains("safe browsing"))
                    BotReply("To browse safely:\n" +
                             "- Use HTTPS websites.\n" +
                             "- Avoid pop-ups and untrusted downloads.\n" +
                             "- Keep your browser up to date.");
                else if (input.Contains("thank you"))
                    BotReply("I'm glad I could help! If you have any other cybersecurity questions, feel free to ask.");
                else if (input == "exit")
                {
                    break;
                }
                else
                    BotReply("I'm not sure I understand. Try asking about cybersecurity, phishing, passwords, or online safety."); // Input Validation: Detects and responds to invalid inputs
            }
        }

        // Displays the bot's reply with a typing effect.
        private static void BotReply(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan; //Enhances Console UI with Visual Elements
            Console.Write("Bot: ");
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();
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
    * Nakov, S. and Kolev, V. 2013. Fundamentals of Computer Programming with C#. Sofia: [ebook]. Available at: http://www.introprogramming.info [Accessed 16 April 2024].
    * Patorjk. n.d. Text to ASCII art generator (TAAG). [online]. Available at: https://patorjk.com/software/taag/ [Accessed 10 April 2025].
    * W3Schools. 2024. C# Tutorial. [online]. Available at: https://www.w3schools.com/cs/index.php [Accessed 10 April 2025].
    */
}
