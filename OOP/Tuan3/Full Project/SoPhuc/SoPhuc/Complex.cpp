#include "Complex.h"
#include <iostream>
using namespace std;

Complex::Complex() {
	this->r = this->i = 0;
}

Complex::Complex(double& r, double& i) {
	this->r = r;
	this->i = i;
}
void Complex::Input() {
	cout << "\nPhan thuc: ";
	cin >> this->r;
	cout << "Phan ao: ";
	cin >> this->i;
}

void Complex::Display() {
	if (r == 0 && i == 0) {
		cout << 0;
		return;
	}

	if (r != 0) cout << r << " ";

	if (i == 1) cout << "+ i";
	else if (i == -1) cout << "- i";
	else if (i < 0) cout << "- " << abs(i) << "i";
	else if (i > 0) cout << "+ " << abs(i) << "i";
}

void Complex::Add(Complex c1, Complex c2) {
	double ra = c1.r + c2.r;
	double ia = c1.i + c2.i;
	
	cout << "\nTong 2 so phuc = ";

	Complex c3(ra, ia);
	c3.Display();
}

void Complex::Subtract(Complex c1, Complex c2) {
	double rs = c1.r - c2.r;
	double is = c1.i - c2.i;
	
	cout << "\nHieu 2 so phuc = ";

	Complex c3(rs, is);
	c3.Display();
}


void Complex::Multiply(Complex c1, Complex c2) {
	double rm = c1.r * c2.r - c1.i * c2.i;
	double im = c1.r * c2.i + c2.r * c1.i;
	
	cout << "\nTich 2 so phuc = ";

	Complex c3(rm, im);
	c3.Display();
}

void Complex::Divide(Complex c1, Complex c2) {
	double rd = (c1.r * c2.r + c1.i * c2.i) / (c2.r * c2.r + c2.i * c2.i);
	double id = (c2.r * c1.i - c1.r * c2.i) / (c2.r * c2.r + c2.i * c2.i);

	cout << "\nThuong 2 so phuc = ";

	Complex c3(rd, id);
	c3.Display();
}