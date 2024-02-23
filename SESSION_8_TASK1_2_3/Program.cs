using SESSION_8_TASK1_2_3.TASK_1;
using SESSION_8_TASK1_2_3.TASK_2;
using SESSION_8_TASK1_2_3.TASK_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SESSION_8_TASK1_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("-----------------------TASK 1-----------------------");
            Circle circle1 = new Circle("C1",1,Opacity.Solid,Color.Red,10.5);
            double C1=circle1.CalculateArea();
            circle1.ShowShapeData();
            Console.WriteLine($"AREA = {C1} M2");
            
            Square square1 = new Square("S1", 2, Opacity.SemiSolid, Color.Blue, 10);
            double S1 = square1.CalculateArea();
            square1.ShowShapeData();
            Console.WriteLine($"AREA = {S1} M2");
            
            Rectangle rectangle1 = new Rectangle("R1", 3, Opacity.Transparent, Color.Green,5, 10);
            rectangle1.ShowShapeData();
            Console.WriteLine($"AREA = {rectangle1.CalculateArea()} M2");

            //---------------------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------------------

            //TASK 2

            Console.WriteLine("-----------------------TASK 2-----------------------");

            Console.WriteLine($"ResultOf 2^2={ TASK_2.Math.Power_2(2)}");
            Console.WriteLine($"ResultOf 2^3={TASK_2.Math.Power_n(2, 3)}"); 
            Console.WriteLine($"SquareRoot16={TASK_2.Math.SquareRoot(16)}");
            Console.WriteLine($"Max number(-2,3) = {TASK_2.Math.MaxNumber(-2, 3)}");
            Console.WriteLine($"Min number(-2,3) ={TASK_2.Math.MinNumber(-2, 3)}"); 
            Console.WriteLine($"Absolute number(-15.8)= { TASK_2.Math.Absolute(-15.8)}"); 


            //---------------------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------------------

            //TASK 3
            Console.WriteLine("-----------------------TASK 3-----------------------");
            SavingAccount SS1 = new SavingAccount("AMR", 1);
            
            SS1.Deposit(10000);
            SS1.Withdraw(9000);
            SS1.ShowAccountData();

            Console.WriteLine("---------------------------------------------------");
            CheckingAccount CC1 = new CheckingAccount("Ahmed", 2);

            CC1.Deposit(30000);
            CC1.Withdraw(20000);
            CC1.ShowAccountData();
        }
    }
}
