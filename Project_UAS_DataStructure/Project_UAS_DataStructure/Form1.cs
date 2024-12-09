using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Project_UAS_DataStructure
{
    public partial class Form1 : Form
    {
        private int[] data;
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
            data = new int[counter];

            Random objRandom = new Random();
            for (int i = 0; i < counter; i++)
            {
                int tampungAngka = objRandom.Next(0, 10000);
                data[i] = tampungAngka;
            }

            for (int i = 0; i < data.Length; i++)
            {
                listBoxRaw.Items.Add(data[i]);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Process Sort
            listBoxHasil.Items.Clear();
            if (type == "Quick")
            {
                var waktu = new Stopwatch();
                waktu.Start();

                QuickSort(data);

                waktu.Stop();
                ProcessTime.Text = $"{waktu.ElapsedMilliseconds} ms";

                for (int i = 0; i < data.Length; i++)
                {
                    listBoxHasil.Items.Add(data[i]);
                }
            }
            else if (type == "Radix")
            {
                var waktu = new Stopwatch();
                waktu.Start();

                RadixSort(data);

                waktu.Stop();
                ProcessTime.Text = $"{waktu.ElapsedMilliseconds} ms";

                for (int i = 0; i < data.Length; i++)
                {
                    listBoxHasil.Items.Add(data[i]);
                }
            }
            else if (type == "Heap")
            {
                var waktu = new Stopwatch();
                waktu.Start();

                HeapSort(data);

                waktu.Stop();
                ProcessTime.Text = $"{waktu.ElapsedMilliseconds} ms";

                for (int i = 0; i < data.Length; i++)
                {
                    listBoxHasil.Items.Add(data[i]);
                }
            }
            else if (type == "Bubble")
            {
                var waktu = new Stopwatch();
                waktu.Start();

                BubbleSort(data);

                waktu.Stop();
                ProcessTime.Text = $"{waktu.ElapsedMilliseconds} ms";

                for (int i = 0; i < data.Length; i++)
                {
                    listBoxHasil.Items.Add(data[i]);
                }
            }
            else if (type == "Shell")
            {
                var waktu = new Stopwatch();
                waktu.Start();

                ShellSort(data);

                waktu.Stop();
                ProcessTime.Text = $"{waktu.ElapsedMilliseconds} ms";

                for (int i = 0; i < data.Length; i++)
                {
                    listBoxHasil.Items.Add(data[i]);
                }
            }
        }

        private int[] QuickSort(int[] daftarData)
        {
            return daftarData;
        }

        private int[] RadixSort(int[] daftarData)
        {

            return daftarData;
        }

        private int[] HeapSort(int[] daftarData)
        {

            return daftarData;
        }

        private int[] BubbleSort(int[] daftarData)
        {
            int tampung = 0;
            for (int i = 0; i < daftarData.Length; i++)
            {
                for (int j = 0; j < daftarData.Length - 1; j++)
                {
                    if (daftarData[j] > daftarData[j + 1])
                    {
                        tampung = daftarData[j];
                        daftarData[j] = daftarData[j + 1];
                        daftarData[j + 1] = tampung;
                    }
                }
            }
            return daftarData;
        }

        private int[] ShellSort(int[] daftarData)
        {
            int n = daftarData.Length;

            // Start with a big gap, 
            // then reduce the gap
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Do a gapped insertion sort for this gap size.
                // The first gap elements a[0..gap-1] are already
                // in gapped order keep adding one more element
                // until the entire array is gap sorted
                for (int i = gap; i < n; i += 1)
                {
                    // add a[i] to the elements that have
                    // been gap sorted save a[i] in temp and
                    // make a hole at position i
                    int temp = daftarData[i];

                    // shift earlier gap-sorted elements up until
                    // the correct location for a[i] is found
                    int j;
                    for (j = i; j >= gap && daftarData[j - gap] > temp; j -= gap)
                        daftarData[j] = daftarData[j - gap];

                    // put temp (the original a[i]) 
                    // in its correct location
                    daftarData[j] = temp;
                }
            }
            return daftarData;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Clear Form
            listBoxHasil.Items.Clear();
            listBoxRaw.Items.Clear();
            ProcessTime.Text = "-";
        }
    }
}
