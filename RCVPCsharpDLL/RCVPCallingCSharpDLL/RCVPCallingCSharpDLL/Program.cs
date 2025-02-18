using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCVPCsharpDLL;
namespace RCVPCallingCSharpDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Current Value : ");
            double I = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the Voltage Value : ");
            double V = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the Resistance Value : ");
            double R = Double.Parse(Console.ReadLine());

            double P = RCVPCSDLL.Power(V, I);
            double C = RCVPCSDLL.Current(V, R);
            double RE = RCVPCSDLL.Resistance(V, I);
            double VO = RCVPCSDLL.Voltage(I, R);

            Console.WriteLine("Power Equal By : {0}.", P);
            Console.WriteLine("Current Equal By : {0}.", C);
            Console.WriteLine("Resistance Equal By : {0}.", RE);
            Console.WriteLine("Voltage Equal By : {0}.", VO);
            Console.ReadKey();
        }
    }
}
