using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolframAlgorithm.Utils;

namespace WolframAlgorithm
{
    public partial class MemoryFileDefinition : Form
    {

        int randomFileSize = 100;
        int longPatrones = 100;
        string memoryFileName = "";


        public MemoryFileDefinition(int longPatrones)
        {
            InitializeComponent();
            this.longPatrones = longPatrones;
        }



        private void button2_Click(object sender, EventArgs e)
        {

            if (this.randomFileSize > 0 && this.memoryFileName != "")
            {
                this.randomFileSize = (int)this.numOfPattInFile.Value;
                string linea = "";
                List<string> lineas = new List<string>();


                for (int i = 0; i < this.randomFileSize; i++)
                {
                    Pattern patt = new Pattern(longPatrones);
                    patt.FillRandomly();
                    linea = patt.ToComaSeparatedLine();
                    lineas.Add(linea);
                }

                FileHandler fh = new FileHandler(saveDlgMemoryFile.FileName);
                fh.WriteSetLines(saveDlgMemoryFile.FileName, lineas);
                MessageBox.Show("Memory file built with " + randomFileSize.ToString() + " random patterns");

                this.Close();
            }
            else
            {
                MessageBox.Show("Memory file name must be specified and number of patterns must be bigger than zero");
                this.Close();
            }
        }


        private void numOfPattInFile_ValueChanged(object sender, EventArgs e)
        {
            this.randomFileSize = (int)this.numOfPattInFile.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveDlgMemoryFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDlgMemoryFile.FilterIndex = 1;
            saveDlgMemoryFile.RestoreDirectory = true;

            if (saveDlgMemoryFile.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = saveDlgMemoryFile.FileName;
                this.memoryFileName = saveDlgMemoryFile.FileName;
            }
        }


    }
}
