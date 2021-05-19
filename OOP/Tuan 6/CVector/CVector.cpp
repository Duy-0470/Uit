#include <iostream> 
#include "Header.h"

using namespace std;

CVector::CVector() {
	this->vt = NULL;
	this->dimension = 0;
}

CVector::CVector(int n) {
	this->vt = new double[n];
	dimension = n;
	for (int i = 0; i < n; i++) {
		vt[i] = 0;
	}
}

CVector::~CVector() {
}

CVector CVector::operator+ (const CVector& v) {

	CVector temp;
	if (this->dimension != v.dimension) {
		return temp;
	}
	temp = *this;
	for (int i = 0; i < this->dimension; i++) {
		temp.vt[i] += v.vt[i];
	}
	return temp;
}

CVector CVector::operator- (const CVector& v) {
	CVector temp;
	if (this->dimension != v.dimension) {
		return temp;
	}
	temp = *this;
	for (int i = 0; i < this->dimension; i++) {
		temp.vt[i] -= v.vt[i];
	}
	return temp;
}


CVector CVector::operator* (const CVector& v) {
	CVector temp;
	if (this->dimension != v.dimension) {
		return temp;
	}
	temp = *this;
	for (int i = 0; i < this->dimension; i++) {
		this->vt[i] *= v.vt[i];
	}
	return temp;
}

ostream& operator<< (ostream& os, const CVector vt) {
	if (vt.vt == NULL) return os << "ERROR 404";
	os << "(";
	for (int i = 0; i < vt.dimension; i++) {
		if (i != vt.dimension - 1)
			cout << vt.vt[i] << ",";
		else
			cout << vt.vt[i];
	}
	os << ")";
	return os;
}

istream& operator>> (istream& is, CVector& VT) {
	cout << "Nhap so chieu cua vector: ";
	is >> VT.dimension;
	VT.vt = new double[VT.dimension];
	cout << "Nhap thanh phan: " << endl;
	for (int i = 0; i < VT.dimension; i++) {
		is >> VT.vt[i];
	}
	return is;
}
