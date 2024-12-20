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
            AscendingBtn.Checked = true;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //Generate Random
            listBoxRaw.Items.Clear();
            data = new int[(int)numericUpDown1.Value];

            Random objRandom = new Random();
            for (int i = 0; i < (int)numericUpDown1.Value; i++)
            {
                int tampungAngka = objRandom.Next(0, 1000000);
                data[i] = tampungAngka;
            }

            for (int i = 0; i < data.Length; i++)
            {
                listBoxRaw.Items.Add(data[i]);
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            // Menjalankan waktu
            var waktu = new Stopwatch();
            waktu.Start();

            //Process Sort
            listBoxHasil.Items.Clear();
            if (type == "Quick")
            {
                QuickSort(data, 0, data.Length - 1);

                waktu.Stop();

                ProcessTime.Text = $"{waktu.Elapsed.TotalMilliseconds:F3} ms";

                for (int i = 0; i < data.Length; i++)
                {
                    listBoxHasil.Items.Add(data[i]);
                }
            }
            else if (type == "Radix")
            {
                int iterasi = data.Max().ToString().Length;

                List<string> tampung = new List<string>();
                for (int i = 0; i < data.Length; i++)
                {
                    tampung.Add(data[i].ToString().PadLeft(iterasi, '0'));
                }

                RadixSort(tampung, iterasi);

                waktu.Stop();
                ProcessTime.Text = $"{waktu.ElapsedMilliseconds} ms";

                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = int.Parse(tampung[i]);
                    listBoxHasil.Items.Add(data[i]);

                }

            }
            else if (type == "Heap")
            {
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
                ShellSort(data);

                waktu.Stop();
                ProcessTime.Text = $"{waktu.ElapsedMilliseconds} ms";

                for (int i = 0; i < data.Length; i++)
                {
                    listBoxHasil.Items.Add(data[i]);
                }
            }
        }

        #region Quick Sort
        private int[] QuickSort(int[] daftarData, int first, int last)
        {
            int pos;
            if (first < last)
            {
                pos = Split(daftarData, first, last);   
                QuickSort(daftarData, first, pos - 1);
                QuickSort(daftarData, pos + 1, last);
            }
            return daftarData;
        }

        private int Split(int[] daftarData, int first, int last)
        {
            int pivot = daftarData[first];
            int left = first;
            int right = last;
            if (AscendingBtn.Checked)
            {
                while (left < right)
                {
                    // Cari yang lebih kecil dari pivot di kanan
                    while (daftarData[right] > pivot)
                    {
                        right--;
                    }
                    // Cari yang lebih besar dari pivot di kiri
                    while (left < right && daftarData[left] <= pivot)
                    {
                        left++;
                    }
                    if (left < right)
                    {
                        int temp;
                        temp = daftarData[left];
                        daftarData[left] = daftarData[right];
                        daftarData[right] = temp;
                    }
                }
            }
            else
            {
                while (left < right)
                {
                    // Cari yang lebih kecil dari pivot di kanan
                    while (daftarData[right] < pivot)
                    {
                        right--;
                    }

                    // Cari yang lebih besar dari pivot di kiri
                    while (left < right && daftarData[left] >= pivot)
                    {
                        left++;
                    }
                    if (left < right)
                    {
                        int temp = daftarData[left];
                        daftarData[left] = daftarData[right];
                        daftarData[right] = temp;
                    }
                }
            }
            // Tempatkan pivot di posisi akhir partisi
            daftarData[first] = daftarData[right];
            daftarData[right] = pivot;

            return right; // Kembalikan posisi pivot
        }
        #endregion
        #region Radix Sort
        private void RadixSort(List<string> listFinal, int iterasi)
        {
            
            for (int i = 0; i < iterasi; i++) //iterasi sesuai panjang angka
            {
                int indexAmbil = iterasi - (i+1);

                List<string>[] daftarTampung = new List<string>[10];

                for (int j = 0; j < daftarTampung.Length; j++) // Initialize each list
                {
                    daftarTampung[j] = new List<string>();  
                }

                for (int j = 0; j < listFinal.Count; j++) //untuk masukin data ke index baru
                {
                    for (int k = 0; k < daftarTampung.Length; k++)
                    {
                        
                        if (listFinal[j][indexAmbil] == ((char)k + '0'))
                        {
                            if (AscendingBtn.Checked) // kecil => besar => kecil
                            {
                                daftarTampung[k].Add(listFinal[j]);
                                break;
                            }
                            else
                            {
                                daftarTampung[daftarTampung.Length - (k+1)].Add(listFinal[j]);
                                break;
                            }
                        }
                    }
                }

                listFinal.Clear();
                foreach (var list in daftarTampung)
                {
                    listFinal.AddRange(list);
                }
            }
        }
        #endregion
        #region Heap Sort
        private int[] HeapSort(int[] daftarData)
        {
            int n = daftarData.Length;
            if (AscendingBtn.Checked)
            {
                // Bangun max heap
                for (int i = n / 2 - 1; i >= 0; i--)
                {
                    MaxHeapify(daftarData, n, i);
                }
                // Ekstraksi elemen dari heap satu per satu
                for (int i = n - 1; i >= 0; i--)
                {
                    // Pindahkan root (elemen terbesar) ke akhir array
                    Swap(daftarData, 0, i);

                    // Panggil  asc heapify pada heap yang tersisa
                    MaxHeapify(daftarData, i, 0);
                }
            }
            else
            {
                // Bangun min heap
                for (int i = n / 2 - 1; i >= 0; i--)
                {
                    MinHeapify(daftarData, n, i);
                }
                // Ekstraksi elemen dari heap satu per satu
                for (int i = n - 1; i >= 0; i--)
                {
                    // Pindahkan root (elemen terbesar) ke akhir array
                    Swap(daftarData, 0, i);

                    // Panggil  asc heapify pada heap yang tersisa
                    MinHeapify(daftarData, i, 0);
                }
            }
            return daftarData;
        }

        #region Heapify
        //max heap
        private void MaxHeapify(int[] array, int n, int i)
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
                MaxHeapify(array, n, largest);
            }
        }

        //min heax
        private void MinHeapify(int[] array, int n, int i)
        {
            int smallest = i; //inisialisasi smallest jadi root
            int left = 2 * i + 1; //indeks anak kiri
            int right = 2 * i + 2; //indeks anak kanan

            // Jika anak kiri lebih besar dari root
            if (left < n && array[left] < array[smallest])
            {
                smallest = 1;
            }

            // Jika anak kanan lebih besar dari largest saat ini
            if (right < n && array[right] < array[smallest])
            {
                smallest = right;
            }

            //jika smallest bukan root
            if (smallest != i)
            {
                Swap(array, i, smallest);

                // manggil min heap untuk pengurangan heap
                MinHeapify(array, i, 0);
            }
        }
        #endregion

        #region Swap
        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        #endregion

        #endregion
        #region Bubble Sort
        private int[] BubbleSort(int[] daftarData)
        {
            int tampung = 0;
            if (AscendingBtn.Checked) //ascending order
            {
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
            }
            else //descending order
            {
                for (int i = 0; i < daftarData.Length; i++)
                {
                    for (int j = 0; j < daftarData.Length - 1; j++)
                    {
                        if (daftarData[j] < daftarData[j + 1])
                        {
                            tampung = daftarData[j];
                            daftarData[j] = daftarData[j + 1];
                            daftarData[j + 1] = tampung;
                        }
                    }
                }
            }
            return daftarData;
        }
        #endregion
        #region Shell Sort
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

                    if (AscendingBtn.Checked)
                    {
                        for (j = i; j >= gap && daftarData[j - gap] > temp; j -= gap)
                        {
                            daftarData[j] = daftarData[j - gap];
                        }
                    }
                    else
                    {
                        for (j = i; j >= gap && daftarData[j - gap] < temp; j -= gap)
                        {
                            daftarData[j] = daftarData[j - gap];
                        }
                    }

                    // put temp (the original a[i]) 
                    // in its correct location
                    daftarData[j] = temp;

                }
            }
            return daftarData;
        }
        #endregion


        #region Event Button
        #region Radio Button
        private void radioButtonQuickSort_CheckedChanged(object sender, EventArgs e)
        {
            //Quick Sort
            type = "Quick";
        }

        private void radioButtonRadixSort_CheckedChanged(object sender, EventArgs e)
        {
            //Radix Sort
            type = "Radix";
        }

        private void radioButtonHeapSort_CheckedChanged(object sender, EventArgs e)
        {
            //Heap Sort
            type = "Heap";
        }

        private void radioButtonBubbleSort_CheckedChanged(object sender, EventArgs e)
        {
            //Bubble Sort
            type = "Bubble";
        }

        private void radioButtonShellSort_CheckedChanged(object sender, EventArgs e)
        {
            //Shell Sort
            type = "Shell";
        }
        #endregion

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clear Form
            listBoxHasil.Items.Clear();
            listBoxRaw.Items.Clear();
            ProcessTime.Text = "-";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Exit form
            Application.Exit();
        }
        #endregion

    }
}
