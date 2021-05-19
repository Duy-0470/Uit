#include"StringModify.h"
int main()
{
	char a[256] = ("Hello World");
	String s1(a);
	String s2(a);
	cout << "Chuoi thu nhat: " << endl;
	s1.InputString();
	s1.OutputString();
	s1.LengthOfString();
	s1.ReverseString();
	cout << "Chuoi thu hai: " << endl;
	s2.InputString();
	s1.ConcatenateStrings(s2);
	return 0;
}