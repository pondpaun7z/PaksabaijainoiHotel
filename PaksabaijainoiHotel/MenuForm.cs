using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;



namespace PaksabaijainoiHotel
{
    public partial class MenuForm : Form
    {

        RoomPriceForm rateRoomForm = new RoomPriceForm();
        CalculateForm calculatePriceForm = new CalculateForm();
        AboutusForm aboutusFrom = new AboutusForm();
        
        public MenuForm()
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