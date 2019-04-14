using System;
using System.Threading;

namespace Roulette1
{
    public class App
    {
        
        internal void Run()
        {
            bool quit = false;
            Outcome[] outcomes = new Outcome[38];
            Random randomNumber = new Random();
            
            for (int i = 0; i < outcomes.Length; ++i)
            {
                var tempOutcome = new Outcome(i, i.ToString(), 0);
                AddOutcome(i, tempOutcome);
                outcomes[i] = tempOutcome;
            }

            do
            {
                Console.Clear();
                Console.Write("Place your bet: ");

                //To Do:  throw format exception.
                //Test
                //int result = int.Parse(Console.ReadLine());
                //Game
                Console.ReadLine();
                int result = RouletteOnAction(randomNumber);

                Console.WriteLine();
                BlinkingLine("Wheel Spinning...");

                foreach (var outcome in outcomes)
                {
                    if (outcome.result == result)
                    {
                        Console.WriteLine();
                        ColorDisplay(outcome.color, outcome.display);
                    }
                }

                BlinkingLine("");
                Console.WriteLine("The winning outcomes!!");
                Numbers(result, outcomes);
                EvenOdd(result, outcomes);
                RedBlack(result, outcomes);
                LowHigh(result, outcomes);
                Dozen(result, outcomes);
                Columns(result, outcomes);
                Street(result, outcomes);
                SixNumbers(result, outcomes);
                Split(result, outcomes);
                Corner(result, outcomes);

                Console.WriteLine("\n\n\nPress R to Replay\t\t||\t\tPress E to Exit.");

                var key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.R:
                        quit = false;
                        break;
                    case ConsoleKey.E:
                        quit = true;
                        break;
                }

            } while (!quit);

        }

