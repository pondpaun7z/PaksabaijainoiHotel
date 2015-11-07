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
    public partial class StartProgramForm : Form
    {
        Form1 menuForm;
        public StartProgramForm()
        {
            InitializeComponent();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuForm = new Form1();
            this.Hide();
            menuForm.ShowDialog();
            this.Close();
        }
    }
}
