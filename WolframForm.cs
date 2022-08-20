using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encog.Neural.Networks.Layers;
using Encog.Neural.Thermal;
using Encog.MathUtil;
using Encog.MathUtil.Matrices;
using Encog.ML.Data.Specific;
using Encog.ML.Data.Basic;
using Encog.ML.Data;
using Encog.ML;
using WolframAlgorithm.Test;
using System.IO;
using System.Threading;

using WolframAlgorithm.Utils;
using MyControlLibrary;


namespace WolframAlgorithm
{
    public partial class WolframForm : Form
    {

        public const int GRID_X = 20;
        public const int GRID_Y = 20;
        public const int CELL_WIDTH = 10;
        public const int CELL_HEIGHT = 10;
        public HopfieldNetwork hopfield;
        private bool[] grid;
        private bool[] grid2;
        private bool[] lastNetwork;
        private int randomFileSize;
        private double wolframParam = 0;
        private string baseWolfram = "baseWolfram.txt";
        TypeConversor conversor = new TypeConversor();

        List<SearchingResult> wolframResults;
        

        



        public WolframForm()
        {
            
            InitializeComponent();
            // network inteface
            grid = new bool[WolframForm.GRID_X * WolframForm.GRID_Y];
            // hopfield network
            this.hopfield = new HopfieldNetwork(WolframForm.GRID_X * WolframForm.GRID_Y);
            //RadixTest TEST = new RadixTest("uno.txt", 10, 10);
            this.wolframResults = new List<SearchingResult>();
        }

        







        /// <summary>
        /// TRAINING PROCESS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTrain_Click(object sender, EventArgs e)
        {
            var input = new BiPolarMLData(grid);
            this.hopfield.AddPattern(input);
        }


        



        /// <summary>
        /// PRODUCTION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGo_Click(object sender, EventArgs e)
        {
            int indexInMemoryFile = -1;

            var input = new BiPolarMLData(this.gridControl2.GetAsBool());
            var result = this.hopfield.Compute(input);

            this.gridControl3.SetPattern(this.conversor.IML2Boolean(result));
            gridControl3.Refresh();

            SearchingResult sr = this.gridControl3.ExistsPattInMemoryFile(this.gridControl3.GetAsBool());
            if (sr.RecoveredStr != "")
            {
                indexInMemoryFile = sr.IndexInMemoryFile;
                this.label12.Text = indexInMemoryFile.ToString();
            }

            string cad1 = this.gridControl2.GetAsCommaStr();
            string cad2 = this.gridControl3.GetAsCommaStr();

            int res = LevenshteinDistance.Compute(cad1, cad2);
            double porciento = (100 * res) / (GRID_X * GRID_Y);

            this.label1.Text = porciento.ToString() + "%";

            if (this.radioButton3.Checked) // simple esquemata
            {
                this.gridControl3.CalculateIndexesEqualElements(this.gridControl2.GetAsBool());
                this.gridControl3.ShowEqualElements = true;
                this.gridControl3.Refresh();
            }
            
        }







        private string BiPolarToBinary(string bipolar)
        {
            string salida = "";
            salida = bipolar.Replace('F', '0');
            salida = salida.Replace('T', '1');
            salida = salida.Remove(0,1);
            salida = salida.Remove(salida.Length - 1, 1);
            return salida;
        }

        private void btnSaveCurrentRep_Click(object sender, EventArgs e)
        {
            var patt = new BiPolarMLData(grid2);
            string cad = patt.ToString();
            cad = this.BiPolarToBinary(cad);

            saveDlg1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDlg1.FilterIndex = 1;
            saveDlg1.RestoreDirectory = true;

            if (saveDlg1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveDlg1.FileName, cad);
            }
        }




      
        private void btnTrainingFromFile_Click(object sender, EventArgs e)
        {
            string fileName = "";
            string linea = "";
            int contador = 0;

            DialogResult result = openDlg1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                fileName = openDlg1.FileName;
            }

            StreamReader sr = new StreamReader(fileName);
            while ((linea = sr.ReadLine()) != null)
            {
                this.grid = this.conversor.StringCommas2Bool(linea);
                this.Invalidate();
                contador = contador + 1;
                var input = new BiPolarMLData(grid);
                this.hopfield.AddPattern(input);

            }

            sr.Close();

