#ifndef test
#define test

#include <iostream>
#include <vector>
#include <string>
#include <fstream>
using namespace std;

class TT {
private:
	string tens, ma, tacgia, theloai;
	int nam = 0, xh = 0;
public:
	void nhap() {
		cout << "Nhap ten sach: ";
		cin.ignore(); getline(cin, tens);
		cout << "Nhap ten tac gia: ";
		getline(cin, tacgia);
		cout << "Nhap ma: ";
		getline(cin, ma);
		cout << "Nhap the loai: ";
		getline(cin, theloai);
		do {
			cout << "Nhap nam xuat ban: "; cin >> nam;
		} while ( nam < 0);
		do {
			cout << "Nhap diem xep hang: "; cin >> xh;
			if (xh < 0 || xh > 5) {
				cout << "Diem danh gia theo thang diem 5" << endl;
			}
		} while (xh < 0 || xh > 5);
	}

	void xuat() {
		cout << "Ten sach: " << tens << endl;
		cout << "Ma: " << ma << endl;
		cout << "The loai: " << theloai << endl;
		cout << "Tac gia: " << tacgia << endl;
		cout << "Nam xuat ban: " << nam << endl;
		cout << "Diem xep hang: " << xh << endl;
	}

	string getS() {
		return tens;
	}

	string getTG() {
		return tacgia;
	}

	string getma() {
		return ma;
	}

	string getTl() {
		return theloai;
	}

	int getnam() {
		return nam;
	}

	int getxh() {
		return xh;
	}

	void SetS(string s) {
		tens = s;
	}

	void SetTG(string s) {
		tacgia = s;
	}

	void SetMa(string s) {
		ma = s;
	}

	void SetTL(string s) {
		theloai = s;
	}

	void SetNam(int s) {
		nam = s;
	}

	void SetXH(int s) {
		xh = s;
	}
};

class File {
private:
	vector<TT> a;
	int sl;
public:
	void SetSl(int s){
		sl = s;
		a.resize(sl);
	}

	void DocFile() {
		fstream f("DocFile.txt", ios::in);
		string t, m, tl, tg;
		int n, xh;
		f.open("DocFile.txt");
		if (f.is_open()) {
			f.ignore();
			for (int i = 0; i < sl; i++) {
				getline(f, t);
				getline(f, m);
				getline(f, tl);
				getline(f, tg);
				f >> n;
				f >> xh;
				
				a[i].SetS(t);
				a[i].SetMa(m);
				a[i].SetTG(tl);
				a[i].SetNam(n);
				a[i].SetXH(xh);
			}

		}
		else cout << "Chua co mo file" << endl;
		f.close();
	}

	void XuatVoFile() {
		ofstream f("LuuFile.txt", ios::out);
		string t, m, tl, tg;
		int n, xh;

		if (f.is_open()) {
			for (int i = 0; i < sl; i++) {
				f << "Ten sach: " << a[i].getS() << endl;
				f << "Ma: " << a[i].getma() << endl;
				f << "The loai: " << a[i].getTl() << endl;
				f << "Tac gia: " << a[i].getTG() << endl;
				f << "Nam xuat ban: " << a[i].getnam() << endl;
				f << "Diem xep hang: " << a[i].getxh() << endl;
			}
		}
		else cout << "Chua mo file" << endl;
		f.close();
	}

	void Nhap() {
		sl = sl + 1;
		a[sl].nhap();
	}
};

#endif