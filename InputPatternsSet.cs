using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;


namespace WolframAlgorithm
{
    class InputPatternsSet
    {
        private int count;
        private ArrayList patterns;
        private int lengthPattern;


        public InputPatternsSet(int count, int lengthPattern)
        {
            this.count = count;
            this.patterns.Capacity = count;
            this.patterns = new ArrayList(count);
            this.lengthPattern = lengthPattern;
        }

        /// <summary>
        /// Llena aleatoriamente los patrones de entrada
        /// </summary>
        public void RandomFill()
        {
            for (int i = 0; i < this.count; i++)
            {
                Pattern patron = new Pattern(this.lengthPattern);
                patron.FillRandomly();
                this.patterns.Add(patron);
            }
        }


        /// <summary>
        /// Agrega por índice un patron al arreglo de pattrones
        /// </summary>
        /// <param name="index">indice donde se agregará</param>
        /// <param name="pattern">patrón a agregar</param>
        public void SetPattern(int index, Pattern pattern)
        {
            this.patterns.Insert(index, pattern);
        }


        /// <summary>
        /// Regresa un patrón por índice
        /// </summary>
        /// <param name="index">indice buscado</param>
        /// <returns>Patrón correspondiente</returns>
        public Pattern GetPattern(int index)
        {
            return (Pattern)this.patterns[index];
        }


        /// <summary>
        /// Regresa todos los patrones de entrada
        /// </summary>
        /// <returns>Regresa el arreglo de patrones de entrada</returns>
        public ArrayList GetPatterns()
        {
            return this.patterns;
        }

        public void SetPatterns(ArrayList patterns)
        {
            this.patterns = patterns;
            this.count = patterns.Count;
            this.patterns.Capacity = this.count;
            Pattern patron = (Pattern)patterns[0];
            this.lengthPattern = patron.Longitud;
        }


        /// <summary>
        /// Guarda todos los patrones de entrada en un archivo de texto
        /// </summary>
        /// <param name="fileName">Nombre del archivo donde se guardarán los patrones</param>
        public void SavePatternsToFile(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            string linea = "";

            for (int i = 0; i < this.count; i++)
            {
                Pattern patt = new Pattern();
                patt = (Pattern)this.patterns[i];
                linea = patt.ToString();
                sw.WriteLine(linea);
            }

            sw.Close();
         }


        /// <summary>
        /// Carga todos los patrones desde un archivo de texto
        /// </summary>
        /// <param name="fileName">Archivo de texto que contiene los patrones</param>
        public void LoadPatternsFromFile(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string linea = "";
            this.patterns = new ArrayList();
            int id = 0;

            while ((linea = sr.ReadLine()) != null)
            {
                id = id + 1;
                this.count = id;
                Pattern patt = new Pattern(linea);
                this.patterns.Add(patt);
            }

            this.patterns.Capacity = this.count;
        }


        /// <summary>
        /// Guarda por ínidice un patron en un archivo de texto
        /// </summary>
        /// <param name="index">ínidice del patron a guardar</param>
        /// <param name="fileName">archivo de texto </param>
        public void SaveOnePatternToFile(int index, string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            string linea = "";

            Pattern patt = new Pattern();
            patt = (Pattern)this.patterns[index];
            linea = patt.ToString();
            sw.WriteLine(linea);
            
            sw.Close();
        }


        /// <summary>
        /// Carga un patron por índice desde un archivo de texto
        /// </summary>
        /// <param name="index">Indice del patron</param>
        /// <param name="fileName">Archivo que contiene los patrones</param>
        public void LoadOnePatternFromFile(int index, string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string linea = "";
            int id = 0;

            if (this.patterns.Capacity > index)
            {
                while (((linea = sr.ReadLine()) != null) && (id < index))
                {
                    id = id + 1;

                    if (id == index)
                    {
                        break;
                    }

                }

                Pattern patt = new Pattern(linea);
                this.patterns.Insert(id, patt);
            }
        }


        /// <summary>
        /// Guarda Rango de patrones en un archivo de texto
        /// </summary>
        /// <param name="index1">índice inicial</param>
        /// <param name="index2">índice final</param>
        /// <param name="fileName">archivo de texto</param>
        public void SaveRangeOfPatternsToFile(int index1, int index2, string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            string linea = "";
            
            if(index1 < index2 && index2 < this.patterns.Capacity)
            {
                for (int i = index1; i <= index2; i++)
                {
                    Pattern patt = new Pattern();
                    patt = (Pattern)this.patterns[i];
                    linea = patt.ToString();
                    sw.WriteLine(linea);
                }
            }

            sw.Close();
        }


        /// <summary>
        /// Carga patrones de entrada desde un archivo de texto
        /// </summary>
        /// <param name="index1">indice de inicio</param>
        /// <param name="index2">indice final de rango</param>
        /// <param name="fileName">archivo de texto que contiene los patrones</param>
        public void LoadRangeOfPatternFromFile(int index1, int index2, string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string linea = "";
            int id = 0;

            if (this.patterns.Capacity > index1)
            {
                while (((linea = sr.ReadLine()) != null) && (id < index1))
                {
                    id = id + 1;

                    if (id == index1)
                    {
                        break;
                    }

                }

                for (int i = index1; i <= index2; i++)
                {
                    id = i;
                    Pattern patt = new Pattern(linea);
                    this.patterns.Insert(id, patt);
                }
            }
        }



        /// <summary>
        /// Ordena aleatoriamente los patrones contenidos en input patterns
        /// </summary>
        public void RandomSortOfAllPatterns()
        {
            ArrayList copiaPatterns = this.patterns;
            int[] ordenPatt = new int[this.patterns.Capacity];
            int numero = 0;

            Random rn = new Random();

            for (int i = 0; i < this.patterns.Capacity; i++)
            {
                while (ordenPatt.Contains(numero = rn.Next(0, this.patterns.Capacity)))
                {
                }
                
                ordenPatt[i] = numero;
                
            }

            for (int j = 0; j < this.patterns.Capacity; j++)
            {
                copiaPatterns[j] = (Pattern)this.patterns[ordenPatt[j]];
            }

            this.patterns = copiaPatterns;
          
        }



        /// <summary>
        /// Ordena de menor a menor todos los patrones contenidos
        /// </summary>
        public void UpDownSortAllPatterns()
        {
            this.patterns.Sort();
        }


        /// <summary>
        /// Ordena aleatoriamente un rango de patrones contenidos
        /// </summary>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        public void RandomSortRangePatterns(int index1, int index2)
        {
            ArrayList copiaRango = this.patterns.GetRange(index1, index2);
        }


        /// <summary>
        /// Ordena de menor a mayor un rango de patrones contenidos
        /// </summary>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        public void UpDownSortRangePatterns(int index1, int index2)
        {
            ArrayList copiaRango = this.patterns.GetRange(index1, index2 - index1);
            copiaRango.Sort();
            this.patterns.SetRange(index1, copiaRango);
        }

        



    }
}
