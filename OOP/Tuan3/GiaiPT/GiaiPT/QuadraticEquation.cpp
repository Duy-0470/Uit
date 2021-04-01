#include "QuadraticEquation.h"
#include <math.h>
#include <iostream>
using namespace std;

QuadraticEquation::QuadraticEquation() {
	this->a = this->b = this->c = 0;
}

QuadraticEquation::QuadraticEquation(double a) {
	this->a = a;
	this->b = this->c = 0;
}

QuadraticEquation::QuadraticEquation(double a, double b) {
	this->a = a;
	this->b = b;
	this->c = 0;
}

QuadraticEquation::QuadraticEquation(double a, double b, double c) {
	this->a = a;
	this->b = b;
	this->c = c;
}

void QuadraticEquation::Input() {
	cout << "\nNhap a: ";
	cin >> this->a;
	cout << "Nhap b: ";
	cin >> this->b;
	cout << "Nhap c: ";
	cin >> this->c;
}

void QuadraticEquation::Display() {
	cout << "Phuong trinh bac 2: ";
	cout << a << "x" << (b > 0 ? " - " : " + ") << abs(b) << (c > 0 ? " - " : " + ") << abs(c) << " = 0";
}

void QuadraticEquation::Computing2() {
	double delta = b * b - 4 * a * c;

	cout << "\n=> ";

	if (delta < 0) {
		cout << "Phuong trinh vo nghiem";
	}
	else if (delta == 0) {
		cout << "Phuong trinh co nghiem kep: x = " << -b / (2 * a);
	}
	else if (delta > 0) {
		cout << "Phuong trinh co 2 nghiem phan biet:\n";
		cout << "\tx1 = " << (-b - sqrt(delta)) / 2 * a << endl;
		cout << "\tx2 = " << (-b + sqrt(delta)) / 2 * a << endl;
	}
}