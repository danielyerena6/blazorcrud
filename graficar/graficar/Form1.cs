using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graficar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Series["Series1"].LegendText = "Mexico Covid-19";

            
            string[] lines = File.ReadAllLines("country_wise_latest.csv");
            
            int n;
            n = lines.Length;

            var line1 = lines[0].Split(',');
            var line = lines[112].Split(',');

            for (int i=1;i<=7;i++)
            {
                
                chart1.Series["Series1"].Points.AddXY(line1[i], line[i]);
                
            }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
