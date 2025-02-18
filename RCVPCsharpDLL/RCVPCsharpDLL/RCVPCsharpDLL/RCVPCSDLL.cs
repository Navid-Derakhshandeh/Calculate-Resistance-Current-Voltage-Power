using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCVPCsharpDLL
{
    public class RCVPCSDLL
    {
        
		public static double Power(double V1, double I1)
		{
			return V1 * I1;
		}
		public static double Current(double V2, double R2)
		{
			return V2 / R2;
		}
		public static double Voltage(double I3, double R3)
		{
			return I3 * R3;
		}
		public static double Resistance(double V4, double I4)
		{
			return V4 / I4;
		}
	}
}
