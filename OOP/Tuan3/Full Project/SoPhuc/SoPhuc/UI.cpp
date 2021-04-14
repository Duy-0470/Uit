#include <iostream>
#include "Complex.h"
using namespace std;

int main()
{
    int n;
    Complex c1, c2;

    cout << "CHUONG TRINH TINH TOAN 2 SO PHUC" << endl;
    
    do {
        cout << "\nNhap so tuong ung voi yeu cau cua ban:\n";
        cout << "\n1: Nhap so phuc (mac dinh la 0 neu ban chua nhap gi)";
        cout << "\n2: Xuat so phuc";
        cout << "\n3: Cong 2 so phuc";
        cout << "\n4: Tru 2 so phuc";
        cout << "\n5: Nhan 2 so phuc";
        cout << "\n6: Chia 2 so phuc";
        cout << "\n0: Thoat chuong trinh";
        cout << "\nLua chon cua ban: ";
        cin >> n;

        switch (n) {
        case 1:
            cout << "\nNhap so phuc thu nhat:";
            c1.Input();
            cout << "\nNhap so phuc thu hai:";
            c2.Input();
            cout << "\n";
            break;
        case 2:
            cout << "\nSo phuc thu nhat: ";
            c1.Display();
            cout << "\nSo phuc thu hai: ";
            c2.Display();
            cout << "\n";
            break;
        case 3:
            (c1, c2).Add(c1, c2);
            cout << "\n";
            break;
        case 4:
            (c1, c2).Subtract(c1, c2);
            cout << "\n";
            break;
        case 5:
            (c1, c2).Multiply(c1, c2);
            cout << "\n";
            break;
        case 6:
            (c1, c2).Divide(c1, c2);
            cout << "\n";
            break;
        case 0:
            return 0;
        default:
            cout << "\nLua chon khong hop le. Moi ban chon lai.\n";
            break;
        }
    } while (n != 0);

    return 0;
}
