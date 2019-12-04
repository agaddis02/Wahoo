
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

        int totalScore = 0;
        int itemScore = 0;


        private void checkBox5Kind_CheckedChanged(object sender, EventArgs e)
        {
            if (fiveOfAKind(dieVal))
            {
                itemScore = 30;
                textBox5Kind.Text = itemScore.ToString("F");
                checkBox5Kind.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
            }
            else
            {
                itemScore = 0;
                textBox5Kind.Text = itemScore.ToString("F");
                checkBox5Kind.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
            }
        }

        private void checkBox4Kind_CheckedChanged(object sender, EventArgs e)
        {
            if (fourOfAKind(dieVal))
            {
                itemScore = fourSummed(dieVal);
                textBox4Kind.Text = itemScore.ToString("F");
                checkBox4Kind.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
            }
            else
            {
                itemScore = 0;
                textBox4Kind.Text = itemScore.ToString("F");
                checkBox4Kind.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
            }
        }

        private void checkBox3Kind_CheckedChanged(object sender, EventArgs e)
        {
            if (threeOfAKind(dieVal))
            {
                itemScore = threeSummed(dieVal);
                textBox3Kind.Text = itemScore.ToString("F");
                checkBox3Kind.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
            }
            else
            {
                itemScore = 0;
                textBox3Kind.Text = itemScore.ToString("F");
                checkBox3Kind.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
            }
        }

        private void checkBoxFHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (threeOfAKind(dieVal))
            {
                itemScore = threeSummed(dieVal);
                textBox3Kind.Text = itemScore.ToString("F");
                checkBox3Kind.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
            }
            else
            {
                itemScore = 0;
                textBox3Kind.Text = itemScore.ToString("F");
                checkBox3Kind.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
            }
        }

        private void checkBoxSmStr_CheckedChanged(object sender, EventArgs e)
        {
            if(SmallStraight(dieVal))
            {
                itemScore = 30;
                textBoxSmStraight.Text = itemScore.ToString("F");
                checkBoxSmStr.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
            }
            else
            {
                itemScore = 0;
                textBoxSmStraight.Text = itemScore.ToString("F");
                checkBoxSmStr.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
            }
        }

        private void checkBoxLgStr_CheckedChanged(object sender, EventArgs e)
        {
            if (LongStraight(dieVal))
            {
                itemScore = 40;
                textBoxLgStraight.Text = itemScore.ToString("F");
                checkBoxLgStr.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
            }
            else
            {
                itemScore = 0;
                textBoxLgStraight.Text = itemScore.ToString("F");
                checkBoxLgStr.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
            }
        }

        private void checkBoxChan_CheckedChanged(object sender, EventArgs e)
        {

        }
































        // Methods

        // Count Pairs Method
        public int countPairs(int[] arr)
        {
            /*
			* Counts the amount of matching numbers within an array
			*/
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                int previousNum;
                if (i == 0)
                {
                    previousNum = -99999;
                }
                else
                {
                    previousNum = arr[i - 1];
                }

                if (currentNum == previousNum)
                {
                    count++;
                }
            }
            return count;
        }
        // Count Pairs Method

        // Going Up Method
        public bool goingUp(int[] arr)
        {
            /*
			*Determines if an array is increasing hints going up
			**/
            bool isAsc = true;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] >= arr[i + 1])
                {
                    isAsc = false;
                }
            }

            return isAsc;

        }
        // Going Up


        // Three of a kind 
        public bool threeOfAKind(int[] arr)
        {
            /*
			* Determines if the array has 3 of a kind
			*/
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                int previousNum;
                if (i == 0)
                {
                    previousNum = -99999;
                }
                else
                {
                    previousNum = arr[i - 1];
                }

                if (currentNum == previousNum)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count == 2)
                {
                    break;
                }
            }

            if (count >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Three of a kind

        // Three of a kind sum
        public int threeSummed(int[] arr)
        {
            /*
			* Determines if the array has 3 of a kind
			*/
            int count = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                int previousNum;
                if (i == 0)
                {
                    previousNum = -99999;
                }
                else
                {
                    previousNum = arr[i - 1];
                }

                if (currentNum == previousNum)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count == 2)
                {
                    sum = currentNum * count;
                    break;
                }
            }

            
            if (count >= 2)
            {
                return sum;
            }
            else
            {
                return 0;
            }
        }
        // Three of a kind Sum


        // Four of a kind Sum

        public int fourSummed(int[] arr)
        {
            /*
			* Determines if the array has 3 of a kind
			*/
            int count = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                int previousNum;
                if (i == 0)
                {
                    previousNum = -99999;
                }
                else
                {
                    previousNum = arr[i - 1];
                }

                if (currentNum == previousNum)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count == 3)
                {
                    sum = currentNum * count;
                    break;
                }
            }

            
            if (count >= 3)
            {
                return sum;
            }
            else
            {
                return 0;
            }
        }
        // Four of a kind Summed


        // Four of a kind
        public bool fourOfAKind(int[] arr)
        {
            /*
			* Determines if the array has 4 of a kind
			*/
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                int previousNum;
                if (i == 0)
                {
                    previousNum = -99999;
                }
                else
                {
                    previousNum = arr[i - 1];
                }

                if (currentNum == previousNum)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count == 3)
                {
                    break;
                }
            }

            if (count >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Four of a kind

        // Five of a kind
        public bool fiveOfAKind(int[] arr)
        {
            /*
			* Determines if the array has 4 of a kind
			*/
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                int previousNum;
                if (i == 0)
                {
                    previousNum = -99999;
                }
                else
                {
                    previousNum = arr[i - 1];
                }

                if (currentNum == previousNum)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count == 4)
                {
                    break;
                }
            }

            if (count >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Five of a kind


        // Small Straight
        public bool SmallStraight(int[] arr)
        {
            /*
			* Determines if the user has gotten 4 dice of the same number in a row
			*/
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                int previousNum;
                if (i == 0)
                {
                    previousNum = -99999;
                }
                else
                {
                    previousNum = arr[i - 1];
                }

                if (currentNum == previousNum + 1)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count == 3)
                {
                    break;
                }
            }


            if (count >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Small Straight


        // Long Straight
        public bool LongStraight(int[] arr)
        {
            /*
			* Determines if the user has gotten 5 dice of the same number in a row
			*/
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                int previousNum;
                if (i == 0)
                {
                    previousNum = -99999;
                }
                else
                {
                    previousNum = arr[i - 1];
                }

                if (currentNum == previousNum + 1)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count == 4)
                {
                    break;
                }
            }


            if (count >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Long Straight

        // Full House
        public bool fullHouse(int[] arr)
        {
            if (((arr[0] == arr[1]) && (arr[1] == arr[2]) && (arr[0] == arr[2]) && (arr[3] == arr[4])))
            {
                return true;
            }
            else if ((arr[0] == arr[1]) && ((arr[2] == arr[3]) && (arr[3] == arr[4]) && (arr[2] == arr[4])))
            {
                return true;
            }
            else
            {
                return false;




            }
            // Full House
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