            MessageBox.Show("La red ha sido entrenada con " + contador.ToString() + " patrones");
        }



        private void btnRadix_Click(object sender, EventArgs e)
        {
            
        }




        

        private void definingMemoryFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemoryFileDefinition mfd = new MemoryFileDefinition(this.wolframGrid.Length);
            mfd.Show();
        }


        #region Wolfram region




        private void btnRunWolfram_Click(object sender, EventArgs e)
        {
            if (!(this.wolframGrid.IsEmpty) && this.wolframGrid.MemoryFileDefined && this.wolframGrid.WolframParameter > 0)
            {
                wolframGrid.RunWolframAlgorithm();
                this.wolframResults = new List<SearchingResult>();
                wolframResults = wolframGrid.GetAllWolframResults();

                int cuantos = wolframResults.Count;
                this.comboBox3.Items.Clear();
                for (int i = 1; i < cuantos; i++)
                {
                    this.comboBox3.Items.Add(i.ToString());
                }

            }
        }


        /// <summary>
        /// Define the memory file where random patterns habe been saved
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDefineMemFile_Click(object sender, EventArgs e)
        {
            openDlg1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openDlg1.FilterIndex = 1;
            openDlg1.RestoreDirectory = true;

            if (openDlg1.ShowDialog() == DialogResult.OK)
            {
                this.wolframGrid.MemoryFile = openDlg1.FileName;
                this.gridControl2.MemoryFile = openDlg1.FileName;
                this.gridControl3.MemoryFile = openDlg1.FileName;
 
                this.txtBoxMemFile.Text = openDlg1.FileName;
                int noLineas = this.wolframGrid.TotalStringsMemoryFile;

                this.label11.Text = "Select between 1 and" + noLineas.ToString();
                this.label2.Text = "Select between 1 and" + noLineas.ToString();

                this.numericUpDown1.Value = noLineas;
                this.numericUpDown2.Value = noLineas;

            }
        }


       
        


        /// <summary>
        /// When user select one option for fill the wolfram grid it act according to the option.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.comboBox2.Text == "Fill randomly")
            {
                this.wolframGrid.FillRandomly();
            }

            if (this.comboBox2.Text == "Load random str from mem file")
            {
                if (this.wolframGrid.MemoryFileDefined)
                {
                    int noLineas = this.wolframGrid.TotalStringsMemoryFile;
                    Random rn = new Random();
                    int numero = rn.Next(0, noLineas);
                    this.wolframGrid.LoadLineFromMemoryByIndex(numero);

                }
                else
                {
                    MessageBox.Show("Memory file has not been defined");
                }
            }

            if (this.comboBox2.Text == "Load str from memory file by index")
            {
                if (this.wolframGrid.MemoryFileDefined)
                {
                    if (this.numericUpDown1.Value > 0 && this.numericUpDown1.Value <= this.wolframGrid.TotalStringsMemoryFile)
                    {
                        this.wolframGrid.LoadLineFromMemoryByIndex((int)this.numericUpDown1.Value - 1);
                     }
                }
                else
                {
                    MessageBox.Show("Memory file has not been defined");
                }
            }
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.wolframParam = double.Parse(this.textBox3.Text);
            this.wolframGrid.WolframParameter = this.wolframParam;
        }


        /// <summary>
        /// When Wolfram algorithm results cobobox change for choosing one of the results, it is shown in the gridcontrol
        /// the selected result. Here it is possible to show simple esquemata (equalities between choosen pattern result and
        /// the pattern in wolfram component) or general esqueamate (equalities between pattern in wolfram component and
        /// all results)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int option = int.Parse(this.comboBox3.Text);

            SearchingResult wr = new SearchingResult(); // save results of wolfram algorithm
            wr = this.wolframResults[option];
            this.gridControl1.SetPattern(wr.RecoveredStr);
            this.label8.Text = wr.LevenshteinDistance.ToString();
            this.label13.Text = wr.IndexInMemoryFile.ToString();

            if (this.radioButton1.Checked) // simple esquemata
            {
                this.gridControl1.CalculateIndexesEqualElements(this.wolframGrid.GetAsBool());
                this.gridControl1.ShowEqualElements = true;
                this.gridControl1.Refresh();
            }

            if (this.radioButton2.Checked) // complex esquemata
            {
                string[] wolfraResultsStr = new string[this.wolframResults.Count];

                for (int i = 0; i < this.wolframResults.Count; i++)
                {
                    SearchingResult wr1 = new SearchingResult();
                    wr1 = (SearchingResult)this.wolframResults[i];
                    wolfraResultsStr[i] = wr1.RecoveredStr;
                }
                this.gridControl1.CalculateIndexesEqualElements(wolfraResultsStr);
                this.gridControl1.ShowEqualElements = true;
                this.gridControl1.Refresh();
            }
        }


        #endregion

        private void radixSortingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveDlg1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDlg1.FilterIndex = 1;
            saveDlg1.RestoreDirectory = true;

            if (saveDlg1.ShowDialog() == DialogResult.OK)
            {
                Radix rad = new Radix(saveDlg1.FileName);
                rad.SortFile();
            }


            MessageBox.Show("El archivo: " + saveDlg1.FileName + "ha sido ordenado");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.gridControl2.CleanInteface();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "Fill randomly")
            {
                this.gridControl2.FillRandomly();
            }

            if (this.comboBox2.Text == "Load random str from mem file")
            {
                if (this.gridControl2.MemoryFileDefined)
                {
                    int noLineas = this.gridControl2.TotalStringsMemoryFile;
                    Random rn = new Random();
                    int numero = rn.Next(0, noLineas);
                    this.gridControl2.LoadLineFromMemoryByIndex(numero);

                }
                else
                {
                    MessageBox.Show("Memory file has not been defined");
                }
            }

            if (this.comboBox1.Text == "Load str from memory file by index")
            {
                if (this.gridControl2.MemoryFileDefined)
                {
                    if (this.numericUpDown2.Value > 0 && this.numericUpDown2.Value <= this.gridControl2.TotalStringsMemoryFile)
                    {
                        this.gridControl2.LoadLineFromMemoryByIndex((int)this.numericUpDown2.Value - 1);
                    }
                }
                else
                {
                    MessageBox.Show("Memory file has not been defined");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.wolframGrid.CleanInteface();
        }

        private void btnRep2Net_Click(object sender, EventArgs e)
        {
            this.wolframGrid.SetPattern(this.gridControl3.GetAsBool());
        }

  

     

















    }
}
