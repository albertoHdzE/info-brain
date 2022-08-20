using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WolframAlgorithm.Utils
{
    class Radix
    {

        private string sourceFile = "";
        private string tarjetFile = "";
        private int noLineas = 0;

        public int NoLineas
        {
            get
            {
                return this.noLineas;
            }
            set
            {
                this.noLineas = value;
            }
        }
        
    
    

        public Radix(string sourceFile, string tarjetFile)
        {
            this.sourceFile = sourceFile;
            this.tarjetFile = tarjetFile;
        }

        public Radix(string file)
        {
            this.sourceFile = file;
            this.tarjetFile = file;
        }

        public Radix()
        {

        }


        public void SortFile()
        {
            string[] full_file = File.ReadAllLines(this.sourceFile);
            List<string> l = new List<string>();
            l.AddRange(full_file);

            List<string> ceros = new List<string>();
            List<string> unos = new List<string>();


            string cadena = l[0];
            bool hasCommas = false;
            int longCadena = cadena.Length;
            int noCadenas = l.Count;
            char bit;

            if (cadena.Contains(','))
            {
                hasCommas = true;
                cadena = cadena.Replace(",", "");
                longCadena = cadena.Length;
            }
            else
            {
                hasCommas = false;
            }


            do
            {
                longCadena = longCadena - 1;
                ceros.Clear();
                unos.Clear();
                for (int i = 0; i <= noCadenas - 1; i++)
                {
                    if (hasCommas)
                    {
                        cadena = l[i].Replace(",", "");
                    }

                    this.noLineas = noLineas + 1;
                    bit = cadena[longCadena];
                    if (bit == '0') ceros.Add(l[i]);
                    if (bit == '1') unos.Add(l[i]);
                }

                l.Clear();
                l.AddRange(ceros);
                l.AddRange(unos);

             } while (longCadena > 0);

            File.WriteAllLines(this.tarjetFile, l.ToArray());        
 
        }


    }
}
