#include "De.h"

De::De(int sl) : GiaSuc(sl) {}

void De::Keu()
{
	cout << "Meh-eh-eh ..." << endl;
}

void De::Nhap()
{
	do
	{
		cout << "Nhap so luong de: ";
		cin >> sl;
	} while (sl < 0);
}

int De::LaySua()
{
	int sua = 0;
	for (int i = 0; i < sl; i++)
	{
		sua += rand() % 11;
	}
	return sua;
}