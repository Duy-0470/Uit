#include "LinearEquation.h"
#include <math.h>
#include <iostream>
using namespace std;

void LinearEquation::Set() {
	this->a = this->b = 0;
}

void LinearEquation::SetB() {
	this->a = 0;
	this->b = b;
}

void LinearEquation::SetAB() {
	this->a = a;
	this->b = b;
}

void LinearEquation::Get() {
	cout << "Nhap a: ";
	cin >> this->a;
	cout << "Nhap b: ";
	cin >> this->b;
}

void LinearEquation::Display() {
	cout << "Phuong trinh bac 1: ";
	cout << a << "x" << (b > 0 ? " - " : " + ") << abs(b) << " = 0";
}

void LinearEquation::Compute1() {
	cout << "\n=> ";

	if (a == 0 && b != 0) {
		cout << "Phuong trinh vo nghiem.\n";
		return;
	}
	if (a == 0 && b == 0) {
		cout << "Phuong trinh co vo so nghiem.\n";
		return;
	}
	if (a != 0 && b == 0) {
		cout << "x = 0" << endl;
		return;
	}
	cout << "x = " << -b / a << endl;
}