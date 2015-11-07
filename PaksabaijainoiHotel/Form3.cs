using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaksabaijainoiHotel
{
    public partial class Form3 : Form
    {
        Form1 menuForm;
        Form4 calculateForm;

        public Form3()
        {
            InitializeComponent();
        }

        private void back2Menu_Click(object sender, EventArgs e)
        {
            menuForm = new Form1();
            this.Hide();
            menuForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculateForm = new Form4();
            this.Hide();
            calculateForm.ShowDialog();
            this.Close();
        }
    }
}
