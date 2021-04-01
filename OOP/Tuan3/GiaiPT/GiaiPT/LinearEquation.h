#pragma once
#ifndef LEQ
#define LEQ

class LinearEquation
{
private:
	double a, b;

public:
	void Set();
	void SetB();
	void SetAB();
	void Get();
	void Display();
	void Compute1();
};

#endif