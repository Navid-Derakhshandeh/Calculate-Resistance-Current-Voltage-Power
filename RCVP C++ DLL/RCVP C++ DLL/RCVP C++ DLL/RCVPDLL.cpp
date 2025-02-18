#define RCVPDLL _declspec(dllexport)

extern "C" {
	RCVPDLL double Power(double V1, double I1)
	{
		return V1* I1;
	}
	RCVPDLL double Current(double V2, double R2)
	{
		return V2 / R2;
	}
	RCVPDLL double Voltage(double I3, double R3)
	{
		return I3 *  R3;
	}
	RCVPDLL double Resistance(double V4, double I4)
	{
		return V4 / I4;
	}
}