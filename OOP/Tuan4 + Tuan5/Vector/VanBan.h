#pragma once
#include <vector>
#include <string>
#include <fstream>
using namespace std;

class VanBan
{
private:
	string s;
	vector<vector<string>> tu;
public:
	VanBan(string);
	int DemSoCau();
	vector<int> DemSoTu();
	vector<string> TimTuXuatHienNhieuNhat();
	void Sort();
	vector<vector<string>> Get();
};