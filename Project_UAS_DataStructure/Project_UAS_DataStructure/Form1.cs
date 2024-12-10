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
        private int counter; // untuk menentukan panjang arr

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
            counter = (int)numericUpDown1.Value;
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
                int iterasi = data.Max().ToString().Length;
                string[] tampung = new string[counter];
                for (int i = 0; i < data.Length; i++)
                {
                    tampung[i] = data[i].ToString().PadLeft(iterasi,'0');
                }

                RadixSort(tampung, iterasi);
                


                var waktu = new Stopwatch();
                waktu.Start();


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
            if (daftarData.Length <= 1)
            {
                return daftarData; // Basis rekursi: array dengan satu elemen atau kosong sudah terurut
            }

            // Pilih pivot (gunakan elemen terakhir sebagai pivot)
            int pivot = daftarData[daftarData.Length - 1];
            var left = new List<int>();  // Elemen yang lebih kecil dari pivot
            var right = new List<int>(); // Elemen yang lebih besar dari pivot

            // Partisi elemen
            for (int i = 0; i < daftarData.Length - 1; i++)
            {
                if (daftarData[i] <= pivot)
                {
                    left.Add(daftarData[i]);
                }
                else
                {
                    right.Add(daftarData[i]);
                }
            }

            // Rekursi pada bagian kiri dan kanan
            int[] sortedLeft = QuickSort(left.ToArray());
            int[] sortedRight = QuickSort(right.ToArray());

            // Gabungkan hasil
            return sortedLeft.Concat(new int[] { pivot }).Concat(sortedRight).ToArray();
        }

        private int[] RadixSort(string[] daftarData, int iterasi)
        {
            
            for (int i = 0; i < iterasi; i++) //iterasi sesuai panjang angka
            {
                int indexAmbil = iterasi - (i+1);

                List<string>[] daftarTampung = new List<string>[10];

                for (int j = 0; i < daftarTampung.Length; i++) // Initialize each list
                {
                    daftarTampung[i] = new List<string>();  
                }

                for (int j = 0; j < daftarTampung.Length; j++) //untuk masukin data ke index baru
                {
                    if (daftarData[j][indexAmbil] == '0')
                    {
                        daftarTampung[0].Add(daftarData[j]);
                    }

                    if (daftarData[j][indexAmbil] == '1')
                    {
                        daftarTampung[1].Add(daftarData[j]);
                    }

                    if (daftarData[j][indexAmbil] == '2')
                    {
                        daftarTampung[2].Add(daftarData[j]);
                    }

                    if (daftarData[j][indexAmbil] == '3')
                    {
                        daftarTampung[3].Add(daftarData[j]);
                    }

                    if (daftarData[j][indexAmbil] == '4')
                    {
                        daftarTampung[4].Add(daftarData[j]);
                    }

                    if (daftarData[j][indexAmbil] == '5')
                    {
                        daftarTampung[5].Add(daftarData[j]);
                    }

                    if (daftarData[j][indexAmbil] == '6')
                    {
                        daftarTampung[6].Add(daftarData[j]);
                    }

                    if (daftarData[j][indexAmbil] == '7')
                    {
                        daftarTampung[7].Add(daftarData[j]);
                    }

                    if (daftarData[j][indexAmbil] == '8')
                    {
                        daftarTampung[8].Add(daftarData[j]);
                    }

                    if (daftarData[j][indexAmbil] == '9')
                    {
                        daftarTampung[9].Add(daftarData[j]);
                    }
                }

                List<string> listFinal = new List<string>();

                foreach (var list in daftarTampung)
                {
                    listFinal.AddRange(list);
                }
            }
            return daftarData.Select(int.Parse).ToArray();          
        }

        private int[] HeapSort(int[] daftarData)
        {
            int n = daftarData.Length;

            // Bangun max heap
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(daftarData, n, i);
            }

            // Ekstraksi elemen dari heap satu per satu
            for (int i = n - 1; i >= 0; i--)
            {
                // Pindahkan root (elemen terbesar) ke akhir array
                Swap(daftarData, 0, i);

                // Panggil heapify pada heap yang tersisa
                Heapify(daftarData, i, 0);
            }

            return daftarData;
        }
        private void Heapify(int[] array, int n, int i)
        {
            int largest = i; // Inisialisasi largest sebagai root
            int left = 2 * i + 1; // Indeks anak kiri
            int right = 2 * i + 2; // Indeks anak kanan

            // Jika anak kiri lebih besar dari root
            if (left < n && array[left] > array[largest])
            {
                largest = left;
            }

            // Jika anak kanan lebih besar dari largest saat ini
            if (right < n && array[right] > array[largest])
            {
                largest = right;
            }

            // Jika largest bukan root
            if (largest != i)
            {
                Swap(array, i, largest);

                // Rekursi untuk subtree yang terpengaruh
                Heapify(array, n, largest);
            }
        }

        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
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

        private void button4_Click(object sender, EventArgs e)
        {
            //Exit form
            this.Close();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
