using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UAS_DataStructure
{
    public partial class Form1 : Form
    {
        private int[] dataRaw;
        private int[] dataProceed;
        private string type = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Quick Sort
            type = "Quick";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Radix Sort
            type = "Radix";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //Heap Sort
            type = "Heap";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //Bubble Sort
            type = "Bubble";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //Shell Sort
            type = "Shell";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Generate Random
            listBoxRaw.Items.Clear();
            int counter = (int)numericUpDown1.Value;
            dataRaw = new int[counter];
            dataProceed = new int[counter];

            Random objRandom = new Random();
            for (int i = 0; i < counter; i++)
            {
                int tampungAngka = objRandom.Next(0, 10000);
                dataRaw[i] = tampungAngka;
            }

            for (int i = 0; i < dataRaw.Length; i++)
            {
                listBoxRaw.Items.Add(dataRaw[i]);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxHasil.Items.Clear();
            //Process Sort
            if (type == "Quick")
            {

            }
            else if (type == "Radix")
            {

            }
            else if (type == "Heap")
            {

            }
            else if (type == "Bubble")
            {

            }
            else if (type == "Shell")
            {

            }
        }

        private int[] QuickSort()
        {
            
            return dataProceed;
        }

        private int[] RadixSort()
        {

            return dataProceed;
        }

        private int[] HeapSort()
        {

            return dataProceed;
        }

        private int[] BubbleSort()
        {

            return dataProceed;
        }

        private int[] ShellSort()
        {

            return dataProceed;
        }

    }
}
