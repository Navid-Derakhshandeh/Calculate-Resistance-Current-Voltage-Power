//Navid-Derakhshandeh
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RVCP
{
    class Power
    {
        private double P;
        
        public Power()
        {
            Console.WriteLine("Please Enter the Voltage Number : ");
            double V = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the Current Number : ");
            double I = Double.Parse(Console.ReadLine());

            P = V * I;

            Console.WriteLine("Power Equal by : {0}.", P);
        }
    
        public static void ClassMethod()
        {
            Console.WriteLine("Please Enter the Voltage Number : ");
            double V = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the Resistance Number : ");
            double R = Double.Parse(Console.ReadLine());

            double I;

            I = V / R;

            Console.WriteLine(" Current Equal by : {0}.", I);
        }

    }
    class voltage
    {
        
        public static void ClassMethod()
        {
            Console.WriteLine("Please Enter the Current Number : ");
            double I = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the Resistance Number : ");
            double R = Double.Parse(Console.ReadLine());

            double V = I * R;

            Console.WriteLine(" Voltage Equal by : {0}.", V);
        }
    }
    class Resistance
    {
        private double R;
        public Resistance()
        {
            Console.WriteLine("Please Enter the Voltage Number : ");
            double V = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the Current Number : ");
            double I = Double.Parse(Console.ReadLine());

            R = V / I;

            Console.WriteLine("Resistance Equal by : {0}.", R);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine("              ##########################             ");
                Console.WriteLine("                ######################             ");
                Console.WriteLine("                    ##############                 ");
                Console.WriteLine("                      V = I * R                                     ");
                Console.WriteLine("                      R = V / I                                     ");
                Console.WriteLine("                      I = V / R                                     ");
                Console.WriteLine("                      P = V * I                                     ");
                Console.WriteLine("                    ##############                 ");
                Console.WriteLine("                ######################             ");
                Console.WriteLine("              ##########################             ");
                Console.WriteLine("Please Choose your Formula : ");
                Console.WriteLine("1.Power : ");
                Console.WriteLine("2.Resistance : ");
                Console.WriteLine("3.Current : ");
                Console.WriteLine("4.Voltage : ");

                int c = Int32.Parse(Console.ReadLine());

                do
                {
                    switch (c)
                    {

                        case 1:
                            Power obj1 = new Power();
                            break;
                        case 2:
                            Resistance obj2 = new Resistance();
                            break;
                        case 3:
                            Power.ClassMethod();
                            break;
                        case 4:
                            voltage.ClassMethod();
                            break;
                        default:
                            Console.WriteLine("End");
                            break;
                    }

                } while ((c != 1) && (c != 2) && (c != 3) && (c != 4));

            }
           
        }
    }
}
