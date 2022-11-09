using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            DateTime dateTime = DateTime.Now;

            int doty = dateTime.DayOfYear;

            MessageBox.Show("Dnes je " + dateTime.ToString("dddd d. MMMM yyyy ") + ". Je to " + doty + ". den v roce. Je " + dateTime.ToString("hh") + " hodin " + dateTime.ToString("mm") + " minut a " + dateTime.ToString("ss") + " sekund");


        }
    }
}
