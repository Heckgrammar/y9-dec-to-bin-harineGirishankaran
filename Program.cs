using System; 
using System.Collections.Generic; 
using System.ComponentModel; 
using System.Linq;
using System.Linq.Expressions;
using System.Text; 
using System.Threading.Tasks; 
namespace Y9_DEC_TO_BIN_SKELETON 
{
    internal class Program
    {
        static void Main(string[] args)

        {

            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode) 
            //int myInt = 0; //just for testing single stepping 
            //string myString = "12"; //watch me being cast from string to int 
            // int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int 
            //Console.WriteLine(myStringAsInt); 
            //string twelve = "is twelve"; 
            //Console.WriteLine(myString = myString + " " + twelve); 

            //MAIN:  NUMBER CONVERSION PROGRAM 
            //CODE GOES HERE 

            Console.WriteLine("welcome");


        }
            //static void means the function will not return a value so it does not need a data type  
            //...this function DOES return a value so the method must have a data type 

             static string numberConversion(int number, int numberbase)
            {
                Console.WriteLine("Enter a number");
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                int[] binaryNumber = { 0, 0, 0, 0, 0, 0, 0, 0, };
                for (int i = 0; i < binaryNumber.Length; i++)
                {
                    binaryNumber[i] = 2 % inputNumber;
                    inputNumber = inputNumber / 2;
                }

                for (int i = 0; i < binaryNumber.Length; i++)

                {
                    Convert.ToString(binaryNumber[i]);
                }
                string result = binaryNumber[7] + binaryNumber[6] + binaryNumber[5] + binaryNumber[4] + binaryNumber[3] + binaryNumber[2] + binaryNumber[1] + binaryNumber[0];
                return result; //REMOVE THE RED LINE! 

                Console.ReadLine();

            }
        }
    }
