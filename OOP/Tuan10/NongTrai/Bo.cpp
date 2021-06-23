#include "Bo.h"

Bo::Bo(int sl) : GiaSuc(sl) {}

void Bo::Keu()
{
	cout << "moo mooo moo..." << endl;
}

void Bo::Nhap()
{
	do
	{
		cout << "Nhap so luong bo: ";
		cin >> sl;
	} while (sl < 0);
}

int Bo::LaySua()
{
	int sua = 0;
	for (int i = 0; i < sl; i++)
	{
		sua += rand() % 21;
	}
	return sua;
}