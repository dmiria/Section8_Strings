using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a few numbers separated by a hypen");
            //var userInput = Console.ReadLine();
            //Console.WriteLine(ConsecutiveNumbers(userInput));

            //Console.WriteLine("Enter a few numbers separated by a hypen");
            //var duplicateInput = Console.ReadLine();
            //Console.WriteLine(DuplicateNumbers(duplicateInput));

            //Console.WriteLine("Enter a time value in the 24-hour time format(e.g. 19:00)");
            //var timeInupt = Console.ReadLine();
            //ValidTime(timeInput);

            // Console.WriteLine("Enter the word that you want to convert to Pascal Case.");
            //var pascalinput = Console.ReadLine();
            //PascalString(pascalinput);

            //Console.WriteLine("Enter a word or sentence.");
            //var vowelInput = Console.ReadLine();
            //VowelCounter(vowelInput);

        }

        /* Exercise 1
         * Write a program and ask the user to enter a few numbers separated 
         * by a hyphen. Work out if the numbers are consecutive. For example, 
         * if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: 
         * "Consecutive"; otherwise, display "Not Consecutive".
         * */
        public static string ConsecutiveNumbers(String numbers)
        {
            var array = Array.ConvertAll(numbers.Split('-'), int.Parse);
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[0] - array[i]) != i)
                {
                    //Console.WriteLine("Not Consecutive");
                    return "Not Consecutive";
                }
            }
            //Console.WriteLine("Consecutive");
            return "Consecutive";
        }

        /* Exercise 2
         * Write a program and ask the user to enter a few numbers separated by 
         * a hyphen. If the user simply presses Enter, without supplying an input, 
         * exit immediately; otherwise, check to see if there are duplicates. If so, 
         * display "Duplicate" on the console.
         **/
        public static string DuplicateNumbers(String numbers)
        {
            if (String.IsNullOrWhiteSpace(numbers))
            {
                Console.WriteLine("Quit...");
                return null;
            }
            else
            {
                var array = Array.ConvertAll(numbers.Split('-'), int.Parse);
                //Console.WriteLine("Split the array");

                if (array.Length != array.Distinct().Count())
                {
                    return "Duplicates";
                }
                Console.WriteLine("No Dupes");
                return null;
            }
        }

        /* Exercise 3
         * Write a program and ask the user to enter a time value in the 24-hour 
         * time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. 
         * If the time is valid, display "Ok"; otherwise, display "Invalid Time". If 
         * the user doesn't provide any values, consider it as invalid time.
         **/
        public static void ValidTime(String time)
        {
            if (String.IsNullOrWhiteSpace(time))
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            var array = Array.ConvertAll(time.Split(':'), int.Parse);
            var hour = array[0];
            var min = array[1];

            if (hour < 0 || hour > 23 || min < 0 || min > 60)
            {
                //invalid if there is no value or time is incorrect.
                Console.WriteLine("Invalid Time");
            }
            else
            {
                Console.WriteLine("Ok");
                //valid if it's between 0 and 23 hour frame
            }


        }

        /* Exercise 4
         * Write a program and ask the user to enter a few words separated by a 
         * space. Use the words to create a variable name with PascalCase. For example, 
         * if the user types: "number of students", display "NumberOfStudents". Make 
         * sure that the program is not dependent on the input. So, if the user types 
         * "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
         **/
        public static void PascalString(string word)
        {
            StringBuilder str = new StringBuilder();
            var newString = word.ToLower();
            if (String.IsNullOrWhiteSpace(newString))
            {
                return;
            }
            //Console.WriteLine(newString);
            for (int i = 0; i < newString.Length; i++)
            {
                if (i == 0)
                {
                    //capitalize the first character and add it to the string
                    str.Append(Char.ToUpper(newString[i]));
                    //Console.WriteLine("The string is " + str + ". At index: " + i + ". newString is " + newString[i]);
                }
                else if (word[i] == ' ')
                {
                    //capitalize the character after the space and add it to the string
                    str.Append(Char.ToUpper(newString[i + 1]));
                    //Console.WriteLine("The string is " + str + ". At index: " + i + ". newString is " + newString[i+1]);
                    i++;
                } else { 
                    //Add the remaining lower case letter to the string
                    str.Append(Char.ToLower(word[i]));
                }
            }
            //Write out the final string
            Console.WriteLine(str);
        }

        /* Exercise 5
         * Write a program and ask the user to enter an English word. Count the number 
         * of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", 
         * the program should display 6 on the console.
         **/
        public static void VowelCounter(string word)
        {
            var copyWord = word;
            var counter = 0;
            //Console.WriteLine("Word is: " + copyWord);
            foreach(var a in copyWord)
            {
                if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u') { 
                    counter++;
                }
            }
            Console.WriteLine("There are {0} vowels in this word.", counter);
        }
    }
}

