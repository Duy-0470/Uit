#include "VanBan.h"

int main()
{
    ifstream inp("input.txt");
    string s;
    while (!inp.eof())
    {
        string t;
        getline(inp, t);
        s += t;
    }
    VanBan vb(s);
    ofstream out("output.txt");
    out << vb.DemSoCau() << endl;
    for (int i = 0; i < vb.DemSoCau(); i++)
    {
        out << vb.DemSoTu()[i] << endl;
    }
    for (int i = 0; i < vb.TimTuXuatHienNhieuNhat().size(); i++)
    {
        out << vb.TimTuXuatHienNhieuNhat()[i] << " ";
    }
    vb.Sort();
    for (int i = 0; i < vb.Get().size(); i++)
    {
        for (int j = 0; j < vb.Get()[i].size(); j++)
        {
            out << vb.Get()[i][j] << " ";
        }
        out << endl;
    }
    out.close();
    inp.close();
    return 0;
}