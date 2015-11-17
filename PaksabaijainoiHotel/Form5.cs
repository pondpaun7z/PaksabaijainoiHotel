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
    public partial class Form5 : Form
    {
        public Form5(int nBigroom, int nMiddleroom, int nTwinroom, int nSingleroom, long totalPrice)
        {
            InitializeComponent();
            cost.Text = totalPrice.ToString();
            room1.Text = nBigroom.ToString();
            room2.Text = nMiddleroom.ToString();
            room3.Text = nTwinroom.ToString();
            room4.Text = nSingleroom.ToString();
            totalRoom.Text = (nBigroom + nMiddleroom + nTwinroom + nSingleroom).ToString();
        }

        private void backToCal_Click(object sender, EventArgs e)
        {
            Form4 inputForm = new Form4();
            this.Hide();
            inputForm.ShowDialog();
            this.Close();

        }
    }
}
