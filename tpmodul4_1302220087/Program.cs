// See https://aka.ms/new-console-template for more information
using System.Globalization;

public class KodePos
{

    public string getKodePos(string kelurahan)
    {
        Dictionary<string, string> kodePosDictionary = new Dictionary<string, string>();
        kodePosDictionary.Add("Batununggal", "40266");
        kodePosDictionary.Add("Kujangsaril", "40287");
        kodePosDictionary.Add("Mengger", "40267");
        kodePosDictionary.Add("Wates", "40256");
        kodePosDictionary.Add("Cijaura", "40287");
        kodePosDictionary.Add("Jatisari", "40286");
        kodePosDictionary.Add("Margasari", "40286");
        kodePosDictionary.Add("Sekejati", "40286");
        kodePosDictionary.Add("Kebonwanu", "40272");
        kodePosDictionary.Add("Maiser", "40274");
        kodePosDictionary.Add("Samoja", "40273");

        return kodePosDictionary[kelurahan];
    }

}

