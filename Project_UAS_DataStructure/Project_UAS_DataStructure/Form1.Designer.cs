namespace Project_UAS_DataStructure
{
    partial class Form1
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
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.listBoxRaw = new System.Windows.Forms.ListBox();
            this.listBoxHasil = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QuickSortBtn = new System.Windows.Forms.RadioButton();
            this.RadixSortBtn = new System.Windows.Forms.RadioButton();
            this.HeapSortBtn = new System.Windows.Forms.RadioButton();
            this.BubbleSortBtn = new System.Windows.Forms.RadioButton();
            this.ShellSortBtn = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ProcessTime = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.DescendingBtn = new System.Windows.Forms.RadioButton();
            this.AscendingBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(249, 57);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(112, 38);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonProcess
            // 
            this.buttonProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.buttonProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcess.Location = new System.Drawing.Point(424, 250);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(112, 38);
            this.buttonProcess.TabIndex = 1;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = false;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // listBoxRaw
            // 
            this.listBoxRaw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.listBoxRaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRaw.FormattingEnabled = true;
            this.listBoxRaw.ItemHeight = 16;
            this.listBoxRaw.Location = new System.Drawing.Point(28, 101);
            this.listBoxRaw.Name = "listBoxRaw";
            this.listBoxRaw.Size = new System.Drawing.Size(333, 676);
            this.listBoxRaw.TabIndex = 2;
            // 
            // listBoxHasil
            // 
            this.listBoxHasil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.listBoxHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxHasil.FormattingEnabled = true;
            this.listBoxHasil.ItemHeight = 16;
            this.listBoxHasil.Location = new System.Drawing.Point(605, 101);
            this.listBoxHasil.Name = "listBoxHasil";
            this.listBoxHasil.Size = new System.Drawing.Size(345, 676);
            this.listBoxHasil.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Masukan Jumlah Data :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(713, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasil Sort :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(377, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Metode Sorting :";
            // 
            // QuickSortBtn
            // 
            this.QuickSortBtn.AutoSize = true;
            this.QuickSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuickSortBtn.Location = new System.Drawing.Point(424, 101);
            this.QuickSortBtn.Name = "QuickSortBtn";
            this.QuickSortBtn.Size = new System.Drawing.Size(95, 21);
            this.QuickSortBtn.TabIndex = 7;
            this.QuickSortBtn.TabStop = true;
            this.QuickSortBtn.Text = "Quick Sort";
            this.QuickSortBtn.UseVisualStyleBackColor = true;
            this.QuickSortBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RadixSortBtn
            // 
            this.RadixSortBtn.AutoSize = true;
            this.RadixSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadixSortBtn.Location = new System.Drawing.Point(424, 127);
            this.RadixSortBtn.Name = "RadixSortBtn";
            this.RadixSortBtn.Size = new System.Drawing.Size(94, 21);
            this.RadixSortBtn.TabIndex = 8;
            this.RadixSortBtn.TabStop = true;
            this.RadixSortBtn.Text = "Radix Sort";
            this.RadixSortBtn.UseVisualStyleBackColor = true;
            this.RadixSortBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // HeapSortBtn
            // 
            this.HeapSortBtn.AutoSize = true;
            this.HeapSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeapSortBtn.Location = new System.Drawing.Point(424, 154);
            this.HeapSortBtn.Name = "HeapSortBtn";
            this.HeapSortBtn.Size = new System.Drawing.Size(93, 21);
            this.HeapSortBtn.TabIndex = 9;
            this.HeapSortBtn.TabStop = true;
            this.HeapSortBtn.Text = "Heap Sort";
            this.HeapSortBtn.UseVisualStyleBackColor = true;
            this.HeapSortBtn.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // BubbleSortBtn
            // 
            this.BubbleSortBtn.AutoSize = true;
            this.BubbleSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BubbleSortBtn.Location = new System.Drawing.Point(424, 181);
            this.BubbleSortBtn.Name = "BubbleSortBtn";
            this.BubbleSortBtn.Size = new System.Drawing.Size(103, 21);
            this.BubbleSortBtn.TabIndex = 10;
            this.BubbleSortBtn.TabStop = true;
            this.BubbleSortBtn.Text = "Bubble Sort";
            this.BubbleSortBtn.UseVisualStyleBackColor = true;
            this.BubbleSortBtn.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // ShellSortBtn
            // 
            this.ShellSortBtn.AutoSize = true;
            this.ShellSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShellSortBtn.Location = new System.Drawing.Point(424, 207);
            this.ShellSortBtn.Name = "ShellSortBtn";
            this.ShellSortBtn.Size = new System.Drawing.Size(90, 21);
            this.ShellSortBtn.TabIndex = 11;
            this.ShellSortBtn.TabStop = true;
            this.ShellSortBtn.Text = "Shell Sort";
            this.ShellSortBtn.UseVisualStyleBackColor = true;
            this.ShellSortBtn.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.numericUpDown1.Location = new System.Drawing.Point(28, 66);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(137, 22);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Process Time :";
            // 
            // ProcessTime
            // 
            this.ProcessTime.AutoSize = true;
            this.ProcessTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessTime.Location = new System.Drawing.Point(421, 354);
            this.ProcessTime.Name = "ProcessTime";
            this.ProcessTime.Size = new System.Drawing.Size(44, 17);
            this.ProcessTime.TabIndex = 14;
            this.ProcessTime.Text = "*Time";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(424, 501);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 38);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(426, 546);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 38);
            this.buttonExit.TabIndex = 16;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // DescendingBtn
            // 
            this.DescendingBtn.AutoSize = true;
            this.DescendingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescendingBtn.Location = new System.Drawing.Point(192, 9);
            this.DescendingBtn.Name = "DescendingBtn";
            this.DescendingBtn.Size = new System.Drawing.Size(97, 21);
            this.DescendingBtn.TabIndex = 18;
            this.DescendingBtn.TabStop = true;
            this.DescendingBtn.Text = "Desending";
            this.DescendingBtn.UseVisualStyleBackColor = true;
            // 
            // AscendingBtn
            // 
            this.AscendingBtn.AutoSize = true;
            this.AscendingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AscendingBtn.Location = new System.Drawing.Point(20, 9);
            this.AscendingBtn.Name = "AscendingBtn";
            this.AscendingBtn.Size = new System.Drawing.Size(95, 21);
            this.AscendingBtn.TabIndex = 17;
            this.AscendingBtn.TabStop = true;
            this.AscendingBtn.Text = "Ascending";
            this.AscendingBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DescendingBtn);
            this.groupBox1.Controls.Add(this.AscendingBtn);
            this.groupBox1.Location = new System.Drawing.Point(616, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 44);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(234)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(985, 840);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.ProcessTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ShellSortBtn);
            this.Controls.Add(this.BubbleSortBtn);
            this.Controls.Add(this.HeapSortBtn);
            this.Controls.Add(this.RadixSortBtn);
            this.Controls.Add(this.QuickSortBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxHasil);
            this.Controls.Add(this.listBoxRaw);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "Form1";
            this.Text = "Data Structure";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.ListBox listBoxRaw;
        private System.Windows.Forms.ListBox listBoxHasil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton QuickSortBtn;
        private System.Windows.Forms.RadioButton RadixSortBtn;
        private System.Windows.Forms.RadioButton HeapSortBtn;
        private System.Windows.Forms.RadioButton BubbleSortBtn;
        private System.Windows.Forms.RadioButton ShellSortBtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ProcessTime;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.RadioButton DescendingBtn;
        private System.Windows.Forms.RadioButton AscendingBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

