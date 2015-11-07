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
    public partial class Form1 : Form
    {

        Form3 rateRoomForm = new Form3();
        Form4 calculatePriceForm = new Form4();
        AboutusForm aboutusFrom = new AboutusForm();
        
        public Form1()
        {
            InitializeComponent();            
        }

        // Room rate Button
        private void roomRate_Click(object sender, EventArgs e)
        {
            this.Hide();
            rateRoomForm.ShowDialog();
            this.Close();
        }

        // Calculate Button
        private void calculate_Click(object sender, EventArgs e)
        {
            this.Hide();
            calculatePriceForm.ShowDialog();
            this.Close();
        }


        // About us Button
        private void aboutus_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            aboutusFrom.ShowDialog();
            this.Close();
        }

        // Exit Button
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}