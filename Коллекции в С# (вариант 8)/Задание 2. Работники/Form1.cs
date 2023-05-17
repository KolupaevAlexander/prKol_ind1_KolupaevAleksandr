using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Workers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ageChoicer_ValueChanged(object sender, EventArgs e)
        {
            info.Text = "";
            Queue<string> underAge = new Queue<string>();
            Queue<string> overAge = new Queue<string>();

            string path = "info.txt";

            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                    if (Int32.Parse(line.Split(' ')[4]) < ageChoicer.Value)
                        underAge.Enqueue(line);
                    else overAge.Enqueue(line);
            }

            int under = underAge.Count;
            int over = overAge.Count;

            info.Text += $"Люди младше {ageChoicer.Value} \n";
            for (int i = 0; i < under; i++)
                info.Text += underAge.Dequeue() + "\n";

            info.Text += $"Люди старше {ageChoicer.Value} \n";
            for (int i = 0; i < over; i++)
                info.Text += overAge.Dequeue() + "\n";
        }
    }
}
