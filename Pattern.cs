using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using Encog.ML.Data.Specific;
using Encog.ML.Data.Basic;
using Encog.ML.Data;
using Encog.ML;

namespace WolframAlgorithm
{
    public class Pattern
    {

        private ArrayList lista;
        private int longitud;
        private int id;
        static private Random r = new Random();


        /// <summary>
        /// Constructor sin dimensiones
        /// </summary>
        public Pattern()
        {
            lista = new ArrayList();
        }

        public Pattern(int size)
        {
            this.lista = new ArrayList(size);
            this.longitud = size;
        }

        
        /// <summary>
        /// Construye un pattern a partir de una linea separada por comas (css)
        /// </summary>
        /// <param name="css">Linea separada por comas</param>
        public Pattern(string css)
        {
            string[] cadena = css.Split();
            int longi = cadena.Length;
            this.lista = new ArrayList(longi);

            for (int i = 0; i < longi; i++)
            {
                this.lista.Add(cadena[i]);
            }

            this.longitud = longi;
           
        }

        public int Longitud
        {
            get
            {
                this.longitud = this.lista.Count;
                return this.lista.Count;
            }
            set
            {
                this.longitud = value;
            }

        }



        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        
        /// <summary>
        /// Establece el valor de un elemento
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void SetElement(int index, int value)
        {
            this.lista.Insert(index, value);
            this.longitud = this.lista.Count;
        }


        public void AddElement(int value)
        {
            this.lista.Add(value);
            this.longitud = this.lista.Count;
        }


        /// <summary>
        /// Regresa el valor de un elemento por índice
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetElement(int index)
        {
            return (int)this.lista[index];
        }


        /// <summary>
        /// Llena un patron aleatoriamente
        /// </summary>
        public void FillRandomly()
        {
            
            this.lista = new ArrayList();
            //if (this.lista.Capacity == 0) MessageBox.Show("The size has not been set");
            //else
            //{
                for (int i = 0; i < this.longitud; i++)
                {
                    this.lista.Add(r.Next() % 2 == 0 ? 0 : 1);
                }
            //}
        }

        public void Clear()
        {
            this.lista.Clear();
        }


        public string ToComaSeparatedLine()
        {
            var result = new StringBuilder();

            for (int i = 0; i < this.lista.Count; i++)
            {
                if (i > 0)
                    result.Append(',');
                result.Append(this.lista[i].ToString());
            }

            return result.ToString();
        }


        public string ToNoComasLine()
        {
            var result = new StringBuilder();

            for (int i = 0; i < this.lista.Count; i++)
            {
                result.Append(this.lista[i].ToString());
            }

            return result.ToString();
        }

        public char[] ToCharArray()
        {
            string  aux = "";
            char[] salida = new char[this.lista.Count];

            for (int i = 0; i < this.lista.Count; i++)
            {
                aux = this.lista[i].ToString();
                salida[i] = aux[0];
            }

            return salida;
        }

        




    }
}
