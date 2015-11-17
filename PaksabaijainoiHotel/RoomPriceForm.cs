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
    public partial class RoomPriceForm : Form
    {
        MenuForm menuForm;
        CalculateForm calculateForm;

        public RoomPriceForm()
        {
            InitializeComponent();
        }

        private void back2Menu_Click(object sender, EventArgs e)
        {
            menuForm = new MenuForm();
            this.Hide();
            menuForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculateForm = new CalculateForm();
            this.Hide();
            calculateForm.ShowDialog();
            this.Close();
        }
    }
}
