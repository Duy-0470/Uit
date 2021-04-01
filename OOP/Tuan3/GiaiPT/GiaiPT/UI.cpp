#include <iostream>
#include "LinearEquation.h"
#include "QuadraticEquation.h"
using namespace std;

int main()
{
	LinearEquation x;
	x.SetAB();

	cout << "Chuong trinh giai phuong trinh bac 1: ax + b = 0" << endl;
	x.Get();
	x.Display();
	x.Compute1();

	return 0;
}