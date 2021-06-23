#pragma once
#include <iostream>
#include <stdlib.h>
using namespace std;

class GiaSuc
{
protected:
	int sl;
public:
	GiaSuc(int = 0);
	int GetSoLuong();
	void SetSoLuong(int);
	virtual void Nhap() = 0;
	virtual void Keu() = 0;
	void SinhCon();
	virtual int LaySua() = 0;
};

