using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WolframAlgorithm.Utils;

namespace WolframAlgorithm.Test
{
    class RadixTest
    {

        private string fileName = "";
        private FileHandler fh;
        private int noLines;
        private int longStrs;
        

        public RadixTest(string fileName, int noLines, int longStrs)
        {
            this.fileName = fileName;
            this.fh = new FileHandler(fileName, fileName);
            this.noLines = noLines;
            this.longStrs = longStrs;
            this.CreateTextFile(fileName, this.BuildRandomBinaryLines(noLines, longStrs));
            Radix rad = new Radix(fileName, "dos.txt");
            rad.SortFile();
        }


        private List<string> BuildRandomBinaryLines(int noCadenas, int longCadenas)
        {
            List<string> set = new List<string>();

            for(int i=1; i<= noCadenas; i++)
            {
                Pattern pat = new Pattern(longCadenas);
                pat.FillRandomly();
                set.Add(pat.ToNoComasLine());
            }

            return set;
        }

        private void CreateTextFile(string fileName, List<string> set)
        {
            this.fh.WriteSetLines(fileName, set);
        }




        

    }
}
