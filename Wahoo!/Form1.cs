using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wahoo_
{
    public partial class Form1 : Form
    {
        int[] dieVal = new int[5];
        Random rand = new Random();
        int numRoll = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void buttonRoll_Click(object sender, EventArgs e)
        {
           
            if (numRoll == 0 || checkBoxDie1.Checked == true)
            {
                int x = rand.Next(1, 7);
                if( x == 1)
                {
                    this.pictureBoxDie1.Image = global::Wahoo_.Properties.Resources.die_1;
                }
                if (x == 2)
                {
                    this.pictureBoxDie1.Image = global::Wahoo_.Properties.Resources.die_2;
                }
                if (x == 3)
                {
                    this.pictureBoxDie1.Image = global::Wahoo_.Properties.Resources.die_3;
                }
                if (x == 4)
                {
                    this.pictureBoxDie1.Image = global::Wahoo_.Properties.Resources.die_4;
                }
                if (x == 5)
                {
                    this.pictureBoxDie1.Image = global::Wahoo_.Properties.Resources.die_5;
                }
                if (x == 6)
                {
                    this.pictureBoxDie1.Image = global::Wahoo_.Properties.Resources.die_6;
                }
                dieVal[0] = x;
                checkBoxDie1.Text = x.ToString();
            }
            if (numRoll == 0 || checkBoxDie2.Checked == true)
            {
                int x = rand.Next(1, 7);
                if (x == 1)
                {
                    this.pictureBoxDie2.Image = global::Wahoo_.Properties.Resources.die_1;
                }
                if (x == 2)
                {
                    this.pictureBoxDie2.Image = global::Wahoo_.Properties.Resources.die_2;
                }
                if (x == 3)
                {
                    this.pictureBoxDie2.Image = global::Wahoo_.Properties.Resources.die_3;
                }
                if (x == 4)
                {
                    this.pictureBoxDie2.Image = global::Wahoo_.Properties.Resources.die_4;
                }
                if (x == 5)
                {
                    this.pictureBoxDie2.Image = global::Wahoo_.Properties.Resources.die_5;
                }
                if (x == 6)
                {
                    this.pictureBoxDie2.Image = global::Wahoo_.Properties.Resources.die_6;
                }
                dieVal[1] = x;
                checkBoxDie2.Text = x.ToString();
            }
            if (numRoll == 0 || checkBoxDie3.Checked == true)
            {
                int x = rand.Next(1, 7);
                if (x == 1)
                {
                    this.pictureBoxDie3.Image = global::Wahoo_.Properties.Resources.die_1;
                }
                if (x == 2)
                {
                    this.pictureBoxDie3.Image = global::Wahoo_.Properties.Resources.die_2;
                }
                if (x == 3)
                {
                    this.pictureBoxDie3.Image = global::Wahoo_.Properties.Resources.die_3;
                }
                if (x == 4)
                {
                    this.pictureBoxDie3.Image = global::Wahoo_.Properties.Resources.die_4;
                }
                if (x == 5)
                {
                    this.pictureBoxDie3.Image = global::Wahoo_.Properties.Resources.die_5;
                }
                if (x == 6)
                {
                    this.pictureBoxDie3.Image = global::Wahoo_.Properties.Resources.die_6;
                }
                dieVal[2] = x;
                checkBoxDie3.Text = x.ToString();
            }
            if (numRoll == 0 || checkBoxDie4.Checked == true)
            {
                int x = rand.Next(1, 7);
                if (x == 1)
                {
                    this.pictureBoxDie4.Image = global::Wahoo_.Properties.Resources.die_1;
                }
                if (x == 2)
                {
                    this.pictureBoxDie4.Image = global::Wahoo_.Properties.Resources.die_2;
                }
                if (x == 3)
                {
                    this.pictureBoxDie4.Image = global::Wahoo_.Properties.Resources.die_3;
                }
                if (x == 4)
                {
                    this.pictureBoxDie4.Image = global::Wahoo_.Properties.Resources.die_4;
                }
                if (x == 5)
                {
                    this.pictureBoxDie4.Image = global::Wahoo_.Properties.Resources.die_5;
                }
                if (x == 6)
                {
                    this.pictureBoxDie4.Image = global::Wahoo_.Properties.Resources.die_6;
                }
                dieVal[3] = x;
                checkBoxDie4.Text = x.ToString();
            }
            if (numRoll == 0 || checkBoxDie5.Checked == true)
            {
                int x = rand.Next(1, 7);
                if (x == 1)
                {
                    this.pictureBoxDie5.Image = global::Wahoo_.Properties.Resources.die_1;
                }
                if (x == 2)
                {
                    this.pictureBoxDie5.Image = global::Wahoo_.Properties.Resources.die_2;
                }
                if (x == 3)
                {
                    this.pictureBoxDie5.Image = global::Wahoo_.Properties.Resources.die_3;
                }
                if (x == 4)
                {
                    this.pictureBoxDie5.Image = global::Wahoo_.Properties.Resources.die_4;
                }
                if (x == 5)
                {
                    this.pictureBoxDie5.Image = global::Wahoo_.Properties.Resources.die_5;
                }
                if (x == 6)
                {
                    this.pictureBoxDie5.Image = global::Wahoo_.Properties.Resources.die_6;
                }
                dieVal[4] = x;
                checkBoxDie5.Text = x.ToString();
            }
            numRoll++;
            textBoxRolls.Text = numRoll.ToString();
            if(numRoll == 3)
            {
                buttonRoll.Enabled = false;
            }
        }
    }
}
