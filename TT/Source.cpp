#include "Header.h"
#include <vector>

int main() {
	File a;
	int n;
	cout << "So luong: "; cin >> n;
	a.SetSl(n);
	int select;
	do {
		cout << "1. Nhap tua sach" << endl;
		cout << "2. Xoa tua sach theo ma so" << endl;
		cout << "3. Tim" << endl;
		cout << "4. Luu vo File" << endl;
		cout << "5. Doc File" << endl;
		cin >> select;
		switch (select) {
		case 1:
			a.Nhap();
			cout << "------------------------------" << endl;

		case 2:
		
		case 3:

		case 4:
			a.XuatVoFile();

		case 5:
			a.DocFile();

		}
	} while (select != 0);
	return 0;
}

