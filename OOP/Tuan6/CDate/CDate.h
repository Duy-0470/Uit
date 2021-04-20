#ifndef CDT
#define CDT
#include <iostream>
using namespace std;

class CDate
{
private:
	int day, month, year;

public:
	CDate();
	CDate(int, int, int);
	int Position();
	void Locator(CDate&, int);
	bool isDate();
	friend CDate operator+(CDate&, int);
	friend CDate operator-(CDate&, int);
	friend int operator-(CDate, CDate);
	friend CDate operator++(CDate&);
	friend CDate operator--(CDate&);
	friend istream& operator>>(istream&, CDate&);
	friend ostream& operator<<(ostream&, CDate);
};

#endif