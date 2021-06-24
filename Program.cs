using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem
{
    class Program
    {
        
        static void Main(string[] args)
        {
            System.Console.WriteLine("enter user height in meters");
           
           double  height = Convert.ToInt32(Console.ReadLine());
           
            System.Console.WriteLine("enter user weight in kilogram");
           
            double weight = Convert.ToInt32(Console.ReadLine());
            
            
            double BMI;
            BMI = weight /Math.Sqrt(height);
            if(BMI<18.5)
            {
                System.Console.WriteLine("Underwieght");
            }
            else if(BMI>=25)
            {
                System.Console.WriteLine("overwieght");

            }
            else
            {
                System.Console.WriteLine("healthy");
            }


        }
    }
}
