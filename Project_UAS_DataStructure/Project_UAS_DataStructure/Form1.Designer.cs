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
            this.radioButtonQuick = new System.Windows.Forms.RadioButton();
            this.radioButtonRadixSort = new System.Windows.Forms.RadioButton();
            this.radioButtonHeapSort = new System.Windows.Forms.RadioButton();
            this.radioButtonBubbleSort = new System.Windows.Forms.RadioButton();
            this.radioButtonShellSort = new System.Windows.Forms.RadioButton();
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
            this.buttonGenerate.Location = new System.Drawing.Point(187, 46);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(84, 31);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonProcess
            // 
            this.buttonProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.buttonProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcess.Location = new System.Drawing.Point(318, 203);
            this.buttonProcess.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(84, 31);
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
            this.listBoxRaw.Location = new System.Drawing.Point(21, 82);
            this.listBoxRaw.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxRaw.Name = "listBoxRaw";
            this.listBoxRaw.Size = new System.Drawing.Size(251, 550);
            this.listBoxRaw.TabIndex = 2;
            // 
            // listBoxHasil
            // 
            this.listBoxHasil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.listBoxHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxHasil.FormattingEnabled = true;
            this.listBoxHasil.Location = new System.Drawing.Point(454, 82);
            this.listBoxHasil.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxHasil.Name = "listBoxHasil";
            this.listBoxHasil.Size = new System.Drawing.Size(260, 550);
            this.listBoxHasil.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Masukan Jumlah Data :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasil Sort :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(283, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Metode Sorting :";
            // 
            // radioButtonQuick
            // 
            this.radioButtonQuick.AutoSize = true;
            this.radioButtonQuick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonQuick.Location = new System.Drawing.Point(318, 82);
            this.radioButtonQuick.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonQuick.Name = "radioButtonQuick";
            this.radioButtonQuick.Size = new System.Drawing.Size(75, 17);
            this.radioButtonQuick.TabIndex = 7;
            this.radioButtonQuick.TabStop = true;
            this.radioButtonQuick.Text = "Quick Sort";
            this.radioButtonQuick.UseVisualStyleBackColor = true;
            this.radioButtonQuick.CheckedChanged += new System.EventHandler(this.radioButtonQuickSort_CheckedChanged);
            // 
            // radioButtonRadixSort
            // 
            this.radioButtonRadixSort.AutoSize = true;
            this.radioButtonRadixSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRadixSort.Location = new System.Drawing.Point(316, 103);
            this.radioButtonRadixSort.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonRadixSort.Name = "radioButtonRadixSort";
            this.radioButtonRadixSort.Size = new System.Drawing.Size(74, 17);
            this.radioButtonRadixSort.TabIndex = 8;
            this.radioButtonRadixSort.TabStop = true;
            this.radioButtonRadixSort.Text = "Radix Sort";
            this.radioButtonRadixSort.UseVisualStyleBackColor = true;
            this.radioButtonRadixSort.CheckedChanged += new System.EventHandler(this.radioButtonRadixSort_CheckedChanged);
            // 
            // radioButtonHeapSort
            // 
            this.radioButtonHeapSort.AutoSize = true;
            this.radioButtonHeapSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHeapSort.Location = new System.Drawing.Point(318, 125);
            this.radioButtonHeapSort.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonHeapSort.Name = "radioButtonHeapSort";
            this.radioButtonHeapSort.Size = new System.Drawing.Size(73, 17);
            this.radioButtonHeapSort.TabIndex = 9;
            this.radioButtonHeapSort.TabStop = true;
            this.radioButtonHeapSort.Text = "Heap Sort";
            this.radioButtonHeapSort.UseVisualStyleBackColor = true;
            this.radioButtonHeapSort.CheckedChanged += new System.EventHandler(this.radioButtonHeapSort_CheckedChanged);
            // 
            // radioButtonBubbleSort
            // 
            this.radioButtonBubbleSort.AutoSize = true;
            this.radioButtonBubbleSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBubbleSort.Location = new System.Drawing.Point(318, 147);
            this.radioButtonBubbleSort.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonBubbleSort.Name = "radioButtonBubbleSort";
            this.radioButtonBubbleSort.Size = new System.Drawing.Size(80, 17);
            this.radioButtonBubbleSort.TabIndex = 10;
            this.radioButtonBubbleSort.TabStop = true;
            this.radioButtonBubbleSort.Text = "Bubble Sort";
            this.radioButtonBubbleSort.UseVisualStyleBackColor = true;
            this.radioButtonBubbleSort.CheckedChanged += new System.EventHandler(this.radioButtonBubbleSort_CheckedChanged);
            // 
            // radioButtonShellSort
            // 
            this.radioButtonShellSort.AutoSize = true;
            this.radioButtonShellSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonShellSort.Location = new System.Drawing.Point(318, 168);
            this.radioButtonShellSort.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonShellSort.Name = "radioButtonShellSort";
            this.radioButtonShellSort.Size = new System.Drawing.Size(70, 17);
            this.radioButtonShellSort.TabIndex = 11;
            this.radioButtonShellSort.TabStop = true;
            this.radioButtonShellSort.Text = "Shell Sort";
            this.radioButtonShellSort.UseVisualStyleBackColor = true;
            this.radioButtonShellSort.CheckedChanged += new System.EventHandler(this.radioButtonShellSort_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.numericUpDown1.Location = new System.Drawing.Point(21, 54);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
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
            this.numericUpDown1.Size = new System.Drawing.Size(103, 20);
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
            this.label4.Location = new System.Drawing.Point(316, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Process Time :";
            // 
            // ProcessTime
            // 
            this.ProcessTime.AutoSize = true;
            this.ProcessTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessTime.Location = new System.Drawing.Point(316, 288);
            this.ProcessTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProcessTime.Name = "ProcessTime";
            this.ProcessTime.Size = new System.Drawing.Size(34, 13);
            this.ProcessTime.TabIndex = 14;
            this.ProcessTime.Text = "*Time";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(320, 409);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(84, 31);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(320, 444);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(84, 31);
            this.buttonExit.TabIndex = 16;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // DescendingBtn
            // 
            this.DescendingBtn.AutoSize = true;
            this.DescendingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescendingBtn.Location = new System.Drawing.Point(144, 7);
            this.DescendingBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DescendingBtn.Name = "DescendingBtn";
            this.DescendingBtn.Size = new System.Drawing.Size(76, 17);
            this.DescendingBtn.TabIndex = 18;
            this.DescendingBtn.TabStop = true;
            this.DescendingBtn.Text = "Desending";
            this.DescendingBtn.UseVisualStyleBackColor = true;
            // 
            // AscendingBtn
            // 
            this.AscendingBtn.AutoSize = true;
            this.AscendingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AscendingBtn.Location = new System.Drawing.Point(15, 7);
            this.AscendingBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AscendingBtn.Name = "AscendingBtn";
            this.AscendingBtn.Size = new System.Drawing.Size(75, 17);
            this.AscendingBtn.TabIndex = 17;
            this.AscendingBtn.TabStop = true;
            this.AscendingBtn.Text = "Ascending";
            this.AscendingBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DescendingBtn);
            this.groupBox1.Controls.Add(this.AscendingBtn);
            this.groupBox1.Location = new System.Drawing.Point(462, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(226, 36);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(234)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(739, 609);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.ProcessTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.radioButtonShellSort);
            this.Controls.Add(this.radioButtonBubbleSort);
            this.Controls.Add(this.radioButtonHeapSort);
            this.Controls.Add(this.radioButtonRadixSort);
            this.Controls.Add(this.radioButtonQuick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxHasil);
            this.Controls.Add(this.listBoxRaw);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.buttonGenerate);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.RadioButton radioButtonQuick;
        private System.Windows.Forms.RadioButton radioButtonRadixSort;
        private System.Windows.Forms.RadioButton radioButtonHeapSort;
        private System.Windows.Forms.RadioButton radioButtonBubbleSort;
        private System.Windows.Forms.RadioButton radioButtonShellSort;
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

