using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace PaksabaijainoiHotel
{
    public partial class CalculateForm : Form
    {
        Room singleRoom = new Room(1, 500);
        Room twinRoom = new Room(2, 800);
        Room middleRoom = new Room(5, 1500);
        Room bigRoom = new Room(15, 3000);

        int countPerson = 0;
        long totalPrice = 0;
        int nBigroom = 0, nMiddleroom = 0, nTwinroom = 0, nSingleroom = 0;

        MenuForm menuForm;
        ResultedForm resultForm;

        public CalculateForm()
        {
            InitializeComponent();
            button1.Visible = false;
        }

        private void calaulate_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter number.");
            } else if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[0-9]"))
            {
                MessageBox.Show("Please enter number.");
            } else if (int.Parse(textBox1.Text) < 1 || int.Parse(textBox1.Text) > 1000000) {
                MessageBox.Show("Please enter number in range(1 - 1,000,000).");
            } else
            {
                errorProvider1.SetError(textBox1, null);
                calculateCheapest(textBox1);
            }
        }

        

        void calculateCheapest(TextBox textBox1)
        {
            int persons = int.Parse(textBox1.Text);

            while (countPerson < persons)
            {
                if (persons - countPerson >= 15)
                {
                    countPerson += bigRoom.getPerson();
                    nBigroom++;
                }
                else if (persons - countPerson >= 5)
                {
                    countPerson += middleRoom.getPerson();
                    nMiddleroom++;
                }
                else if (persons - countPerson >= 2)
                {
                    countPerson += twinRoom.getPerson();
                    nTwinroom++;
                }
                else if (persons - countPerson >= 1)
                {
                    countPerson += singleRoom.getPerson();
                    nSingleroom++;
                }
                checkRoom();
            }

            totalPrice = (nBigroom * bigRoom.getPrice()) + (nMiddleroom * middleRoom.getPrice()) +
                    (nTwinroom * twinRoom.getPrice()) + (nSingleroom * singleRoom.getPrice());

            resultForm = new ResultedForm(nBigroom, nMiddleroom, nTwinroom, nSingleroom, totalPrice);
            this.Hide();
            resultForm.ShowDialog();
            this.Close();
            setDataZero();
        }

        private void Enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;            

            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[0-9]") &&
                int.Parse(textBox1.Text) >= 1 && int.Parse(textBox1.Text) <= 1000000)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    calaulate_Click(sender, e);
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                status.BackColor = Color.LightSeaGreen;
                button1.Visible = false;
                errorProvider1.SetError(status, null);
            } else if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[0-9]"))
            {
                status.BackColor = Color.Red;
                button1.Visible = false;
                errorProvider1.SetError(status, "Please enter number.");
            } else if (int.Parse(textBox1.Text) < 1 || int.Parse(textBox1.Text) > 1000000) {
                status.BackColor = Color.Red;
                button1.Visible = false;
                errorProvider1.SetError(status, "Please enter number in range(1 - 1,000,000)");
            } else
            {
                status.BackColor = Color.Chartreuse;
                button1.Visible = true;
                errorProvider1.SetError(status, null);
            }

        }


        // Back to menu [Button]
        private void back2Menu_Click(object sender, EventArgs e)
        {
            menuForm = new MenuForm();
            this.Hide();
            menuForm.ShowDialog();
            this.Close();
        }

        public void checkRoom()
        {

            if (nSingleroom > 1)
            {
                nTwinroom++;
                nSingleroom = 0;
            }

            if (nTwinroom > 1)
            {
                nMiddleroom++;
                nTwinroom = 0;
            }

            if (nMiddleroom > 1)
            {
                nBigroom++;
                nMiddleroom = 0;
            }
        }


        // set all variable to zero
        public void setDataZero()
        {
            countPerson = 0;
            nSingleroom = 0;
            nTwinroom = 0;
            nMiddleroom = 0;
            nBigroom = 0;
            totalPrice = 0;
            textBox1.Text = "";
        }
    }
}
