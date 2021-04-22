#pragma once
#include <iostream> 

using namespace std;

class CVector {
public:
	double *vt;
	int dimension;
	CVector();
	CVector(int n);
	~CVector();
	CVector operator+ (const CVector &v);
	CVector operator- (const CVector &v);
	CVector operator* (const CVector& v);
	CVector operator* (const int n); //Lười quá chưa xây được :)))))))
	friend ostream& operator<< (ostream& os, const CVector v);
	friend istream& operator>> (istream& os, CVector& v);

};