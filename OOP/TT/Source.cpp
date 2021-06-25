#include "Header.h"
#include <vector>

int main() {
	File a;
	int n;
	string s;
	cout << "So luong ma ban can de xuat ra: "; cin >> n;
	a.SetSl(n);
	int select;
	do {
		cout << "-----------------" << endl;
		cout << "1. Nhap tua sach" << endl;
		cout << "2. Xoa tua sach theo ma so" << endl;
		cout << "3. Tim" << endl;
		cout << "4. Luu vo File" << endl;
		cout << "5. Doc File" << endl;
		cout << "Lua chon cua ban la: ";
		cin >> select;
		cout << "-----------------" << endl;
		switch (select) {
		case 1:
			a.Nhap();
			cout << "------------------------------" << endl;
			break;

		case 2:
			a.Xoa();
			break;

		case 3:
			a.Tim();
			break;

		case 4:
			a.XuatVoFile();
			break;

		case 5:
			a.DocFile();
			break;

		}
	} while (select != 0);
	return 0;
}