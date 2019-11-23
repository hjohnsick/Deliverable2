using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {

            {

                int checksum = 0;
                string message = "";

                Console.WriteLine("What is your message?");

                string input = Console.ReadLine().ToUpper();

                for (int i = 0; i < input.Length; i++)
                {
                    int chVal = (int)input[i];
                    int alphaValue = chVal - 64;

                    checksum += chVal;
                    message += alphaValue.ToString();

                    if (i < input.Length - 1)
                    {
                        message += "-";
                    }
                }

                Console.WriteLine("Your encoded message is " + message);
                Console.WriteLine("Message checksum is " + checksum);
            }
        }
    }

}

    