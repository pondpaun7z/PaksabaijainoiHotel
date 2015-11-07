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
    public partial class Form4 : Form
    {
        Room singleRoom = new Room(1, 500);
        Room twinRoom = new Room(2, 800);
        Room middleRoom = new Room(5, 1500);
        Room bigRoom = new Room(15, 3000);

        int countPerson = 0;
        long totalPrice = 0;
        int nBigroom = 0, nMiddleroom = 0, nTwinroom = 0, nSingleroom = 0;

        Form1 menuForm;

        public Form4()
        {
            InitializeComponent();
            showRoom.Visible = false;

            cost.BackColor = Color.Transparent;
            room1.BackColor = Color.Transparent;
            room2.BackColor = Color.Transparent;
            room3.BackColor = Color.Transparent;
            room4.BackColor = Color.Transparent;
            totalRoom.BackColor = Color.Transparent;
        }

        private void calaulate_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter number.");
                errorProvider1.SetError(textBox1, "Please enter number.");
            } else if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[a-zA-Z]"))
            {
                MessageBox.Show("Please enter number.");
                errorProvider1.SetError(textBox1, "Please enter number.");
            } else if (int.Parse(textBox1.Text) < 1 || int.Parse(textBox1.Text) > 1000000) {
                MessageBox.Show("Please enter number in range(1 - 1,000,000).");
                errorProvider1.SetError(textBox1, "Please enter number in range(1 - 1,000,000)");
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

            showPriceAndRoom(nBigroom, nMiddleroom, nTwinroom, nSingleroom, totalPrice);
            setDataZero();
        }

        public void showPriceAndRoom(int nBigroom, int nMiddleroom, int nTwinroom,
                                       int nSingleroom, long totalPrice)
        {
            showRoom.Visible = true;
            cost.Text = totalPrice.ToString();
            room1.Text = nBigroom.ToString();
            room2.Text = nMiddleroom.ToString();
            room3.Text = nTwinroom.ToString();
            room4.Text = nSingleroom.ToString();
            totalRoom.Text = (nBigroom + nMiddleroom + nTwinroom + nSingleroom).ToString();
        }

        // Back to menu [Button]
        private void back2Menu_Click(object sender, EventArgs e)
        {
            menuForm = new Form1();
            this.Hide();
            menuForm.ShowDialog();
            this.Close();
        }

        // Back to calculate [Button]
        private void backToCal_Click(object sender, EventArgs e)
        {
            showRoom.Visible = false;
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
