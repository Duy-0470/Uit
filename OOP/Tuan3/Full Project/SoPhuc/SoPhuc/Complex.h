#ifndef CPX
#define CPX

class Complex
{
private:
	double r, i;

public:
	Complex();
	Complex(double&, double&);
	void Input();
	void Display();
	void Add(Complex, Complex);
	void Subtract(Complex, Complex);
	void Multiply(Complex, Complex);
	void Divide(Complex, Complex);
};

#endif