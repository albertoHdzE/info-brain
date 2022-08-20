namespace WolframAlgorithm
{
    partial class WolframForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>this.groupBox1.
        private void InitializeComponent()
        {
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTrainingFromFile = new System.Windows.Forms.Button();
            this.btnSaveCurrentRep = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnRep2Net = new System.Windows.Forms.Button();
            this.btnNet2Rep = new System.Windows.Forms.Button();
            this.saveDlg1 = new System.Windows.Forms.SaveFileDialog();
            this.openDlg1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hopfieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memoryFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definingMemoryFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radixSortingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btnRunWolfram = new System.Windows.Forms.Button();
            this.wolframGrid = new MyControlLibrary.WolframGridControl();
            this.gridControl1 = new MyControlLibrary.GridControl();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDefineMemFile = new System.Windows.Forms.Button();
            this.txtBoxMemFile = new System.Windows.Forms.TextBox();
            this.gridControl2 = new MyControlLibrary.GridControl();
            this.gridControl3 = new MyControlLibrary.GridControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(234, 97);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(72, 23);
            this.btnTrain.TabIndex = 0;
            this.btnTrain.Text = "Training ";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(231, 155);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(230, 184);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTrainingFromFile
            // 
            this.btnTrainingFromFile.Location = new System.Drawing.Point(230, 126);
            this.btnTrainingFromFile.Name = "btnTrainingFromFile";
            this.btnTrainingFromFile.Size = new System.Drawing.Size(95, 23);
            this.btnTrainingFromFile.TabIndex = 6;
            this.btnTrainingFromFile.Text = "Training from file";
            this.btnTrainingFromFile.UseVisualStyleBackColor = true;
            this.btnTrainingFromFile.Click += new System.EventHandler(this.btnTrainingFromFile_Click);
            // 
            // btnSaveCurrentRep
            // 
            this.btnSaveCurrentRep.Location = new System.Drawing.Point(234, 233);
            this.btnSaveCurrentRep.Name = "btnSaveCurrentRep";
            this.btnSaveCurrentRep.Size = new System.Drawing.Size(125, 23);
            this.btnSaveCurrentRep.TabIndex = 12;
            this.btnSaveCurrentRep.Text = "Save current patt";
            this.btnSaveCurrentRep.UseVisualStyleBackColor = true;
            this.btnSaveCurrentRep.Click += new System.EventHandler(this.btnSaveCurrentRep_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(234, 262);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(125, 23);
            this.button9.TabIndex = 13;
            this.button9.Text = "Append patt to file";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // btnRep2Net
            // 
            this.btnRep2Net.Location = new System.Drawing.Point(268, 352);
            this.btnRep2Net.Name = "btnRep2Net";
            this.btnRep2Net.Size = new System.Drawing.Size(38, 23);
            this.btnRep2Net.TabIndex = 18;
            this.btnRep2Net.Text = "-->";
            this.btnRep2Net.UseVisualStyleBackColor = true;
            this.btnRep2Net.Click += new System.EventHandler(this.btnRep2Net_Click);
            // 
            // btnNet2Rep
            // 
            this.btnNet2Rep.Location = new System.Drawing.Point(268, 380);
            this.btnNet2Rep.Name = "btnNet2Rep";
            this.btnNet2Rep.Size = new System.Drawing.Size(38, 23);
            this.btnNet2Rep.TabIndex = 19;
            this.btnNet2Rep.Text = "<--";
            this.btnNet2Rep.UseVisualStyleBackColor = true;
            // 
            // openDlg1
            // 
            this.openDlg1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hopfieldToolStripMenuItem,
            this.memoryFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hopfieldToolStripMenuItem
            // 
            this.hopfieldToolStripMenuItem.Name = "hopfieldToolStripMenuItem";
            this.hopfieldToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.hopfieldToolStripMenuItem.Text = "Hopfield";
            // 
            // memoryFileToolStripMenuItem
            // 
            this.memoryFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.definingMemoryFileToolStripMenuItem,
            this.radixSortingToolStripMenuItem});
            this.memoryFileToolStripMenuItem.Name = "memoryFileToolStripMenuItem";
            this.memoryFileToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.memoryFileToolStripMenuItem.Text = "Memory file";
            // 
            // definingMemoryFileToolStripMenuItem
            // 
            this.definingMemoryFileToolStripMenuItem.Name = "definingMemoryFileToolStripMenuItem";
            this.definingMemoryFileToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.definingMemoryFileToolStripMenuItem.Text = "Defining memory file";
            this.definingMemoryFileToolStripMenuItem.Click += new System.EventHandler(this.definingMemoryFileToolStripMenuItem_Click);
            // 
            // radixSortingToolStripMenuItem
            // 
            this.radixSortingToolStripMenuItem.Name = "radixSortingToolStripMenuItem";
            this.radixSortingToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.radixSortingToolStripMenuItem.Text = "Radix sorting";
            this.radixSortingToolStripMenuItem.Click += new System.EventHandler(this.radixSortingToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.btnRunWolfram);
            this.groupBox1.Controls.Add(this.wolframGrid);
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Location = new System.Drawing.Point(365, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 465);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wolfram Algorithm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(360, 327);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(227, 327);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Index in memory file: ";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(258, 374);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(124, 17);
            this.radioButton2.TabIndex = 32;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Show set esquemata";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(258, 351);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(139, 17);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Show simple esquemata";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(255, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Likelyhood:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Load results";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(255, 276);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(64, 21);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // btnRunWolfram
            // 
            this.btnRunWolfram.Location = new System.Drawing.Point(232, 215);
            this.btnRunWolfram.Name = "btnRunWolfram";
            this.btnRunWolfram.Size = new System.Drawing.Size(95, 23);
            this.btnRunWolfram.TabIndex = 7;
            this.btnRunWolfram.Text = "Run Wolfram";
            this.btnRunWolfram.UseVisualStyleBackColor = true;
            this.btnRunWolfram.Click += new System.EventHandler(this.btnRunWolfram_Click);
            // 
            // wolframGrid
            // 
            this.wolframGrid.BackColor = System.Drawing.Color.White;
            this.wolframGrid.CellHeight = 10;
            this.wolframGrid.CellWidth = 10;
            this.wolframGrid.GridX = 20;
            this.wolframGrid.GridY = 20;
            this.wolframGrid.Location = new System.Drawing.Point(23, 19);
            this.wolframGrid.MemoryFile = "";
            this.wolframGrid.Name = "wolframGrid";
            this.wolframGrid.ShowEqualElements = false;
            this.wolframGrid.Size = new System.Drawing.Size(200, 200);
            this.wolframGrid.TabIndex = 0;
            this.wolframGrid.WolframParameter = 0D;
            // 
            // gridControl1
            // 
            this.gridControl1.BackColor = System.Drawing.Color.White;
            this.gridControl1.CellHeight = 10;
            this.gridControl1.CellWidth = 10;
            this.gridControl1.GridX = 20;
            this.gridControl1.GridY = 20;
            this.gridControl1.Location = new System.Drawing.Point(23, 245);
            this.gridControl1.MemoryFile = "";
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ShowEqualElements = false;
            this.gridControl1.Size = new System.Drawing.Size(200, 200);
            this.gridControl1.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(541, 55);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 30;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(519, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Selecciona un numero entre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(487, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "%";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(431, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(51, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Wolfram parameter";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Fill randomly",
            "Load random str from mem file",
            "Load str from memory file by index"});
            this.comboBox2.Location = new System.Drawing.Point(332, 55);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(197, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "Select one option";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Memory File";
            // 
            // btnDefineMemFile
            // 
            this.btnDefineMemFile.Location = new System.Drawing.Point(293, 31);
            this.btnDefineMemFile.Name = "btnDefineMemFile";
            this.btnDefineMemFile.Size = new System.Drawing.Size(24, 23);
            this.btnDefineMemFile.TabIndex = 2;
            this.btnDefineMemFile.Text = "...";
            this.btnDefineMemFile.UseVisualStyleBackColor = true;
            this.btnDefineMemFile.Click += new System.EventHandler(this.btnDefineMemFile_Click);
            // 
            // txtBoxMemFile
            // 
            this.txtBoxMemFile.Location = new System.Drawing.Point(147, 32);
            this.txtBoxMemFile.Name = "txtBoxMemFile";
            this.txtBoxMemFile.Size = new System.Drawing.Size(147, 20);
            this.txtBoxMemFile.TabIndex = 1;
            // 
            // gridControl2
            // 
            this.gridControl2.BackColor = System.Drawing.Color.White;
            this.gridControl2.CellHeight = 10;
            this.gridControl2.CellWidth = 10;
            this.gridControl2.GridX = 20;
            this.gridControl2.GridY = 20;
            this.gridControl2.Location = new System.Drawing.Point(12, 94);
            this.gridControl2.MemoryFile = "";
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.ShowEqualElements = false;
            this.gridControl2.Size = new System.Drawing.Size(200, 200);
            this.gridControl2.TabIndex = 30;
            // 
            // gridControl3
            // 
            this.gridControl3.BackColor = System.Drawing.Color.White;
            this.gridControl3.CellHeight = 10;
            this.gridControl3.CellWidth = 10;
            this.gridControl3.GridX = 20;
            this.gridControl3.GridY = 20;
            this.gridControl3.Location = new System.Drawing.Point(14, 329);
            this.gridControl3.MemoryFile = "";
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.ShowEqualElements = false;
            this.gridControl3.Size = new System.Drawing.Size(200, 200);
            this.gridControl3.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Likelyhood:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(202, 68);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown2.TabIndex = 37;
            this.numericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Selecciona un numero entre";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fill randomly",
            "Load random str from mem file",
            "Load str from memory file by index"});
            this.comboBox1.Location = new System.Drawing.Point(12, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 21);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.Text = "Select one option";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(220, 440);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(139, 17);
            this.radioButton3.TabIndex = 38;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Show simple esquemata";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Index in memory file: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(281, 537);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 40;
            // 
            // WolframForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 563);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNet2Rep);
            this.Controls.Add(this.btnRep2Net);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnSaveCurrentRep);
            this.Controls.Add(this.btnTrainingFromFile);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDefineMemFile);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBoxMemFile);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WolframForm";
            this.Text = "Wolfram Algorithm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTrainingFromFile;
        private System.Windows.Forms.Button btnSaveCurrentRep;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnRep2Net;
        private System.Windows.Forms.Button btnNet2Rep;
        private System.Windows.Forms.SaveFileDialog saveDlg1;
        private System.Windows.Forms.OpenFileDialog openDlg1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hopfieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memoryFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem definingMemoryFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radixSortingToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private MyControlLibrary.WolframGridControl wolframGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDefineMemFile;
        private System.Windows.Forms.TextBox txtBoxMemFile;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button btnRunWolfram;
        private MyControlLibrary.GridControl gridControl1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private MyControlLibrary.GridControl gridControl2;
        private MyControlLibrary.GridControl gridControl3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

