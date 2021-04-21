#ifndef COMPLEX_H_INCLUDED
#define COMPLEX_H_INCLUDED

#include <iostream>

using namespace std;

class COMPLEX
{
    private:
        double real, img;
    public:
        COMPLEX(double REAL = 0, double IMG = 0)
        {
            real = REAL;
            img = IMG;
        }

        friend ostream & operator << (ostream &out, const COMPLEX &s)
        {
            out << "Ket qua: ";
            if (s.img < 0)
            {
                out << s.real << " - " << s.img*-1 << "i.\n";
            }
            else
            {
                out << s.real << " + " << s.img << "i.\n";
            }
            return out;
        }

        friend istream & operator >> (istream &in, COMPLEX &s)
        {
            cout << "Phan thuc: ";
            in >> s.real;
            cout << "Phan ao: ";
            in >> s.img;
            return in;
        }

        bool check()
        {
            if (real == 0 && img == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        COMPLEX operator + (COMPLEX &tmp)
        {
            COMPLEX tong(this->real + tmp.real, this->img + tmp.img);
            return tong;
        }
        COMPLEX operator - (COMPLEX &tmp)
        {
            COMPLEX hieu(this->real - tmp.real, this->img - tmp.img);
            return hieu;
        }
        COMPLEX operator * (COMPLEX &tmp)
        {
            COMPLEX tich(this->real * tmp.real - this->img * tmp.img, this->real * tmp.real + this->img * tmp.img);
            return tich;
        }
        COMPLEX operator / (COMPLEX &tmp)
        {
            COMPLEX thuong;
            thuong.real = (this->real * tmp.real + this->img * tmp.img) / (tmp.real*tmp.real + tmp.img*tmp.img);
            thuong.img = (tmp.real * this->img - this->real * tmp.img) / (tmp.real*tmp.real + tmp.img*tmp.img);
            return thuong;
        }
};

#endif // COMPLEX_H_INCLUDED
