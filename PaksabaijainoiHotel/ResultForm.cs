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
    public partial class ResultForm : Form
    {
        Form4 calcuclateForm = new Form4();
        public ResultForm(int nBigroom, int nMiddleroom, int nTwinroom,
                                       int nSingleroom, long totalPrice)
        {
            InitializeComponent();
            cost.BackColor = Color.Transparent;
            room1.BackColor = Color.Transparent;
            room2.BackColor = Color.Transparent;
            room3.BackColor = Color.Transparent;
            room4.BackColor = Color.Transparent;
            totalRoom.BackColor = Color.Transparent;

            showResul(nBigroom, nMiddleroom, nTwinroom, nSingleroom, totalPrice);
        }

        public void showResul(int nBigroom, int nMiddleroom, int nTwinroom,
                                  int nSingleroom, long totalPrice)
        {
            cost.Text = totalPrice.ToString();
            room1.Text = nBigroom.ToString();
            room2.Text = nMiddleroom.ToString();
            room3.Text = nTwinroom.ToString();
            room4.Text = nSingleroom.ToString();
            totalRoom.Text = (nBigroom + nMiddleroom + nTwinroom + nSingleroom).ToString();
        }

        private void backToCal_Click(object sender, EventArgs e)
        {
            this.Hide();
            calcuclateForm.ShowDialog();
            this.Close();
        }
    }
}
