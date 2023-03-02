using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace linq_2
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();
        List<int> years = new List<int>();
        List<string> words = new List<string>();

        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
            numbers.AddRange(new[]
            {
                1, 7, 45, 245, 3, -3, 2543, 0, -356, 69, -99 
            });

            years.AddRange(new[]
            {
                2000, 1999, 2022, 1945, 2012, 2006, 2017
            });

            words.AddRange(new[]
            {
                "Flamingo", "Pudding", "Sardine", "Zephyr", "Caramel", "Mirage", "Harpoon", "Calculus", "Football", "Aple"
            });

            listBox1.DataSource = numbers;
        }

        private void Task1Button_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = numbers.Where(x => x > 0).OrderBy(x => x).ToList();
        }

        private void Task2Button_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            var number = numbers.Where(x => x > 0 && x > 10 && x < 100).ToList();

            var avg = number.Average();

            MessageBox.Show($"Count: {number.Count()}\n" +
                            $"Average: {avg}");
        }

        private void Task3Button_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            var leapYears = years.Where(x => DateTime.IsLeapYear(x)).OrderByDescending(x => x).ToList();

            listBox1.DataSource = leapYears;
        }


        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }


        private void Task4Button_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            var even = numbers.Where(IsEven).ToList();
            var max = even.Max();

            listBox1.Items.Add(max);
        }

        private void Task5Button_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            var word = words.Select(x => x + "!!!").ToList();

            listBox1.DataSource = word;
        }

        private void Task6Button_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            char symbol = 'a';
            var word = words.Where(x => x.Contains(symbol)).ToList();

            listBox1.DataSource = word;
        }

        private void Task7Button_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            var word = words.GroupBy(x => x.Length);

            foreach (var i in word)
            {
                listBox1.Items.Add(i.Key.ToString());
            }
        }
    }
}