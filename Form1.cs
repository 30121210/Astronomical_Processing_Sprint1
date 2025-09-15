using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neutrino_astronomy
{
    public partial class Form1 : Form
    {
        private readonly int[] dates = new int[max];
        private const int max = 24;
        private readonly Random rand = new Random();
        private bool isLoaded=false;
        private bool isSorted=false;
        private int SelectedIndex = -1;




        private void refreshlist()
        {

            listBox1.Items.Clear();
            for (int i = 0; i < dates.Length; i++)
            {
                listBox1.Items.Add(dates[i]);
            }

        }

        // This method is for Sort
        // Fill
        private void filArray()
        {
            for (int i = 0; i < dates.Length; i++)
            {
                dates[i] = rand.Next(10, 91);
            }
                
            isLoaded = true;
            isSorted = false;

            refreshlist();
            MessageBox.Show("Random numbers loaded between 10 and 91");



        }




        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = listBox1.SelectedIndex;
            //Fill in the text box with the current value to edit.

            if(SelectedIndex >= 0 && SelectedIndex < dates.Length)
            {
                textBoxEdite.Text = dates[SelectedIndex].ToString();
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            filArray();

        }

        

        private void BubbleSortAnim()
        {
            
            int n=dates.Length;
            bool swapped;

            do
            {
                swapped = false;

                for (int j = 0; j < n - 1; j++)
                {
                    if (dates[j] > dates[j + 1])
                    {
                        int tmp = dates[j];
                        dates[j] = dates[j + 1];
                        dates[j + 1] = tmp;
                        swapped = true;
                    }

                    
                   

                }

                n--;
            }while(swapped);

            refreshlist();
            isSorted = true;

        }

        private void textBoxSort_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isLoaded)
            {
                MessageBox.Show("First load dates");
                return;
            }
            BubbleSortAnim();
            isSorted = true;
            MessageBox.Show("Sorted data");
        }




        


        private void ShowDates(int low, int high)
        {
            listBox1.Items.Clear();
            for (int i=low; i < high; i++)
            {
                listBox1.Items.Add(dates[i]);
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            if (!isLoaded)
            {
                MessageBox.Show("First load dates");
                return;
            }


            //Show error if is empty
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                MessageBox.Show("\"Search box can't be empty\"");
                return;
            }
            if (!int.TryParse(textBoxSearch.Text, out int target))
            {
                MessageBox.Show("You must enter a integer");
                return;
            }

            //Ensuring order for binary search


            int lowBound = 0;
            int highBound = dates.Length - 1;

            while (lowBound <= highBound)
            {
                int mid = (lowBound + highBound) / 2;
                if (dates[mid] == target)
                {
                    //Select the index found in the list

                    listBox1.SelectedIndex = mid;
                    MessageBox.Show($"Search successful.Found at index {mid} with the value {dates[mid]}");
                    
                    return;


                }
                else if (dates[mid] > target)
                {
                    highBound = mid - 1;
                }
                else
                {
                    lowBound = mid + 1;
                }

                

            }
            MessageBox.Show("Search not sucessful.Try another value");
        }





            
            
               

        

        private void textBoxEdite_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!isLoaded)
            {
                MessageBox.Show("First load dates");
                return;
            }
            
            if (SelectedIndex < 0 || SelectedIndex >= dates.Length)
            {
                MessageBox.Show("You must select an index from the list");
                return;
            }
            if (!int.TryParse(textBoxEdite.Text, out int newValue))
            {
                MessageBox.Show("You must enter an integer");
                return;
            }
            if (newValue < 10 || newValue > 91)
            {
                MessageBox.Show("You must enter an integer between 10 and 91");
                return;
            }
            dates[SelectedIndex] = newValue;
            refreshlist();
            listBox1.SelectedIndex = SelectedIndex;//Keep highlighted
            MessageBox.Show("Value updated");
        }
    }
}
