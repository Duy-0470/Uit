#include "Cuu.h"

Cuu::Cuu(int sl) : GiaSuc(sl) {}

void Cuu::Keu()
{
	cout << "baa baaaa baaa ..." << endl;
}

void Cuu::Nhap()
{
	do
	{
		cout << "Nhap so luong de: ";
		cin >> sl;
	} while (sl < 0);
}

int Cuu::LaySua()
{
	int sua = 0;
	for (int i = 0; i < sl; i++)
	{
		sua += rand() % 6;
	}
	return sua;
}