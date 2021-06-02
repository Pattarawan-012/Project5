using System;

namespace Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double ScoreNumberone = 0;
                double ScoreForSum = 0;
                int NumberofLevel = 0;
                double CorrectAnswer = 0;
                int ManyAnswer;
                bool CheckInput = false;
                while (CheckInput == false)
                {

                    Difficulty level;
                    level = (Difficulty)NumberofLevel;
                    Console.WriteLine("Score: {0}, Difficulty: {1}", ScoreForSum, level);
                    if (NumberofLevel == 0)
                    {
                        NumberofLevel += 3;
                    }
                    else if (NumberofLevel == 1)
                    {
                        NumberofLevel += 4;
                    }
                    else if (NumberofLevel == 2)
                    {
                        NumberofLevel += 5;
                    }

                    Console.WriteLine("Please input. \n Number 0 = Start \n Number 1 = Setting \n Number 2 = End");
                    int NumberForSetting = int.Parse(Console.ReadLine());
                    if (NumberForSetting == 0 || NumberForSetting == 1 || NumberForSetting == 2)
                    {
                        if (NumberForSetting == 0)
                        {
                            DateTimeOffset.Now.ToUnixTimeSeconds();
                            DateTime set = DateTime.UtcNow;
                            long unixTime = ((DateTimeOffset)set).ToUnixTimeSeconds();

                            PROBLEM[] problem = GENERATERANDOMPROBLES(NumberofLevel);
                            foreach (PROBLEM test in problem)
                            {
                                Console.WriteLine("Question : " + test.Message);
                                Console.Write("Answer : ");
                                int Answer = int.Parse(Console.ReadLine());
                                if (Answer == test.Answer)
                                {
                                    CorrectAnswer++;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect answer.");
                                }
                            }
                            ManyAnswer = NumberofLevel;

                            if (NumberofLevel == 3)
                            {
                                NumberofLevel -= 3;
                            }
                            else if (NumberofLevel == 5)
                            {
                                NumberofLevel -= 4;
                            }
                            else if (NumberofLevel == 7)
                            {
                                NumberofLevel -= 5;
                            }

                            DateTime rule = DateTime.UtcNow;
                            long unixTime1 = ((DateTimeOffset)rule).ToUnixTimeSeconds();


                            double SpendTime;
                            SpendTime = unixTime1 - unixTime;
                            Console.WriteLine("Time : " + SpendTime);
                            Console.WriteLine("Correct Answer : " + CorrectAnswer);
                            Console.WriteLine("NumberLevel : " + NumberofLevel);

                            double sum_1 = (CorrectAnswer / ManyAnswer)
                                , sum_2 = (25 - Math.Pow(NumberofLevel, 2)) / (Math.Max(SpendTime, 25 - Math.Pow(NumberofLevel, 2)))
                                , sum_3 = Math.Pow(((2 * NumberofLevel) + 1), 2);

                            ScoreNumberone = sum_1 * sum_2 * sum_3;

                            ScoreForSum += ScoreNumberone;

                            CorrectAnswer = 0;
                        }
                        else if (NumberForSetting == 1)
                        {
                            bool CheckLevel = false;
                            while (CheckLevel == false)
                            {
                                Console.WriteLine("Please input level. \n Number 0 = Easy \n Number 1 = Normal \n Number 2 = Hard");
                                NumberofLevel = int.Parse(Console.ReadLine());
                                if (NumberofLevel != 0 && NumberofLevel != 1 && NumberofLevel != 2)
                                {
                                    Console.WriteLine("Please input Level tryagain. \n" + NumberofLevel);
                                }
                                else
                                    CheckLevel = true;
                            }
                        }
                        else if (NumberForSetting == 2)
                        {
                            CheckInput = true;
                        }
                    }
                    else
                        Console.WriteLine("Please input 0 - 2. \n");
                }
            }
        }
        enum Difficulty
        {
            Easy,
            Normal,
            Hard
        }
        struct PROBLEM
        {
            public string Message;
            public int Answer;

            public PROBLEM(string message, int answer)
            {
                Message = message;
                Answer = answer;
            }
        }
        static PROBLEM[] GENERATERANDOMPROBLES(int numProblem)
        {
            PROBLEM[] RANDOMProblems = new PROBLEM[numProblem];

            Random rnd = new Random();
            int x, y;
            for (int i = 0; i < numProblem; i++)
            {
                x = rnd.Next(50);
                y = rnd.Next(50);
                if (rnd.NextDouble() >= 0.5)
                {
                    RANDOMProblems[i] = new PROBLEM(String.Format("{0} + {1} = ?", x, y), x + y);
                }
                else
                    RANDOMProblems[i] = new PROBLEM(String.Format("{0} - {1} = ?", x, y), x - y);
            }

            return RANDOMProblems;
        }
    }
}