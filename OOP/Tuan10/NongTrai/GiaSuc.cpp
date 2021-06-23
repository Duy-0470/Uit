#include "GiaSuc.h"

GiaSuc::GiaSuc(int sl) : sl(sl) {}

void GiaSuc::SetSoLuong(int sl)
{
	this->sl = sl;
}

void GiaSuc::SinhCon()
{
	srand(time(NULL));
	sl += rand() % sl;
}

int GiaSuc::GetSoLuong()
{
	return sl;
}