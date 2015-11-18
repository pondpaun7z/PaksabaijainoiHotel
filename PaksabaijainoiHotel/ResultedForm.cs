using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaksabaijainoiHotel
{
    public partial class ResultedForm : Form
    {
        public ResultedForm(int nBigroom, int nMiddleroom, int nTwinroom, int nSingleroom, long totalPrice)
        {
            InitializeComponent();
            cost.Text = totalPrice.ToString("n0");
            room4.Text = nBigroom.ToString("n0");
            room3.Text = nMiddleroom.ToString("n0");
            room2.Text = nTwinroom.ToString("n0");
            room1.Text = nSingleroom.ToString("n0");
            totalRoom.Text = (nBigroom + nMiddleroom + nTwinroom + nSingleroom).ToString("n0");
        }

        private void backToCal_Click(object sender, EventArgs e)
        {
            CalculateForm inputForm = new CalculateForm();
            this.Hide();
            inputForm.ShowDialog();
            this.Close();

        }
    }
}
