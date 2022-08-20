// *************************************************************
/// WOLFRAM ALGORITHM
/// 1. To have a knowledge base (memory). Binary, ordered. The same input is the same direction un memory
/// 2. To have an input
/// 3. Given an input, compare, and to decide wheter it is or it is not alike enought to some entries in memory
/// 4. To recover all those entries into the memory
/// 5. if there is no results in (3) then add this new entry.





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WolframAlgorithm.Utils;

namespace WolframAlgorithm
{
    class WolframAlgorithmImpl
    {
        private double levenshtein = 0.0;
        private string inputStr = "";
        private List<string> resultados;
        private string dbWolfram = "";
        private double wolframParam = 0.0;
        private TypeConversor tc;
        private FileHandler fh;
        private List<double> distanciasLevenshtein;

        public WolframAlgorithmImpl(string dbFile, bool[] boolInput)
        {
            dbWolfram = "dbWolfram.txt";
            tc = new TypeConversor();
            this.dbWolfram = dbFile;
            fh = new FileHandler(this.dbWolfram);
            this.resultados = new List<string>();
            this.distanciasLevenshtein = new List<double>();

            this.ComparaInputBoolConDB(boolInput);

        }

        public double Levenshtein
        {
            get
            {
                return this.levenshtein;
            }
            set
            {
                this.levenshtein = value;
            }
        }

        public string InputStr
        {
            get
            {
                return this.inputStr;
            }
            set
            {
                this.inputStr = value;
            }
        }

        public List<string> Resultados
        {
            get
            {
                return this.resultados;
            }
            
        }

        public string DbWolfram
        {
            get
            {
                return this.dbWolfram;
            }
            set
            {
                this.dbWolfram = value;
            }
        }

        public double WolframParam
        {
            get
            {
                return this.wolframParam;    
            }
            set
            {
                this.wolframParam = value;
            }
        }

        public int ResultCount
        {
            get
            {
                return this.resultados.Count;
            }
        }

        public string GetResultadoAsCSVByIndex(int index)
        {
            string salida = "";

            salida = (string)this.resultados[index];

            return salida;
        }

        public bool[] GetResultadoAsBoolByIndex(int index)
        {
            return this.tc.StringCommas2Bool(this.resultados[index]);
        }

        
        
        public double GetDistanciaLevenshteinByIndex(int index)
        {
            return this.distanciasLevenshtein[index];
        }






        private List<String> ComparaInputBoolConDB(bool[] input)
        {
            List<string> salida = new List<string>();
            string memLine = "";
            string inputString = tc.Bool2StrNoCommas(input);
            double distance = 0.0;

            int noPatrones = this.fh.GetNumLines(this.dbWolfram);
            for (int i = 1; i <= noPatrones; i++)
            {
                memLine = fh.GetLineByIndex(this.dbWolfram, i);
                memLine = this.tc.CommaStr2NoCommaStr(memLine);
                distance = LevenshteinDistance.Compute(inputString, memLine);
                if (distance <= this.wolframParam)
                {
                    salida.Add(tc.NoCommaStr2CommaStr(memLine));
                    this.distanciasLevenshtein.Add(distance);
                }
            }

            if (salida.Count >= 0)
            {
                salida.Add(tc.NoCommaStr2CommaStr(inputString));
                fh.WriteSetLines("WolframAlgorithmResults.txt", salida);
                MessageBox.Show("Patrones encontrados: ", (salida.Count-1).ToString());
            }

            if (salida.Count == 0) fh.AppendLine(this.dbWolfram, tc.NoCommaStr2CommaStr(memLine));

            this.resultados = salida;
            return salida;

        }
        
        

        






    }
}
