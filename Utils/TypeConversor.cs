using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encog.MathUtil;
using Encog.MathUtil.Matrices;
using Encog.ML.Data.Specific;
using Encog.ML.Data.Basic;
using Encog.ML.Data;
using Encog.ML;

using WolframAlgorithm.Utils;

namespace WolframAlgorithm.Utils
{
    class TypeConversor
    {
        public TypeConversor()
        {

        }

        public bool[] IML2Boolean(IMLData b)
        {
            bool[] result = new bool[b.Count];

            for (int i = 0; i < b.Count; i++)
            {
                if (b[i] > 0)
                {
                    result[i] = true;
                }
                else
                {
                    result[i] = false;
                }

            }

            return result;
        }



        public BiPolarMLData Bool2IML(bool[] b)
        {
            BiPolarMLData salida = new BiPolarMLData(b.Length);

            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == false)
                {
                    salida[i] = 0;
                }
                else
                {
                    salida[i] = 1;
                }

            }

            return salida;
        }


        public Pattern IML2Pattern(BiPolarMLData b)
        {
            Pattern salida = new Pattern();

            int cuantos = b.Count;

            for (int i = 0; i < cuantos; i++)
            {
                if (b[i] > 0)
                {
                    salida.AddElement(0);
                }
                else
                {
                    salida.AddElement(1);
                }
            }

            return salida;
        }


        public IMLData Pattern2IMLData(Pattern p)
        {
            BiPolarMLData salida = new BiPolarMLData(p.Longitud);

            for (int i = 0; i < p.Longitud; i++)
            {
                if (p.GetElement(i) == 0)
                {
                    salida[i] = 0;
                }
                else
                {
                    salida[i] = 1;
                }

            }

            return salida;
        }

        public bool[] Pattern2Bool(Pattern p)
        {
            bool[] salida = new bool[p.Longitud];

            for (int i = 0; i < p.Longitud; i++)
            {
                if (p.GetElement(i) == 1)
                {
                    salida[i] = true;
                }
                else
                {
                    salida[i] = false;
                }

            }

            return salida;
        }


        public bool[] StringCommas2Bool(string linea)
        {
            string[] cars = linea.Split(',');
            int cuantos = cars.Length;
            bool[] salida = new bool[cuantos];

            for (int i = 0; i < cuantos; i++)
            {
                if (cars[i] == "0")
                {
                    salida[i] = false;
                }
                else
                {
                    salida[i] = true;
                }
            }

            return salida;
        }


        public string Bool2StrNoCommas(bool[] b)
        {
            string salida = "";

            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == false)
                {
                    salida = salida + 0;
                }
                else
                {
                    salida = salida + 1;
                }
            }

            return salida;
        }



        public string Bool2StrWithCommas(bool[] b)
        {
            string salida = "";
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == false)
                {
                    salida = salida + "0" + ",";
                }
                else
                {
                    salida = salida + "1" + ",";
                }
            }

            salida.Remove(salida.Length-1, 1);
            return salida;

        }

        public string CommaStr2NoCommaStr(string commaStr)
        {
            string salida = "";

            string[] aux= commaStr.Split(',');
            for (int i = 0; i < aux.Length; i++)
            {
                salida = salida = aux[i];
            }

                return salida;
            
        }


        public string NoCommaStr2CommaStr(string noCommaStr)
        {
            string salida = "";

            int longi = noCommaStr.Length;
            for (int i = 0; i < longi; i++)
            {
                salida = salida + noCommaStr[i] + ",";
            }

            salida = salida.Remove(salida.Length - 1, 1);
            return salida;
        }



    }
}
