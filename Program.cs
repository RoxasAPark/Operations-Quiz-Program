using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOpsQuiz
{
    class Quiz
    {
        // Random number generator for generating problems with random numbers
        private Random rnd;
        private int smallestA;
        private int largestA;
        private int smallestB;
        private int largestB;
        private int smallestC;
        private int largestC;

        // Constructor
        public Quiz()
        {
            rnd = new Random();

            Console.WriteLine("Welcome to the quiz program!");
            outputMenu();
        }

        // A function to give the user a list of operations to be quizzed on
        private void outputMenu()
        {
            Console.WriteLine("You can be quizzed on the following operators:");
            Console.WriteLine("1) % (modulus, or 'remainder')");
            Console.WriteLine("2) * (multiplication)");
            Console.WriteLine("3) / (integer division)");
            Console.WriteLine("4) / % (integer division & modulus in a combined challenge!");
            Console.Write("Type the number of the operator that you wish to be quizzed on or press 5 to quit: ");
        }

        // A function to check if the user chooses a valid menu option
        private bool validNumberInput(int num)
        {
            return ((num > 0) && (num < 6));
        }

        // A function to allow the user to select smallest and largest values for A and B
        // If the user wants to be quizzed on the following operations: modulus, multiplication, and integer division
        private void smallestAndLargestValues()
        {
            int smallA;
            int largeA;
            int smallB;
            int largeB;

            Console.Write("What is the smallest value of A: ");
            while (!Int32.TryParse(Console.ReadLine(), out smallA))
            {
                Console.WriteLine();
                Console.WriteLine("You have to input a number");
                Console.Write("What is the smallest value of A: ");

                if (Int32.TryParse(Console.ReadLine(), out smallA) == true)
                {
                    Console.WriteLine();
                    break;
                }
            }

            Console.Write("What is the largest value of A: ");
            while (!Int32.TryParse(Console.ReadLine(), out largeA) || largeA < smallA)
            {
                Console.WriteLine();
                Console.WriteLine("You have to input a number larger than " + smallA);
                Console.Write("What is the largest value of A: ");

                if (Int32.TryParse(Console.ReadLine(), out largeA) == true && largeA > smallA)
                {
                    Console.WriteLine();
                    break;
                }
            }

            Console.Write("What is the smallest value of B: ");
            while (!Int32.TryParse(Console.ReadLine(), out smallB))
            {
                Console.WriteLine();
                Console.WriteLine("You have to input a number");
                Console.Write("What is the smallest value of B: ");

                if (Int32.TryParse(Console.ReadLine(), out smallB) == true)
                {
                    Console.WriteLine();
                    break;
                }
            }

            Console.Write("What is the largest value of B: ");
            while (!Int32.TryParse(Console.ReadLine(), out largeB) || largeB < smallB)
            {
                Console.WriteLine();
                Console.WriteLine("You have to input a number larger than " + smallB);
                Console.Write("What is the largest value of B: ");

                if (Int32.TryParse(Console.ReadLine(), out largeB) == true && largeB > smallB)
                {
                    Console.WriteLine();
                    break;
                }

            }

            smallestA = smallA;
            largestA = largeA;
            smallestB = smallB;
            largestB = largeB;
        }

        // A function to allow the user to select smallest and largest values for A, B, and C
        // If the user wants to be quizzed on a combination of integer division and modulus
        private void smallestAndLargestValuesForCombinations()
        {
            int smallA;
            int largeA;
            int smallB;
            int largeB;
            int smallC;
            int largeC;

            Console.Write("What is the smallest value of A: ");
            while (!Int32.TryParse(Console.ReadLine(), out smallA))
            {
                Console.WriteLine();
                Console.WriteLine("You have to input a number");
                Console.Write("What is the smallest value of A: ");

                if (Int32.TryParse(Console.ReadLine(), out smallA) == true)
                {
                    Console.WriteLine();
                    break;
                }
            }

            Console.Write("What is the largest value of A: ");
            while (!Int32.TryParse(Console.ReadLine(), out largeA) || largeA < smallA)
            {
                Console.WriteLine();
                Console.WriteLine("You have to input a number larger than " + smallA);
                Console.Write("What is the largest value of A: ");

                if (Int32.TryParse(Console.ReadLine(), out largestA) == true && largeA > smallA)
                {
                    Console.WriteLine();
                    break;
                }
            }

            Console.Write("What is the smallest value of B: ");
            while (!Int32.TryParse(Console.ReadLine(), out smallB))
            {
                Console.WriteLine();
                Console.WriteLine("You have to input a number");
                Console.Write("What is the smallest value of B: ");

                if (Int32.TryParse(Console.ReadLine(), out smallB) == true)
                {
                    Console.WriteLine();
                    break;
                }
            }

            Console.Write("What is the largest value of B: ");
            while (!Int32.TryParse(Console.ReadLine(), out largeB))
            {
                Console.WriteLine();
                Console.WriteLine("You have to input a number larger than " + smallB);
                Console.Write("What is the largest value of B: ");

                if (Int32.TryParse(Console.ReadLine(), out largeB) == true)
                {
                    Console.WriteLine();
                    break;
                }
            }

            Console.Write("What is the smallest value of C: ");
            while (!Int32.TryParse(Console.ReadLine(), out smallC))
            {
                Console.WriteLine();
                Console.WriteLine("You have to input a number");
                Console.Write("What is the smallest value of C: ");

                if (Int32.TryParse(Console.ReadLine(), out smallC) == true)
                {
                    Console.WriteLine();
                    break;
                }
            }

            Console.Write("What is the largest value of C: ");
            while (!Int32.TryParse(Console.ReadLine(), out largeC) || largeC < smallC)
            {
                Console.WriteLine();
                Console.WriteLine("You have to input a number larger than " + smallC);
                Console.Write("What is the largest value of C: ");

                if (Int32.TryParse(Console.ReadLine(), out largeC) == true && largeC > smallC)
                {
                    Console.WriteLine();
                    break;
                }
            }

            // Initialize the values
            smallestA = smallA;
            largestA = largeA;
            smallestB = smallB;
            largestB = largeB;
            smallestC = smallC;
            largestC = largeC;
        }

        // Function for the quiz that only uses two values (A and B) based on the operator the user chose to be quizzed on
        // The operator could be modulus (%), multiplication (*), or integer division (/)
        private void quizWithoutCombinations(int option)
        {
            int numQuestions = 0;

            Console.WriteLine();
            Console.WriteLine("How many times do you wish to be quizzed?");

            while (!Int32.TryParse(Console.ReadLine(), out numQuestions) || numQuestions < 1)
            {
                Console.WriteLine();
                Console.WriteLine("You have to input a number greater than 0");
                Console.WriteLine();

                if (Int32.TryParse(Console.ReadLine(), out numQuestions) == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Okay, we're good to go!");
                    Console.WriteLine();
                    break;
                }
            }

            int a;
            int b;
            int correctAnswers = 0;

            // If the option is 1, the program quizzes the user on % operations.
            // If the option is 2, the program quizzes the user on * operations.
            // If the option is 3, the program quizzes the user on integer division

            // For each correct answer, the program increments the count
            // Should the user input an incorrect answer, the program notifies the user what the correct answer is
            for(int i = 0; i < numQuestions; i++)
            {
                if(i < numQuestions && option == 1)
                {
                    int userResponse;
                    a = rnd.Next(smallestA, largestA);
                    b = rnd.Next(smallestB, largestB);
                    Console.WriteLine("What is the result of " + a + " % " + b + "? ");
                    if (!Int32.TryParse(Console.ReadLine(), out userResponse) || userResponse != (a % b))
                        Console.WriteLine("Your answer is incorrect. " + a + " % " + b + " = " + (a % b));
                    else
                    {
                        Console.WriteLine(userResponse + " is correct");
                        correctAnswers++;
                    }
                }

                if(i < numQuestions && option == 2)
                {
                    int userResponse;
                    a = rnd.Next(smallestA, largestA);
                    b = rnd.Next(smallestB, largestB);
                    Console.WriteLine("What is the result of " + a + " * " + b + "? ");
                    if (!Int32.TryParse(Console.ReadLine(), out userResponse) || userResponse != (a * b))
                        Console.WriteLine("Your answer is incorrect. " + a + " * " + b + " = " + (a * b));
                    else
                    {
                        Console.WriteLine(userResponse + " is correct");
                        correctAnswers++;
                    }
                }

                if (i < numQuestions && option == 3)
                {
                    int userResponse;
                    a = rnd.Next(smallestA, largestA);
                    b = rnd.Next(smallestB, largestB);
                    Console.WriteLine("What is the result of " + a + " / " + b + "? ");
                    if (!Int32.TryParse(Console.ReadLine(), out userResponse) || userResponse != (a / b))
                        Console.WriteLine("Your answer is incorrect. " + a + " / " + b + " = " + (a / b));
                    else
                    {
                        Console.WriteLine(userResponse + " is correct");
                        correctAnswers++;
                    }
                }
            }

            // At the end of the quiz, the program calculates the percentage of questions answered correctly.
            // A score of 60 or greater is a passing grade, otherwise, a failing grade
            double quizResult = (Convert.ToDouble(correctAnswers) / Convert.ToDouble(numQuestions)) * 100;
            if (quizResult < 60)
                Console.WriteLine("Your quiz score is " + quizResult + ". Therefore, you have failed the quiz");
            else
                Console.WriteLine("Your quiz score is " + quizResult + ". Therefore, you have passed the quiz");
            Console.WriteLine("Thanks for using this program - Have a nice day!");
        }

        // A function for quizing the user based on a combination of integer division and modulus ( A / B ) % C
        // Same behavior as the quiz without combinations, just 3 variables (A, B, and C)
        private void combinationQuiz()
        {
            int numQuestions = 0;

            Console.WriteLine();
            Console.WriteLine("How many times do you wish to be quizzed?");

            while (!Int32.TryParse(Console.ReadLine(), out numQuestions) || numQuestions < 1)
            {
                Console.WriteLine();
                Console.WriteLine("You have to input a number greater than 0");
                Console.WriteLine();

                if (Int32.TryParse(Console.ReadLine(), out numQuestions) == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Okay, we're good to go!");
                    Console.WriteLine();
                    break;
                }
            }

            int userResponse;
            int a;
            int b;
            int c;

            int correctAnswers = 0;

            for (int i = 0; i < numQuestions; i++)
            {
                if (i < numQuestions)
                {
                    a = rnd.Next(smallestA, largestA);
                    b = rnd.Next(smallestB, largestB);
                    c = rnd.Next(smallestC, largestC);
                    Console.WriteLine("What is the result of (" + a + " / " + b + ") % " + c + "?");
                    if (!Int32.TryParse(Console.ReadLine(), out userResponse) || userResponse != ((a / b) % c))
                        Console.WriteLine("Your answer is incorrect. " + a + " / " + b + ") % " + c + " = " + ((a / b) % c));
                    else
                    {
                        Console.WriteLine(userResponse + " is correct");
                        correctAnswers++;
                    }
                }
            }

            double quizResult = (Convert.ToDouble(correctAnswers) / Convert.ToDouble(numQuestions)) * 100;
            if (quizResult < 60)
                Console.WriteLine("Your quiz score is " + quizResult + ". Therefore, you have failed the quiz");
            else
                Console.WriteLine("Your quiz score is " + quizResult + ". Therefore, you have passed the quiz");
            Console.WriteLine("Thanks for using this program - Have a nice day!");
        }

        // The logic of the entire program
        public void userInterface()
        {
            int option;

            // Prompt the user to select an operation to be quizzed on
            while(!Int32.TryParse(Console.ReadLine(), out option) || validNumberInput(option) == false)
            {
                Console.WriteLine();
                Console.WriteLine("You have to input a number from 1 to 5.");
                Console.WriteLine();
                outputMenu();

                if(validNumberInput(option) == true)
                {
                    break;
                }
            }

            // The user takes the quiz
            switch(option)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("I will ask you to tell me the result of ");
                    Console.WriteLine("     A % B");
                    smallestAndLargestValues();
                    quizWithoutCombinations(option);
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("I will ask you to tell me the result of ");
                    Console.WriteLine("     A * B");
                    smallestAndLargestValues();
                    quizWithoutCombinations(option);
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("I will ask you to tell me the result of ");
                    Console.WriteLine("     A / B");
                    smallestAndLargestValues();
                    quizWithoutCombinations(option);
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("I will ask you to tell me the result of ");
                    Console.WriteLine("    (A / B) % C (integer division, then modulus)");
                    smallestAndLargestValuesForCombinations();
                    combinationQuiz();
                    break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("Thanks for using this program - Have a nice day!");
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Quiz q = new Quiz();
            q.userInterface();
        }
    }
}
