namespace CSharpEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// ===================================Even OR ODD=====================================

            //int Number;
            //Console.WriteLine("Enter a number To check if the number even or odd : ");
            //Number = int.Parse(Console.ReadLine());

            //if (Number % 2 == 0) ////  % 2 == 0  to check if the number is even or odd
            //{
            //    Console.WriteLine("the Number u Entered Is : EVEN ");

            //}
            //else
            //{
            //    Console.WriteLine("the Number u Entered Is : ODD ");
            //}



            ////  =================================Largest of Three Numbers==================================

            //int Num1, Num2, Num3;
            //Console.WriteLine("Enter three Numbers To check which is The largest ");
            //Num1 = int.Parse(Console.ReadLine());
            //Num2 = int.Parse(Console.ReadLine());
            //Num3 = int.Parse(Console.ReadLine());
            //if (Num1 > Num2 && Num1 > Num3) ////  to check if the first number is the largest
            //{
            //    Console.WriteLine(Num1 +" is The largest Number ");

            //}
            //else if (Num2 > Num1 && Num2 > Num3) ////  to check if the second number is the largest
            //{
            //    Console.WriteLine(Num2 + " is The largest Number ");

            //}
            //else
            //{
            //    Console.WriteLine(Num3 + " is The largest Number ");
            //}


            ////  ===============================Temperature Converter====================================

            //int Celsius , Fahrenhite;

            //Console.WriteLine("Enter Celsius Degree to convert to Fahrenheit ");
            //Celsius = int.Parse(Console.ReadLine());

            //Fahrenhite = (Celsius * 9 / 5) + 32; ////  the formula to convert Celsius to Fahrenheit

            //Console.WriteLine("the degree in Fahrenheit is : " + Fahrenhite);


            ////   ===============================Simple Discount Calculator====================================

            //float Price, FinalPrice, Discount;
            //Console.WriteLine("Enter the price :  ");
            //Price = float.Parse(Console.ReadLine());

            //if (Price > 100) ////  if the price is more than 100$ the discount will be 10%
            //{
            //    Discount = Price * 10 / 100;
            //    FinalPrice = Price - Discount;
            //    Console.WriteLine("Final price is : " + FinalPrice);
            //}
            //else  ////  if the price is less than 100$ no discount
            //{
            //    Console.WriteLine("Final price is : " + Price);
            //}

            ////  ============================== Grading System =====================================

            //int StudentMark;

            //Console.WriteLine("Enter Student Mark : ");
            //StudentMark = int.Parse(Console.ReadLine());

            //if (StudentMark > 100)////  if the mark is more than 100
            //{
            //    Console.WriteLine("Error");
            //}
            //else if (StudentMark >= 90)
            //{
            //    Console.WriteLine("The grade is : A");
            //}
            //else if (StudentMark >= 80)
            //{
            //    Console.WriteLine("The grade is : B");
            //}
            //else if (StudentMark >= 70)
            //{
            //    Console.WriteLine("The grade is : C");
            //}
            //else if (StudentMark >= 60)
            //{
            //    Console.WriteLine("The grade is : D");
            //}
            //else if (StudentMark < 60 && StudentMark >= 0)
            //{
            //    Console.WriteLine("The grade is : D");
            //}
            //else
            //{
            //    Console.WriteLine("Error");////  if the mark is less than 0
            //}

            ////   ==============================Swap Two Numbers =====================================

            //int Num1, Num2 , Store; // "store" To store one of the number before swaping.

            //Console.WriteLine("Enter 2 Numbers to Swap them : ");
            //Num1 = int.Parse(Console.ReadLine());
            //Num2 = int.Parse(Console.ReadLine());
            //Store = Num1; ////  store the first number in the store variable
            //Num1 = Num2;  ////  put the second number in the first number
            //Num2 = Store; ////  put the first number in the second number

            //Console.WriteLine(Num1 +","+ Num2);


            ////  ==============================Days to Weeks and Days Converter====================================

            //int Days, weeks, RemaningDays;
            //Console.WriteLine("Enter number of days to convort to weeks: ");
            //Days = int.Parse(Console.ReadLine());
            //weeks = Days / 7; ////  to get the number of weeks
            //RemaningDays = Days % 7; ////  to get the remaining days

            //Console.WriteLine("Number of weeks : " + weeks + "\nNumber of Days : " + RemaningDays);

            ////   ===============================Electricity Bill Calculator ====================================

            //Double Unit;
            //Console.WriteLine("Enter Number of Unit: ");
            //Unit = double.Parse(Console.ReadLine());
            //if (Unit > 300)
            //{
            //    Unit = Unit * 1;
            //    Console.WriteLine("The bill is : " + Unit + "$");
            //}
            //else if (Unit > 100)
            //{
            //    Unit = Unit * 0.75;
            //    Console.WriteLine("The bill is : " + Unit + "$");
            //}
            //else if (Unit <= 100 && Unit > 0)
            //{
            //    Unit = Unit * 0.5;
            //    Console.WriteLine("The bill is : " + Unit + "$");
            //}
            //else {
            //    Console.WriteLine("Error");
            //}

            ////   =============================== Simple Calculator  ====================================


            //float Num1, Num2;
            //string Operation;
            //Console.WriteLine("Enter first number :");
            //Num1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number : ");
            //Num2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the operation (/, * , + , -)");
            //Operation = Console.ReadLine();

            //if (Operation == "/")
            //{
            //    Console.WriteLine("the Result is : " + Num1 / Num2);
            //}
            //else if (Operation == "*")
            //{
            //    Console.WriteLine("the Result is : " + Num1 * Num2);
            //}
            //else if (Operation == "+")
            //{
            //    Console.WriteLine("the Result is : " + (Num1 + Num2));
            //}
            //else if (Operation == "-")
            //{
            //    Console.WriteLine("the Result is : " + (Num1 - Num2));
            //}
            //else
            //{
            //    Console.WriteLine("Erorr");
            //    }


            //==================                     =======================================
            //=================== C# Part2 Exercises =======================================
            //==================                     =======================================














            while (true) ////  to keep the program running
            {
                Console.Clear(); ////  to clear the console
                Console.WriteLine("\nSelect a Program:");
                Console.WriteLine("1. Simple Calculator");
                Console.WriteLine("2. Basic ATM System");
                Console.WriteLine("3. Geometry Calculator");
                Console.WriteLine("4. Factorial of a Number");
                Console.WriteLine("5. Sum of Even and Odd Numbers");
                Console.WriteLine("6. Scientific Calculator");
                Console.WriteLine("7. Print Triangle Pattern");
                Console.WriteLine("8. Print Pyramid Pattern");
                Console.WriteLine("9. Print Diamond Pattern");
                Console.WriteLine("10. Guess the Number Game");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice) ////  to choose the program
                {
                    case 1: SimpleCalculator(); break;
                    case 2: BasicATM(); break;
                    case 3: GeometryCalculator(); break;
                    case 4: Factorial(); break;
                    case 5: SumEvenOdd(); break;
                    case 6: ScientificCalculator(); break;
                    case 7: PrintTriangle(); break;
                    case 8: PrintPyramid(); break;
                    case 9: PrintDiamond(); break;
                    case 10: GuessGame(); break;
                    case 0: return;
                    default: Console.WriteLine("Invalid Choice! Try again."); break;
                }
                Console.ReadLine();
            }











        }

            static void SimpleCalculator() {
            //=====================Simple Calculator (Switch-Case)================================

            Console.WriteLine("Enter First number: ");
            double Num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number: ");
            double Num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Select Operation :\n1.Add(+) \n2.Sup(-)\n3.Multiple(*)\n4.Dev(/)\n");
            int operation = int.Parse(Console.ReadLine());
            switch (operation) ////  to choose the operation
            {
                case 1: ////  to add
                    Console.WriteLine("the Result is= " + (Num1 + Num2));
                    break;
                case 2: ////  to substract
                    Console.WriteLine("the Result is= " + (Num1 - Num2));
                    break;
                case 3: ////  to multiply
                    Console.WriteLine("the result is =" + (Num1 * Num2));
                    break;
                case 4: ////  to devide
                    if (Num2 != 0)
                        Console.WriteLine("The Result is =" + (Num1 / Num2));
                    else ////  if the second number is zero
                        Console.WriteLine("Can't devide by Zero");
                    break;
            }          
            }   


        static void BasicATM() {
                //===================== Basic ATM System================================

                double Balance = 1000;
                double Deposit_Draw;
                int Service;
                do
                {
                Console.Clear();
                Console.WriteLine("Welcome To ATM please choose Number of the service:\n1.Deposit\n2.withdraw\n3.Check Balance\n4.Exit");
                    Service = int.Parse(Console.ReadLine());



                    switch (Service) ////  to choose the service
                {
                        case 1: ////  to deposit
                        Console.WriteLine("insert The money: ");
                            Deposit_Draw = double.Parse(Console.ReadLine());
                            Balance = Balance + Deposit_Draw;
                            Console.ReadLine();

                        break;
                        case 2: ////  to withdraw
                        Console.WriteLine("how much You want to withdraw : ");
                            Deposit_Draw = double.Parse(Console.ReadLine());
                            if (Balance >= Deposit_Draw)
                                Balance = Balance - Deposit_Draw;


                        else ////  if the balance is less than the amount
                            Console.WriteLine("Cant withDraw Low Balance ");
                                Console.ReadLine();

                        break;
                        case 3: ////  to check the balance
                        Console.WriteLine("Your Balance is : " + Balance);
                            Console.ReadLine();
                                break;
                    }
                     Console.ReadLine();

            }
                while (Service != 4);
            }

            static void GeometryCalculator() {
                //===================== Geometry Calculator ================================

                int Shape;

                do
                {
                Console.Clear();

                Console.WriteLine("\n Welcome To Geometry Calculator  please choose Number of the Shape:\n1.Circle\n2.Square\n3.Triangle\n4.Exit");

                    Shape = int.Parse(Console.ReadLine());

                    int Raduis, Side, Hight, Base;
                    double Pi = 3.141;

                    switch (Shape) ////  to choose the shape
                {
                        case 1:
                            Console.WriteLine("Enter the Radius of the Circle: ");
                            Raduis = int.Parse(Console.ReadLine());
                            Console.WriteLine("The Area of the Circle is: " + (Pi * Raduis * Raduis));
                            Console.WriteLine("The Circumference of the Circle is: " + (Pi * 2 * Raduis));
                            break;
                        case 2:
                            Console.WriteLine("Enter the Side of the Square: ");
                            Side = int.Parse(Console.ReadLine());
                            Console.WriteLine("The Area of the Square is: " + (Side * Side));
                            Console.WriteLine("The perimeter  of the Square is: " + (Side * 4));
                            break;
                        case 3:
                            Console.WriteLine("Enter the Hight of the Triangle: ");
                            Hight = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Side of the Triangle: ");
                            Base = int.Parse(Console.ReadLine());
                            Console.WriteLine("The Area of the Triangle is: " + (0.5 * Base * Hight));
                            break;
                    }
                Console.ReadLine();
            } while (Shape != 4);
            }

            static void Factorial() {
                //===================== Factorial of a Number ================================


                int Num, i;
                double Fact;
                Console.WriteLine("Enter Number to get the Factorial: ");
                Num = int.Parse(Console.ReadLine());
                Fact = Num;
                for (i = 1; i < Num; i++) ////  to get the factorial of the number
            {
                    Fact = Fact * i;
                }
                Console.WriteLine("Factorial of a Number :" + Fact);
            }

            static void SumEvenOdd() {

                //===================== Sum of Even and Odd Numbers ================================


                double number, even = 0, odd = 0, i = 1;
                Console.WriteLine("Enter   number  ");
                number = double.Parse(Console.ReadLine());
            do ////  to get the sum of even and odd numbers
            {
                    if (i % 2 == 0)
                    {
                        even += i;
                    }
                    else
                    {
                        odd += i;
                    }
                    i++;
                } while (i <= number);
                Console.WriteLine("even   number  " + even);
                Console.WriteLine("odd   number  " + odd);
            }


            static void ScientificCalculator() {
                //===================== Scientific Calculator (Switch-Case & Math Functions)  ================================


                int operation;


                Console.WriteLine("Select Operation :\n1.sin \n2.cos\n3.tan\n4.sqrt\n5.log\n6.pow");
                operation = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Number : ");
                double Num1 = double.Parse(Console.ReadLine());

                switch (operation) ////  to choose the operation
            {
                    case 1:
                        Console.WriteLine("the Result is= " + Math.Sin(Num1));
                        break;
                    case 2:
                        Console.WriteLine("the Result is= " + (Math.Cos(Num1)));
                        break;
                    case 3:
                        Console.WriteLine("the result is =" + (Math.Tan(Num1)));
                        break;
                    case 4:
                        Console.WriteLine("The Result is =" + (Math.Sqrt(Num1)));
                        break;
                    case 5:
                        Console.WriteLine("The Result is =" + (Math.Log(Num1)));
                        break;
                    case 6:
                        Console.WriteLine("Enter the power :");
                        int Power = int.Parse(Console.ReadLine());
                        Console.WriteLine("The Result is =" + (Math.Pow(Num1, Power)));
                        break;
                }


            }


            static void PrintTriangle() {
                //=====================  Print Pattern (For Loop)  ================================
                int Number, i, j;

                Console.WriteLine("Enter Number:");
                Number = int.Parse(Console.ReadLine());
                for (i = 1; i <= Number; i++) ////  to print the triangle
            {

                    for (j = 1; j <= i; j++) ////  to print the stars
                {
                        Console.Write("*");
                    }
                    Console.WriteLine();

                }

            }


            static void PrintPyramid() {
                //=====================  Print a Pyramid Pattern (For Loop)   ================================


                int n;
                Console.WriteLine("Enter Number");
                n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++) ////  to print the pyramid
            {
                    for (int j = 1; j <= n - i; j++) ////  to print the spaces
                {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= 2 * i - 1; k++) ////  to print the stars
                {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            static void PrintDiamond() {
                //=====================  Print a Diamond Pattern(For Loop)  ================================


                int n;
                Console.WriteLine("Enter Number");
                n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++) ////  to print the first half of the diamond
            {
                    for (int j = 1; j <= n - i; j++) ////  to print the spaces
                {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= 2 * i - 1; k++) ////  to print the stars
                {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int i = n - 1; i >= 1; i--) ////  to print the second half of the diamond
            {
                    for (int j = 1; j <= n - i; j++) ////  to print the spaces
                {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= 2 * i - 1; k++) ////  to print the stars
                {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

            }

            static void GuessGame() {
                //===================== Guess Game with helper ================================



                int input = 0;
                Random random = new Random();
                double randomNumber = random.Next(1, 100); ////  to generate a random number between 1 and 100
            while (input != randomNumber)
                {
                    Console.WriteLine("Guess the Number: ");
                    input = int.Parse(Console.ReadLine());

                    if (input > randomNumber) ////  to check if the number is higher or lower
                    Console.WriteLine("Try Lower!");

                    else if (input < randomNumber)
                        Console.WriteLine("Try Higher!");


                }
                Console.WriteLine("You win!");
            }







        }


    }
    
    
    

