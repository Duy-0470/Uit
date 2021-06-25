#ifndef test
#define test

#include <iostream>
#include <vector>
#include <string>
#include <fstream>
#include <algorithm>
using namespace std;

class TT {
private:
	string tens, ma, tacgia, theloai; 
	int nam = 0, xh = 0;
public:
	void nhap() {
		cout << "Nhap ten sach: ";
		cin.ignore(); getline(cin, tens);
		cout << "Nhap ma: ";
		getline(cin, ma);
		cout << "Nhap the loai: ";
		getline(cin, theloai);
		cout << "Nhap ten tac gia: ";
		getline(cin, tacgia);
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
	int sl, count = 0;
public:
	void SetSl(int s){
		sl = s;
		a.resize(sl);
	}

	int GetSl() {
		return sl;
	}

	void DocFile() {
		ifstream f("DocFile.txt", ios::in);
		string t, m, tl, tg, space;
		int n, xh;
		if (f.is_open()) {
			for (int i = 0; i < sl; i++) {
				getline(f, t);
				getline(f, m);
				getline(f, tl);
				getline(f, tg);
				f >> n;
				f >> xh;
				if (i != sl -1){
					getline(f, space);
				}
				f.ignore();
				a[i].SetS(t);
				a[i].SetMa(m);
				a[i].SetTL(tl);
				a[i].SetTG(tg);
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
			if (count != 0) {
				ofstream ff("DocFile.txt", ios::out); 
				for (int i = 0; i < sl; i++) { // getS, getTG, getTl, getnam, getxh, get 
					ff << a[i].getS() << endl;
					ff << a[i].getma() << endl;
					ff << a[i].getTl() << endl;
					ff << a[i].getTG() << endl;
					ff << a[i].getnam() << endl;
					ff << a[i].getxh() << endl;
					if (i != sl - 1) {
						ff << endl;
						}
				}
				DocFile();
			}
			if (f.is_open()) {
				for (int i = 0; i < sl; i++) {
					f << "Ten sach: " << a[i].getS() << endl;
					f << "Ma: " << a[i].getma() << endl;
					f << "The loai: " << a[i].getTl() << endl;
					f << "Tac gia: " << a[i].getTG() << endl;
					f << "Nam xuat ban: " << a[i].getnam() << endl;
					f << "Diem xep hang: " << a[i].getxh() << endl;
					if (i != sl - 1) {
						f << endl;
					}
				}
			}
			else cout << "Chua mo file" << endl;
			f.close();
	}
	

	void Nhap() {
		SetSl(sl + 1);
		a[sl-1].nhap();
		count++;
	}

	string Thuong(string s)
	{
		for (int i = 0; i < s.length(); i++)
		{
			s[i] = tolower(s[i]);
		}
		return s;
	}

	void Tim() {
		int dem = 0, aa;
		string k;
		cout << "1. Tim theo ten sach" << endl;
		cout << "2. Tim theo ten tac gia" << endl;
		cout << "3. Tim theo ma so" << endl;
		cout << "Lua chon cua ban la: ";
		cin >> aa;
		cout << "-----------------" << endl;
		switch (aa) {
		case 1:
			cout << "Nhap ten sach ban can tim: ";
			cin.ignore();
			getline(cin, k);
			cout << "-----------------" << endl;
			for (int i = 0; i < sl; i++) {
				if (Thuong(a[i].getS()) == Thuong(k)) {
					a[i].xuat();
					dem++;
				}

			}
			if (dem == 0) {
				cout << "Khong co ten sach ma ban can tim " << endl;
			}
			return;
		case 2:
			cout << "Nhap ten tac gia ban can tim: ";
			cin.ignore();
			getline(cin, k);
			cout << "-----------------" << endl;
			for (int i = 0; i < sl; i++) {
				if (Thuong(a[i].getTG()) == Thuong(k)) {
					a[i].xuat();
					dem++;
				}

			}
			if (dem == 0) {
				cout << "Khong co tac gia ma ban can tim " << endl;
			}
			return;
		case 3:
			cout << "Nhap ma so ban can tim: ";
			cin.ignore();
			getline(cin, k);
			cout << "-----------------" << endl;
			for (int i = 0; i < sl; i++) {
				if (Thuong(a[i].getma()) == Thuong(k)) {
					a[i].xuat();
					dem++;
				}

			}
			if (dem == 0) {
				cout << "Khong co ma so ma ban can tim " << endl;
			}
			return;
		}

	}

	void Xoa() {
		string ms;
		int sll = GetSl() -1;
		int demm = 0;
		cout << "Nhap ma so muon xoa: ";
		cin.ignore();
		getline(cin, ms);
		for (int i = 0; i <= sll; i++) {
			if (Thuong(a[i].getma()) == Thuong(ms))
			{
				a.erase(a.begin() + i);
				demm++;
				SetSl(sl - 1);
				break;
			}
		}
		if (demm == 0) cout << "Khong co ma so ma ban muon xoa" << endl;
		
	}
	
};

#endif