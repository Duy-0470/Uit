#include <iostream>
#include "COMPLEX.h"

using namespace std;

int main()
{
    COMPLEX s1, s2;
    cout << "Nhap 2 so phuc s1, s2.\n";
    cin >> s1 >> s2;
    cout << s1 + s2;
    cout << s1 - s2;
    cout << s1 * s2;
    if (!s2.check())
    {
        cout << "Khong the thuc hien phep chia nay.\n";
    }
    else
    {
        cout << s1 / s2;
    }
    return 0;
}
