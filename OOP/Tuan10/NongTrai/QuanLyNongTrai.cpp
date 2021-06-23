#include "NongTrai.h"

int main()
{
	NongTrai a;
	int select = 1;
	while (select != 0)
	{
		cout << "\n---------------------------------------------------------------------------------";
		cout << "\n1.  Nhap so luong gia suc.";
		cout << "\n2.  Xuat tieng keu.";
		cout << "\n3. Thong ke so luong gia suc sau khi sinh.";
		cout << "\n0. Thoat chuong trinh.";
		cout << "\n---------------------------------------------------------------------------------";
		cout << "\nNhap lua chon: ";
		cin >> select;
		switch (select)
		{
		case 1:
			a.NhapSoLuong();
			break;
		case 2:
			a.XuatTiengKeu();
			break;
		case 3:
			a.ThongKe();
			break;
		case 0:
			break;
		}
	}
	return 0;
}