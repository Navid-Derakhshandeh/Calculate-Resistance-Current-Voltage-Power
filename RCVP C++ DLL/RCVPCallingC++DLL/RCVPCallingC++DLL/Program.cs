using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace RCVPCallingC__DLL
{
    class Program
    {
        public const string DLLFile = @"RCVP C++ DLL.dll";
        [DllImport(DLLFile, CallingConvention = CallingConvention.Cdecl)]
        public static extern double Power(double V1, double I1);

        [DllImport(DLLFile, CallingConvention = CallingConvention.Cdecl)]
        public static extern double Current(double V2, double R2);

        [DllImport(DLLFile, CallingConvention = CallingConvention.Cdecl)]
        public static extern double Voltage(double I3, double R3);

        [DllImport(DLLFile, CallingConvention = CallingConvention.Cdecl)]
        public static extern double Resistance(double V4, double I4);
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Current Number : ");
            double I = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the Voltage Number : ");
            double V = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the Resistance Number : ");
            double R = Double.Parse(Console.ReadLine());
            

            double P = Power(V, I);
            double C = Current(V, R);
            double RE = Resistance(V, I);
            double VO = Voltage(I, R);

            Console.WriteLine("Power Equal By : {0}.",P);
            Console.WriteLine("Current Equal By : {0}.",C);
            Console.WriteLine("Resistance Equal By : {0}.", RE);
            Console.WriteLine("Voltage Equal By : {0}.",VO);
            Console.ReadKey();
        }
    }
}
