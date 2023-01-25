using System;
using System.Threading;

namespace Hello_Console_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            try
            {
                do
                {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(@"Please,  type the number:
                    1.  f(a,b) = |a-b| (unary)
                    2.  f(a) = a (binary)
                    3.  music
                    4.  morse sos
          
                    ");
                    try
                    {
                        a = (int)uint.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 1:
                                My_strings();
                                Console.WriteLine("");
                                break;
                            case 2:
                                My_Binary();
                                Console.WriteLine("");
                                break;
                            case 3:
                                My_music();
                                Console.WriteLine("");
                                break;
                            case 4:
                                Morse_code();
                                Console.WriteLine("");
                                break;                   
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error"+e.Message);
                    }                   
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #region ToFromBinary
        static void My_Binary()
        {
            Console.WriteLine("Введіть додатнє число");
            //Implement positive integer variable input
            int value = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(value, 2);
            Console.WriteLine(binary);
            char [] arr = binary.ToCharArray();
            //Array.Reverse(arr);
            int dd;
            //Present it like binary string
            //   For example, 4 as 100
            foreach (char c in arr)
            {
                dd = int.Parse(Convert.ToString(c));
                Console.WriteLine(dd % 2);
            }
            Array.Reverse(arr);
            Console.WriteLine("");
            foreach (char c in arr)
            {
                dd = int.Parse(Convert.ToString(c));
                Console.WriteLine(dd % 2);
            }

            //Use modulus operator to obtain the remainder  (n % 2) 
            //and divide variable by 2 in the loop

            //Use the ToCharArray() method to transform string to chararray
            //and Array.Reverse() method

        }
        #endregion

        #region ToFromUnary
        static void My_strings()
        {
           //Declare int and string variables for decimal and binary presentations
           //Implement two positive integer variables input
           ushort a1 = 0;
           ushort a2 = 0;
           string unary_str = "";
           string unary_str_rev = "";
            Console.WriteLine("Enter fast variables");
            a1 = ushort.Parse(Console.ReadLine());
           Console.WriteLine("Enter second variables");
            a2 = ushort.Parse(Console.ReadLine());
            //To present each of them in the form of unary string use for loop
            for (int i = 0; i < a1; i++) 
            {
                unary_str = unary_str + 1;
            }
            unary_str = unary_str + "#";
            for (int i = 0; i < a2; i++)
            {
                unary_str = unary_str + 1;
            }
            Console.WriteLine(unary_str);
            string ch1 = "";
            string ch2 = "";
            for (int i = 0, j = unary_str.Length -1; i < unary_str.Length; i++, j--)
            {
                ch1 = unary_str.Substring(i, 1);

                ch2 = unary_str.Substring(j, 1);
               // Console.WriteLine("i=" + i + "j=" + j);
                if (ch1 == ch2)
                {
                    Console.WriteLine(unary_str.Substring(i+1, j-i-1));
                }
                ch1 = unary_str.Substring(i + 1, 1);
                ch2 = unary_str.Substring(j - i - 1, 1);

                if (ch1 == "#" || ch2 == "#")
                {
                    Console.WriteLine(unary_str.Substring(i + 1, j - i - 1).Replace("#",""));
                    
                    break;
                }
            }


            //Use concatenation of these two strings 
            //Note it is necessary to use some symbol ( for example “#”) to separate

            //Check the numbers on the equality 0
            //Realize the  algorithm for replacing '1#1' to '#' by using the for loop 
            //Delete the '#' from algorithm result

            //Output the result 
        }
        #endregion

        #region My_music
        static void My_music()
        {
            //HappyBirthday
            Thread.Sleep(2000);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(330, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(2642, 500);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 250);
            Thread.Sleep(125);
            Console.Beep(352, 125);
            Thread.Sleep(125);
            Console.Beep(330, 500);
            Thread.Sleep(125);
            Console.Beep(297, 1000);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
        }
        #endregion

        #region Morse
        static void Morse_code()
        {
            //Create string variable for 'sos'      
            Console.WriteLine("Enter word");
            string str;
            str = Console.ReadLine();    
            //Use string array for Morse code
            string[,] Dictionary_arr = new string [,] { { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" },
            { ".-   ", "-... ", "-.-. ", "-..  ", ".    ", "..-. ", "--.  ", ".... ", "..   ", ".--- ", "-.-  ", ".-.. ", "--   ", "-.   ", "---  ", ".--. ", "--.- ", ".-.  ", "...  ", "-    ", "..-  ", "...- ", ".--  ", "-..- ", "-.-- ", "--.. ", "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----." }};
            //Use ToCharArray() method for string to copy charecters to Unicode character array
            //Use foreach loop for character array in which
            char ss;
            string charCode;
            foreach (char c in str)
            {
                Console.WriteLine(c);
                for (int i = 0; i < Dictionary_arr.Length; i++)
                {
                    ss = char.Parse(Dictionary_arr[0, i]);
                    if (ss == c)
                    {
                        charCode = Dictionary_arr[1, i];
                        foreach (char r in charCode)
                        {
                            if (r == char.Parse("."))
                            {
                                Console.Beep(1000, 250);
                            }
                            if (r == char.Parse("-"))
                            {
                                Console.Beep(1000, 750);
                            }
                            Thread.Sleep(50);
                        }
                        break;
                    }
                }
            }

            
            //Implement Console.Beep(1000, 250) for '.'
            // and Console.Beep(1000, 750) for '-'

            //Use Thread.Sleep(50) to separate sounds
            //                  
        }

        #endregion
    }
}
