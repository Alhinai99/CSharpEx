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

            //if (Number % 2 == 0)
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
            //if (Num1 > Num2 && Num1 > Num3)
            //{
            //    Console.WriteLine(Num1 +" is The largest Number ");

            //}
            //else if (Num2 > Num1 && Num2 > Num3)
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

            //Fahrenhite = (Celsius * 9 / 5) + 32;

            //Console.WriteLine("the degree in Fahrenheit is : " + Fahrenhite);


            ////   ===============================Simple Discount Calculator====================================

            //float Price, FinalPrice, Discount;
            //Console.WriteLine("Enter the price :  ");
            //Price = float.Parse(Console.ReadLine());

            //if (Price > 100)
            //{
            //    Discount = Price * 10 / 100;
            //    FinalPrice = Price - Discount;
            //    Console.WriteLine("Final price is : " + FinalPrice);
            //}
            //else
            //{
            //    Console.WriteLine("Final price is : " + Price);
            //}

            ////  ============================== Grading System =====================================

            //int StudentMark;

            //Console.WriteLine("Enter Student Mark : ");
            //StudentMark = int.Parse(Console.ReadLine());

            //if (StudentMark > 100)
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
            //    Console.WriteLine("Error");
            //}

            ////   ==============================Swap Two Numbers =====================================

            //int Num1, Num2 , Store; // "store" To store one of the number before swaping.

            //Console.WriteLine("Enter 2 Numbers to Swap them : ");
            //Num1 = int.Parse(Console.ReadLine());
            //Num2 = int.Parse(Console.ReadLine());
            //Store = Num1;
            //Num1 = Num2;
            //Num2 = Store;

            //Console.WriteLine(Num1 +","+ Num2);


            ////  ==============================Days to Weeks and Days Converter====================================

            //int Days, weeks, RemaningDays;
            //Console.WriteLine("Enter number of days to convort to weeks: ");
            //Days = int.Parse(Console.ReadLine());
            //weeks = Days / 7;
            //RemaningDays = Days % 7;

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
            //}
        }

    }
}
