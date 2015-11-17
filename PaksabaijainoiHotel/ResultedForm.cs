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
    public partial class ResultedForm : Form
    {
        public ResultedForm(int nBigroom, int nMiddleroom, int nTwinroom, int nSingleroom, long totalPrice)
        {
            InitializeComponent();
            cost.Text = totalPrice.ToString();
            room4.Text = nBigroom.ToString();
            room3.Text = nMiddleroom.ToString();
            room2.Text = nTwinroom.ToString();
            room1.Text = nSingleroom.ToString();
            totalRoom.Text = (nBigroom + nMiddleroom + nTwinroom + nSingleroom).ToString();
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
