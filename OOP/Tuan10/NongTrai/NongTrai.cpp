#include "NongTrai.h"

NongTrai::NongTrai()
{
	gs = NULL;
}

void NongTrai::NhapSoLuong()
{
	gs = new GiaSuc * [3];
	gs[0] = new Bo;
	gs[1] = new Cuu;
	gs[2] = new De;
	for (int i = 0; i < 3; i++)
	{
		gs[i]->Nhap();
	}
}

void NongTrai::XuatTiengKeu()
{
	for (int i = 0; i < 3; i++)
	{
		if (gs[i]->GetSoLuong() > 0) gs[i]->Keu();
	}
}

void NongTrai::ThongKe()
{
	for (int i = 0; i < 3; i++)
	{
		gs[i]->SinhCon();
	}
	cout << "\n---------------------------------------";
	cout << "\nThong ke gia suc cua nong trai sau khi sinh con:";
	int lsua = gs[0]->LaySua();
	cout << "\nSo luong bo la: " << gs[0]->GetSoLuong() << "\tSo lit sua: " << lsua;
	lsua = gs[1]->LaySua();
	cout << "\nSo luong cuu la: " << gs[1]->GetSoLuong() << "\tSo lit sua: " << lsua;
	lsua = gs[2]->LaySua();
	cout << "\nSo luong de la: " << gs[2]->GetSoLuong() << "\tSo lit sua: " << lsua;
}