        private void SixNumbers(int result, Outcome[] outcomes)
        {
            Console.Write("\n6 Numbers: ");
            if (result == 0 || result == 37)
            {
                //DO NOTHING
            }
            else if (result > 0 && result < 37)
            {
                for (int i = 0; i < outcomes.Length; ++i)
                {
                    if (result > 0 && result < 4 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[1].display);
                        DisplayWinning(outcomes[2].display);
                        DisplayWinning(outcomes[3].display);
                        DisplayWinning(outcomes[4].display);
                        DisplayWinning(outcomes[5].display);
                        DisplayWinning(outcomes[6].display);
                    }
                    else if (result > 3 && result < 7 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[1].display);
                        DisplayWinning(outcomes[2].display);
                        DisplayWinning(outcomes[3].display);
                        DisplayWinning(outcomes[4].display);
                        DisplayWinning(outcomes[5].display);
                        DisplayWinning(outcomes[6].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[4].display);
                        DisplayWinning(outcomes[5].display);
                        DisplayWinning(outcomes[6].display);
                        DisplayWinning(outcomes[7].display);
                        DisplayWinning(outcomes[8].display);
                        DisplayWinning(outcomes[9].display);
                    }
                    else if (result > 6 && result < 10 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[4].display);
                        DisplayWinning(outcomes[5].display);
                        DisplayWinning(outcomes[6].display);
                        DisplayWinning(outcomes[7].display);
                        DisplayWinning(outcomes[8].display);
                        DisplayWinning(outcomes[9].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[7].display);
                        DisplayWinning(outcomes[8].display);
                        DisplayWinning(outcomes[9].display);
                        DisplayWinning(outcomes[10].display);
                        DisplayWinning(outcomes[11].display);
                        DisplayWinning(outcomes[12].display);
                    }
                    else if (result > 9 && result < 13 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[7].display);
                        DisplayWinning(outcomes[8].display);
                        DisplayWinning(outcomes[9].display);
                        DisplayWinning(outcomes[10].display);
                        DisplayWinning(outcomes[11].display);
                        DisplayWinning(outcomes[12].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[10].display);
                        DisplayWinning(outcomes[11].display);
                        DisplayWinning(outcomes[12].display);
                        DisplayWinning(outcomes[13].display);
                        DisplayWinning(outcomes[14].display);
                        DisplayWinning(outcomes[15].display);
                    }
                    else if (result > 12 && result < 16 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[10].display);
                        DisplayWinning(outcomes[11].display);
                        DisplayWinning(outcomes[12].display);
                        DisplayWinning(outcomes[13].display);
                        DisplayWinning(outcomes[14].display);
                        DisplayWinning(outcomes[15].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[13].display);
                        DisplayWinning(outcomes[14].display);
                        DisplayWinning(outcomes[15].display);
                        DisplayWinning(outcomes[16].display);
                        DisplayWinning(outcomes[17].display);
                        DisplayWinning(outcomes[18].display);
                    }
                    else if (result > 15 && result < 19 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[13].display);
                        DisplayWinning(outcomes[14].display);
                        DisplayWinning(outcomes[15].display);
                        DisplayWinning(outcomes[16].display);
                        DisplayWinning(outcomes[17].display);
                        DisplayWinning(outcomes[18].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[16].display);
                        DisplayWinning(outcomes[17].display);
                        DisplayWinning(outcomes[18].display);
                        DisplayWinning(outcomes[19].display);
                        DisplayWinning(outcomes[20].display);
                        DisplayWinning(outcomes[21].display);
                    }
                    else if (result > 18 && result < 22 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[19].display);
                        DisplayWinning(outcomes[20].display);
                        DisplayWinning(outcomes[21].display);
                        DisplayWinning(outcomes[22].display);
                        DisplayWinning(outcomes[23].display);
                        DisplayWinning(outcomes[24].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[19].display);
                        DisplayWinning(outcomes[20].display);
                        DisplayWinning(outcomes[21].display);
                        DisplayWinning(outcomes[22].display);
                        DisplayWinning(outcomes[23].display);
                        DisplayWinning(outcomes[24].display);
                    }
                    else if (result > 21 && result < 25 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[19].display);
                        DisplayWinning(outcomes[20].display);
                        DisplayWinning(outcomes[21].display);
                        DisplayWinning(outcomes[22].display);
                        DisplayWinning(outcomes[23].display);
                        DisplayWinning(outcomes[24].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[22].display);
                        DisplayWinning(outcomes[23].display);
                        DisplayWinning(outcomes[24].display);
                        DisplayWinning(outcomes[25].display);
                        DisplayWinning(outcomes[26].display);
                        DisplayWinning(outcomes[27].display);
                    }
                    else if (result > 24 && result < 28 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[22].display);
                        DisplayWinning(outcomes[23].display);
                        DisplayWinning(outcomes[24].display);
                        DisplayWinning(outcomes[25].display);
                        DisplayWinning(outcomes[26].display);
                        DisplayWinning(outcomes[27].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[25].display);
                        DisplayWinning(outcomes[26].display);
                        DisplayWinning(outcomes[27].display);
                        DisplayWinning(outcomes[28].display);
                        DisplayWinning(outcomes[29].display);
                        DisplayWinning(outcomes[30].display);
                    }
                    else if (result > 27 && result < 31 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[25].display);
                        DisplayWinning(outcomes[26].display);
                        DisplayWinning(outcomes[27].display);
                        DisplayWinning(outcomes[28].display);
                        DisplayWinning(outcomes[29].display);
                        DisplayWinning(outcomes[30].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[28].display);
                        DisplayWinning(outcomes[29].display);
                        DisplayWinning(outcomes[30].display);
                        DisplayWinning(outcomes[31].display);
                        DisplayWinning(outcomes[32].display);
                        DisplayWinning(outcomes[33].display);
                    }
                    else if (result > 30 && result < 34 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[28].display);
                        DisplayWinning(outcomes[29].display);
                        DisplayWinning(outcomes[30].display);
                        DisplayWinning(outcomes[31].display);
                        DisplayWinning(outcomes[32].display);
                        DisplayWinning(outcomes[33].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[31].display);
                        DisplayWinning(outcomes[32].display);
                        DisplayWinning(outcomes[33].display);
                        DisplayWinning(outcomes[34].display);
                        DisplayWinning(outcomes[35].display);
                        DisplayWinning(outcomes[36].display);
                    }
                    else if (result > 33 && result < 37 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[31].display);
                        DisplayWinning(outcomes[32].display);
                        DisplayWinning(outcomes[33].display);
                        DisplayWinning(outcomes[34].display);
                        DisplayWinning(outcomes[35].display);
                        DisplayWinning(outcomes[36].display);
                    }

                }
            }
        }

        private void Corner(int result, Outcome[] outcomes)
        {
            Console.Write("\nCorners: ");
            if (result == 0 || result == 37)
            {
                //DO NOTHING
            }
            else if (result > 3 && result < 34)
            {
                for (int i = 0; i < outcomes.Length; ++i)
                {
                    if (result % 3 == 1 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[i - 3].display);
                        DisplayWinning(outcomes[i - 2].display);
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 1].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 1].display);
                        DisplayWinning(outcomes[i + 3].display);
                        DisplayWinning(outcomes[i + 4].display);
                    }
                    else if (result % 3 == 2 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[i - 4].display);
                        DisplayWinning(outcomes[i - 3].display);
                        DisplayWinning(outcomes[i - 1].display);
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i - 3].display);
                        DisplayWinning(outcomes[i - 2].display);
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 1].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i - 1].display);
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 2].display);
                        DisplayWinning(outcomes[i + 3].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 1].display);
                        DisplayWinning(outcomes[i + 3].display);
                        DisplayWinning(outcomes[i + 4].display);
                    }
                    else if (result % 3 == 0 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[i - 4].display);
                        DisplayWinning(outcomes[i - 3].display);
                        DisplayWinning(outcomes[i - 1].display);
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i - 1].display);
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 2].display);
                        DisplayWinning(outcomes[i + 3].display);
                    }
                }
            }
            else if (result <= 3)
            {
                for (int i = 0; i < outcomes.Length; ++i)
                {

                    if (result % 3 == 1 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 1].display);
                        DisplayWinning(outcomes[i + 3].display);
                        DisplayWinning(outcomes[i + 4].display);
                    }
                    else if (result % 3 == 2 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[i - 1].display);
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 2].display);
                        DisplayWinning(outcomes[i + 3].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 1].display);
                        DisplayWinning(outcomes[i + 3].display);
                        DisplayWinning(outcomes[i + 4].display);
                    }
                    else if (result % 3 == 0 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[i - 1].display);
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 2].display);
                        DisplayWinning(outcomes[i + 3].display);
                    }
                }
            }
            else if (result >= 34)
            {
                for (int i = 0; i < outcomes.Length; ++i)
                {

                    if (result % 3 == 1 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[i - 3].display);
                        DisplayWinning(outcomes[i - 2].display);
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 1].display);
                    }
                    else if (result % 3 == 2 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[i - 4].display);
                        DisplayWinning(outcomes[i - 3].display);
                        DisplayWinning(outcomes[i - 1].display);
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i - 3].display);
                        DisplayWinning(outcomes[i - 2].display);
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 1].display);
                    }
                    else if (result % 3 == 0 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[i - 4].display);
                        DisplayWinning(outcomes[i - 3].display);
                        DisplayWinning(outcomes[i - 1].display);
                        DisplayWinning(outcomes[i].display);
                    }
                }
            }
        }
        
        private void Split(int result, Outcome[] outcomes)
        {
            Console.Write("\nSplit: ");
            if (result == 0 || result == 37)
            {
                DisplayWinning(outcomes[0].display);
                DisplayWinning(outcomes[37].display);
            }
            else if (result > 3 && result < 34)
            {
                for (int i = 0; i < outcomes.Length; ++i)
                {
                    if (result % 3 == 1 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 1].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i - 3].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 3].display);
                    }
                    else if (result % 3 == 2 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i - 1].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 1].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i - 3].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 3].display);
                    }
                    else if (result % 3 == 0 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i - 1].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i - 3].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 3].display);

                    }
                }
            }
            else if (result <=3)
            {
                for (int i = 0; i < outcomes.Length; ++i)
                {

                    if (result % 3 == 1 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 1].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 3].display);
                    }
                    else if (result % 3 == 2 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i - 1].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 1].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 3].display);
                    }
                    else if (result % 3 == 0 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i - 1].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 3].display);
                    }
                }
            }
            else if (result >= 34)
            {
                for (int i = 0; i < outcomes.Length; ++i)
                {

                    if (result % 3 == 1 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 1].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i - 3].display);
                    }
                    else if (result % 3 == 2 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i - 1].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i + 1].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i - 3].display);
                    }
                    else if (result % 3 == 0 && result == outcomes[i].result)
                    {
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i - 1].display);
                        DisplayWinning("OR");
                        DisplayWinning(outcomes[i].display);
                        DisplayWinning(outcomes[i - 3].display);
                    }
                }
            }
        }

        private void Street(int result, Outcome[] outcomes)
        {
            Console.Write("\nStreets: ");
            if (result>0 && result <4)
            {
                for (int i = 1; i < 4; ++i)
                {
                    DisplayWinning(outcomes[i].display);
                }
            }
            else if (result > 3 && result < 7)
            {
                for (int i = 4; i < 7; ++i)
                {
                    DisplayWinning(outcomes[i].display);
                }
            }
            else if (result > 6 && result < 10)
            {
                for (int i = 7; i < 10; ++i)
                {
                    DisplayWinning(outcomes[i].display);
                }
            }
            else if (result > 9 && result < 13)
            {
                for (int i = 10; i < 13; ++i)
                {
                    DisplayWinning(outcomes[i].display);
                }
            }
            else if (result > 12 && result < 16)
            {
                for (int i = 13; i < 16; ++i)
                {
                    DisplayWinning(outcomes[i].display);
                }
            }
            else if (result > 15 && result < 19)
            {
                for (int i = 16; i < 19; ++i)
                {
                    DisplayWinning(outcomes[i].display);
                }
            }
            else if (result > 18 && result < 22)
            {
                for (int i = 19; i < 22; ++i)
                {
                    DisplayWinning(outcomes[i].display);
                }
            }
            else if (result > 21 && result < 25)
            {
                for (int i = 22; i < 25; ++i)
                {
                    DisplayWinning(outcomes[i].display);
                }
            }
            else if (result > 24 && result < 28)
            {
                for (int i = 25; i < 28; ++i)
                {
                    DisplayWinning(outcomes[i].display);
                }
            }
            else if (result > 27 && result < 31)
            {
                for (int i = 28; i < 31; ++i)
                {
                    DisplayWinning(outcomes[i].display);
                }
            }
            else if (result > 30 && result < 34)
            {
                for (int i = 31; i < 34; ++i)
                {
                    DisplayWinning(outcomes[i].display);
                }
            }
            else if (result > 33 && result < 37)
            {
                for (int i = 34; i < 37; ++i)
                {
                    DisplayWinning(outcomes[i].display);
                }
            }
        }

        private void Columns(int result, Outcome[] outcomes)
        {
            Console.Write("\nColumns: ");
            if (result == 0 || result ==37)
            {
                //do nothing.
            }
            else if (result%3 == 0)
            {
                for (int i = 1; i < 37; ++i)
                {
                    if (result % 3 == outcomes[i].result % 3)
                    { DisplayWinning(outcomes[i].display); }
                }
            }
            else if (result % 3 == 1)
            {
                for (int i = 1; i < 37; ++i)
                {
                    if (result % 3 == outcomes[i].result % 3)
                    { DisplayWinning(outcomes[i].display); }
                }
            }
            else if (result % 3 == 2)
            {
                for (int i = 1; i < 37; ++i)
                {
                    if (result % 3 == outcomes[i].result % 3)
                    { DisplayWinning(outcomes[i].display); }
                }
            }
        }

        private void Dozen(int result, Outcome[] outcomes)
        {
            Console.Write("\nDozens: ");
            if (result > 0 && result <= 12)
            {
                for (int i = 1; i < 13; ++i)
                {
                    DisplayWinning(outcomes[i].display);
                }
            }
            else if (result > 12 && result <= 24)
            {
                for (int i = 13; i < 25; ++i)
                {
                    DisplayWinning(outcomes[i].display);
                }
            }
            else if (result > 24 && result <= 36)
            {
                for (int i = 25; i < 37; ++i)
                {
                    DisplayWinning(outcomes[i].display);
                }
            }

        }

        private void LowHigh(int result, Outcome[] outcomes)
        {
            Console.Write("\nLows/Highs: ");
            if (result > 0 && result <= 18)
            {
                for (int i = 1; i < 19; ++i)
                {
                    DisplayWinning(outcomes[i].display);
                }
            }
            else if (result > 18 && result <= 36)
            {
                for (int i = 19; i < 37; ++i)
                {
                    DisplayWinning(outcomes[i].display);
                }
            }
        }

        private void RedBlack(int result, Outcome[] outcomes)
        {
            Console.Write("\nReds/Blacks: ");
            foreach (var outcome in outcomes)
            {
                if (result >0 && result<37 && result == outcome.result )
                {
                    foreach (var outcomecolor in outcomes)
                    {
                        if (outcomecolor.color == outcome.color)
                        {
                            ColorDisplay(outcomecolor.color, outcomecolor.display);
                        }
                    }
                }
            }
        }

        private void Numbers(int result, Outcome[] outcomes)
        {
            foreach (var outcome in outcomes)
            {
                if (result == outcome.result)
                {
                    Console.WriteLine($"Numbers: {outcome.display}");
                }
            }
        }

        private void EvenOdd(int result, Outcome[] outcomes)
        {
            Console.Write("Evens/Odds: ");
            foreach (var outcome in outcomes)
            {
                if (result == 0 || result ==37)
                {
                    //Do nothing.
                }
                else if (result % 2 == 1 && outcome.result % 2 == 1 && outcome.result !=37)
                {
                    Console.Write($"{outcome.display}  ");
                }
                else if (result %2==0 && outcome.result % 2 == 0 && outcome.result != 0)
                {
                    Console.Write($"{outcome.display}  ");
                }
            }
        }

        private void BlinkingLine(string line)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(line);
                Thread.Sleep(0);
            }
        }

        private Outcome AddOutcome(int i, Outcome tempOutcome)
        {

            if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9 || i == 12 || i == 14 ||
                i == 16 || i == 18 || i == 19 || i == 21 || i == 23 || i == 25 || i == 27 ||
                i == 30 || i == 32 || i == 34 || i == 36)
            {
                tempOutcome.color = 1;
            }

            else if (i == 0)
            {
                tempOutcome.color = 3;
            }

            else if (i == 37)
            {
                tempOutcome.color = 3;
                tempOutcome.display = "00";
            }

            else
            {
                tempOutcome.color = 2;
            }

            return tempOutcome;
        }

        private void ColorDisplay(int color, string display)
        {
            switch(color)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(display);
                    Console.ResetColor();
                    Console.Write("  ");
                    break;

                case 2:
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(display);
                    Console.ResetColor();
                    Console.Write("  ");
                    break;

                case 3:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(display);
                    Console.ResetColor();
                    Console.Write("  ");
                    break;
                default:
                    Console.WriteLine(display);
                    break;
            }
        }

        private int RouletteOnAction(Random number)
        {
            int result = number.Next(0, 37);
            return result;
        }

        private static void DisplayWinning(string s)
        {
            Console.Write(s + "  ");
        }
    }
}