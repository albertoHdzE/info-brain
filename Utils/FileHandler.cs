using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;



namespace WolframAlgorithm.Utils
{
    public class FileHandler
    {
        string fileSource = "";
        string fileTarjet = "";

        public FileHandler(string fileSource, string fileTarjet)
        {
            this.fileSource = fileSource;
            this.fileTarjet = fileTarjet;
        }

        public FileHandler(string fileTarjet)
        {
            this.fileTarjet = fileTarjet;
        }


        public int GetNumLines(string file)
        {
            int nuLines = 0;

            if(File.Exists(file))
            {
                StreamReader sr = new StreamReader(file);
                
                while(sr.ReadLine() != null)
                {
                    nuLines = nuLines + 1;
                }
            }

            return nuLines;
        }


        public void AppendLine(string file, string line)
        {
            if (File.Exists(file))
            {
                using (StreamWriter sw = File.AppendText(file))
                {
                    sw.WriteLine(line);
                }
            }
        }


        public void InsertLineByIndex(string file, string line, int index)
        {
            string[] full_file = File.ReadAllLines(file);
            List<string> l = new List<string>();
            l.AddRange(full_file);
            l.Insert(index, line);
            File.WriteAllLines(file, l.ToArray());
        }


        public string GetLineByIndex(string file, int index)
        {
            string[] full_file = File.ReadAllLines(file);
            List<string> l = new List<string>();
            l.AddRange(full_file);
            string salida = l[index];

            return salida;
        }


        public void WriteSetLines(string file, string[] lines)
        {
            File.WriteAllLines(file, lines);
        }

        public void WriteSetLines(string file, List<string> lines)
        {
            File.WriteAllLines(file, lines.ToArray());
        }










    }
}
