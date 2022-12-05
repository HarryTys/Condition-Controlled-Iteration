using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace C_Sharp_Controlled_Iteration
{
    class C_Sharp_Controlled_Iteration
    {
        static void CompoundInterest()
        {
            Console.WriteLine("How much money do you have to start of with...");
            float startMoney = float.Parse(Console.ReadLine());
            Console.WriteLine("Now enter your current interest rate percentage...");
            float interestRate = float.Parse(Console.ReadLine()) / 100;
            Console.WriteLine("Now enter how much you wish to have...");
            float endMoney = float.Parse(Console.ReadLine());
            float interestMoney = 0;
            bool x = true;

            while (x)
                if (interestMoney < endMoney)
                {
                    interestMoney = interestMoney + (startMoney + (startMoney * interestRate));
                    startMoney = startMoney + (startMoney * interestRate);
                    Console.WriteLine(interestMoney);
                }

            if (startMoney == endMoney)
            {
                Console.WriteLine("You already have your desired amount!");
                x = false;
            }

            if (startMoney > endMoney)
            {
                Console.WriteLine(interestMoney);
                x = false;
            }

        }

        static void CarValue()
        {
            Console.WriteLine("Please enter how much the car was sold for new...");
            float soldNew = float.Parse(Console.ReadLine());
            Console.WriteLine("How much does the car cost now...");
            float soldNow = float.Parse(Console.ReadLine());
            int iterations = 0;

            while (soldNew > soldNow)
            {
                Console.WriteLine(2022 - iterations + " " + soldNew);
                soldNew = (float)(soldNew - (soldNew * 0.3));
                iterations++;

                if (iterations == 2 && soldNew > soldNow)
                {
                    while (soldNew > soldNow)
                    {
                        Console.WriteLine(2022 - iterations + " " + soldNew);
                        soldNew = (float)(soldNew - (soldNew * 0.2));
                        iterations++;
                    }
                }
            }
        }

        static void Discount()
        {
            Random rnd = new Random();
            int initialDiscount = 10;
            int randomDiscount = rnd.Next(1, 50);
            while (initialDiscount < 60)
            {
                Console.WriteLine(initialDiscount + "% off!  X");
                initialDiscount = initialDiscount + randomDiscount;
                randomDiscount = rnd.Next(1, 50 - randomDiscount);
            }
            Console.WriteLine("60% off!");
        }

        static void Lottery()
        {
            int week = 1;
            Random rnd = new Random();
            int ball1 = rnd.Next(1, 30), ball2 = rnd.Next(1, 30), ball3 = rnd.Next(1, 30);
            Console.WriteLine(ball1 + " " + ball2 + " " + ball3);
            Console.WriteLine("Take your first guess...");
            int firstGuess = int.Parse(Console.ReadLine());
            Console.WriteLine("Take your second guess...");
            int secondGuess = int.Parse(Console.ReadLine());
            Console.WriteLine("Take your third guess...");
            int thirdGuess = int.Parse(Console.ReadLine());

            if (ball1 == firstGuess && ball2 == secondGuess && ball3 == thirdGuess) { Console.WriteLine("you have hit the jackpot!"); }

            while ((ball1 == firstGuess && ball2 == secondGuess && ball3 == thirdGuess) == false)
            {
                ball1 = rnd.Next(1, 30); ball2 = rnd.Next(1, 30); ball3 = rnd.Next(1, 30);
                Console.WriteLine(ball1 + " " + ball2 + " " + ball3);
                Console.WriteLine("Oh no try again, take your first guess...");
                firstGuess = int.Parse(Console.ReadLine());
                Console.WriteLine("Take your second guess...");
                secondGuess = int.Parse(Console.ReadLine());
                Console.WriteLine("Take your third guess...");
                thirdGuess = int.Parse(Console.ReadLine());
                if (ball1 == firstGuess && ball2 == secondGuess && ball3 == thirdGuess) { Console.WriteLine("you have hit the jackpot! It has taken you " + week + " weeks to win the lottery"); break; }
                else { week++; }
            }
        }

        static void CashPoint()
        {
            Console.WriteLine("How much would you like to widthdraw?");
            int cash = int.Parse(Console.ReadLine());
            while (cash > 0)
            {
                if (cash - 20 > 20) { cash = cash - 20; Console.WriteLine("£20 note dispensed"); }
                else if (cash - 10 > 10) { cash = cash - 10; Console.WriteLine("£10 note dispensed"); }
                else if (cash - 5 > 5) { cash = cash - 5; Console.WriteLine("£5 note dispensed"); }
            }
        }

        static void SquareRoot()
        {
            Console.WriteLine("Enter a number...");
            int number = int.Parse(Console.ReadLine());
            int manipulatedNumber = number - 1;
            while (manipulatedNumber != number)
            {
                if (manipulatedNumber * manipulatedNumber == number)
                {
                    Console.WriteLine(manipulatedNumber + " = the square root of your number");
                    break;
                }
                manipulatedNumber = manipulatedNumber - 1;
                if (manipulatedNumber < 0)
                {
                    Console.WriteLine("Your number does not have a square root.");
                    break;
                }
            }
        }

        static void DenaryToBinary()
        {
            string binary = "";
            Console.WriteLine("Enter a number...");
            int number = int.Parse(Console.ReadLine());
            while (number != 0)
            {
                int nextBinary = number % 2;
                number = number / 2;
                binary = nextBinary + binary;
            }
            Console.WriteLine(binary);
        }

        static void HappyNumbers()
        {
            int fours = 0;
            List<double> numberList = new List<double>();
            Console.WriteLine("Enter a number..."); string number = Console.ReadLine();
            while (int.Parse(number) != 1)
            {
                for (int x = 0; x < number.Length; x++)
                {
                    double num = Math.Pow(int.Parse(Convert.ToString(number[x])), 2);
                    if (num == 4) { fours++; }
                    if (fours == 5) { Console.WriteLine("Sad Number!"); Thread.Sleep(10000); Environment.Exit(0); }
                    numberList.Add(num);
                }
                number = Convert.ToString(numberList.Sum());
                numberList.ForEach(i => Console.Write(Convert.ToString(i) + " + ", "\n"));
                Console.WriteLine(" = " + number);
                if (int.Parse(number) == 1) { Console.WriteLine("Happy Number!"); Thread.Sleep(10000); Environment.Exit(0); }
                numberList.Clear();
            }
        }

        static void PredatorPrey()
        {
            double a = 0.8; double b = 0.5; double c = 0.1; double d = 0.3; double e = 2.718; int generation = 0;
            Console.WriteLine("How many predators are there in this environment:");
            double predators = int.Parse(Console.ReadLine());
            Console.WriteLine("How many prey are in this environemnt:");
            double prey = int.Parse(Console.ReadLine());
            if (predators < 2) { Console.WriteLine("You cant have less than 2 predators otherwise the species will go extinct."); }
            else if (prey < 2) { Console.WriteLine("You cant have less than 2 prey otherwise the species will go extinct."); }
            while (predators > 2 && prey > 2)
            {
                double preyGrowthRate = Math.Pow(e, a - (c * predators));
                prey = prey * preyGrowthRate;
                double predatorGrowthRate = Math.Pow(e, ((d * c * prey) - b));
                predators = predators * predatorGrowthRate;
                generation++;
                Console.WriteLine($"at the end of generation {generation}, there is:\npredators: {Math.Round(predators)}  predator growth rate: {predatorGrowthRate}\nprey: {Math.Round(prey)}  prey growth rate: {preyGrowthRate}"); Thread.Sleep(1000);
            }
            Console.WriteLine("The predators and prey have gone extinct");
        }

        static void Main()
        {
            Console.WriteLine("Enter 1 for Compound interest, enter 2 for car value, enter 3 for Discount generator, enter 4 for the lottery, enter 5 for cashpoint, enter 6 for prime number calculator, enter 7 for denary to binary, enter 8 for happy numbers, enter 9 for predator prey problem");

            int decision = int.Parse(Console.ReadLine());
            if (decision == 1)
            {
                CompoundInterest();
                Console.ReadLine();
            }
            if (decision == 2)
            {
                CarValue();
                Console.ReadLine();
            }
            if (decision == 3)
            {
                Discount();
                Console.ReadLine();
            }
            if (decision == 4)
            {
                Lottery();
                Console.ReadLine();
            }
            if (decision == 5)
            {
                CashPoint();
                Console.ReadLine();
            }
            if (decision == 6)
            {
                SquareRoot();
                Console.ReadLine();
            }
            if(decision == 7)
            {
                DenaryToBinary();
                Console.ReadLine();
            }
            if (decision == 8)
            {
                HappyNumbers();
                Console.ReadLine();
            }
            if (decision == 9)
            {
                PredatorPrey();
                Console.ReadLine();
            }
        }
    }
}