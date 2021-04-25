#define _CRT_SECURE_NO_WARNINGS
#include"StringModify.h"
//Constructor
String::String(char *b)
{
	size = strlen(b);
	a = new char[size +1];
	strcpy(a, b);
}
//Copy Constructor
String::String(const String& obj)
{
	size = obj.size;
	a = new char[size +1];
	strcpy(a, obj.a);
}

void String::InputString()
{
	a = new char[256] ;
	int i = 0;
	{
		cout << "Hay nhap chuoi cua ban: " << endl;
		cin.getline(a,99);
	}
	while (strlen(a) > 22)
	{
		cout << "Ban da nhap so luong ky tu ma chuong trinh co the xu ly (22 ky tu), moi ban nhap lai:" << endl;
		cin.getline(a, 99);
	}
	
}
void String::OutputString()
{
	
	cout << "Chuoi cua ban la: " << endl;
	for (int i = 0; i<strlen(a); i++)
		cout << a[i];
	cout << endl;
}
void String::LengthOfString()
{
	cout << "Chuoi so co do dai la: "<<strlen(a)<<endl;
}
void String::ReverseString()
{
	cout << "Chuoi cua ban sau khi duoc dao la: " << _strrev(a)<<endl;
}

void String::ConcatenateStrings(String s)
{
	cout << "Hai chuoi sau khi duoc noi la: " << endl;
	cout << strcat(a, s.a);
}

String::~String()
{
	
	delete[] a;
	a = NULL;
	size = 0;
}
