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

namespace Astronomical_Processing_Sprint1
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




        private void button_Search_Click(object sender, EventArgs e)
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

        private void button_Edit_Click(object sender, EventArgs e)
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
            textBoxEdite.Clear();
            listBox1.SelectedIndex = SelectedIndex;//Keep highlighted
            MessageBox.Show("Value updated");
        }

        

        private void buttonMid_Extreme_Click(object sender, EventArgs e)
        {
            //is date loaded
            if (!isLoaded)
            {
                MessageBox.Show("First load dates");
                return;
            }
            //Obtanin the minium and maximum values of the dates array
            int min = dates[0];
            int max = dates[0];
            for(int i=1;i<dates.Length;i++)
            {
                if (dates[i] < min)
                    min = dates[i];
                if (dates[i] > max)
                    max = dates[i];
            }int mid = (min + max) / 2;


            MessageBox.Show($"Mid-Extreme value: {mid}");
        }

        private void buttonMode_Click(object sender, EventArgs e)
        {
            //is date loaded
            if (!isLoaded)
            {
                MessageBox.Show("First load dates");
                return;
            }
            //Counting frequencies with a fixed arrangement 
            int[] frequency = new int[82]; // Index 0-9 unused, 10-91 used

            for (int i = 0; i < dates.Length; i++)
            {
                int v = dates[i];
                if (v < 10 && v > 91)
                {
                    MessageBox.Show($"Value{v} out of range");
                    return;
                }
                frequency[v-10]++;
            }
            //Finding the high frequency
            int maxFreq = 0;
            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] > maxFreq)
                    maxFreq = frequency[i];
            }

            //Specials cases
            if (maxFreq <= 1)
            {
                MessageBox.Show("No mode found.All values appear only once");
                return;
            }
            // Check if there is only one fashion
            int mode = -1;
            int modeCount = 0;
            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] == maxFreq)
                {

                    modeCount++;
                    mode = i + 10;
                    if (modeCount > 1)
                    {
                        MessageBox.Show("No unique mode found");
                        break;
                    }
                }
            }
            if (modeCount == 1)
            {
                MessageBox.Show($"Mode found: {mode} appearing {maxFreq} times");
                return;

            }

            listBox1.ClearSelected();
            for (int i = 0; i < dates.Length; i++)
            {
                if (dates[i] == mode)
                {
                    listBox1.SetSelected(i, true);
                    MessageBox.Show($"Mode found: {mode} appearing {maxFreq} times");

                }

            }
        }

        private void buttonAverage_Click(object sender, EventArgs e)
        {
            //is date loaded
            if (!isLoaded)
            {
                MessageBox.Show("First load dates");
                return;
            }
        int sum= 0;
            for (int i = 0; i < dates.Length; i++)
            {
                sum += dates[i];
            }
            //Calculate average
            double average = (double)sum / dates.Length;
            MessageBox.Show($"Average: {average:F2}");
        }

        private void buttonRange_Click(object sender, EventArgs e)
        {
            //is date loaded
            if(!isLoaded)
            {
                MessageBox.Show("First load dates");
                return;
            }
            //Obtanin the minium and maximum values of the dates array
            int min = dates[0];
            int max = dates[0];
            //Finding min and max going through the array
            for (int i = 1; i < dates.Length; i++)
            {
                if (dates[i] < min)
                    min = dates[i];
                if (dates[i] > max)
                    max = dates[i];
            }
            //Calculate range
            int range = max - min;
            MessageBox.Show($"Range: {range}");

        }

        private void buttonSequencial_Search_Click(object sender, EventArgs e)
        {
            if (!isLoaded)
            {
                MessageBox.Show("First load dates");
                return;
            }
            //Read dates from the text box and validate
            if (string.IsNullOrWhiteSpace(textBoxLinear_Search.Text))
            {
                MessageBox.Show("\"Search box can't be empty\"");
                return;
            }
            if (!int.TryParse(textBoxLinear_Search.Text, out int target))
            {
                MessageBox.Show("You must enter a integer");
                return;
            }


            //Linear search not requires sorted data
            bool found = false;
            int foundIndex = -1;

            for (int i=0;i<dates.Length;i++)
            {
                found = true;
                foundIndex = i;
                //He stops whehn he finds the target
                break;
            }
            //Show results
            if (found)
            {
                listBox1.ClearSelected();
                listBox1.SetSelected(foundIndex, true);
                MessageBox.Show($"Search successful.Found at index {foundIndex} with the value {dates[foundIndex]}");
            }
            else
            {
                MessageBox.Show("Search not sucessful.Try another value");
            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
