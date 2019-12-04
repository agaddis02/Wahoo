
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
        // Global Variables
        int[] dieVal = new int[5];
        Random rand = new Random();
        int numRoll = 0; 
        int totalScore = 0;
        int itemScore = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            // Rolls the die, outputs the image of the given number
            // at the end stores each final value within the array
            if (numRoll == 0 || checkBoxDie1.Checked == true)
            {
                int x = rand.Next(1, 7);
                if (x == 1)
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
            if (numRoll == 3)
            {
                buttonRoll.Enabled = false;
            }

            checkBoxDie1.Checked = false;
            checkBoxDie2.Checked = false;
            checkBoxDie3.Checked = false;
            checkBoxDie4.Checked = false;
            checkBoxDie5.Checked = false;

        }

        // Check Box five of a kind method 
        private void checkBox5Kind_CheckedChanged(object sender, EventArgs e)
        {
            // if true sets the value of the item score to respective number else sets the score to zero
            // Both cases disable the check box, enable the roll button, and set roll number to 0
            if (fiveOfAKind(dieVal))
            {
                itemScore = 30;
                textBox5Kind.Text = itemScore.ToString("F");
                checkBox5Kind.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
                buttonRoll.Enabled = true;
                numRoll = 0;
                textBoxRolls.Text = numRoll.ToString("F");
            }
            else
            {
                itemScore = 0;
                textBox5Kind.Text = itemScore.ToString("F");
                checkBox5Kind.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
                buttonRoll.Enabled = true;
                numRoll = 0;
                textBoxRolls.Text = numRoll.ToString("F");
            }
        }

        // 4 kind
        private void checkBox4Kind_CheckedChanged(object sender, EventArgs e)
        {
            // if true sets the value of the item score to respective number else sets the score to zero
            // Both cases disable the check box, enable the roll button, and set roll number to 0
            if (fourOfAKind(dieVal))
            {
                itemScore = fourSummed(dieVal);
                textBox4Kind.Text = itemScore.ToString("F");
                checkBox4Kind.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
                buttonRoll.Enabled = true;
                numRoll = 0;
                textBoxRolls.Text = numRoll.ToString("F");
            }
            else
            {
                itemScore = 0;
                textBox4Kind.Text = itemScore.ToString("F");
                checkBox4Kind.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
                buttonRoll.Enabled = true;
                numRoll = 0;
                textBoxRolls.Text = numRoll.ToString("F");
            }
        }

        // 3 kind
        private void checkBox3Kind_CheckedChanged(object sender, EventArgs e)
        {
            // if true sets the value of the item score to respective number else sets the score to zero
            // Both cases disable the check box, enable the roll button, and set roll number to 0
            if (threeOfAKind(dieVal))
            {
                itemScore = threeSummed(dieVal);
                textBox3Kind.Text = itemScore.ToString("F");
                checkBox3Kind.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
                buttonRoll.Enabled = true;
                numRoll = 0;
                textBoxRolls.Text = numRoll.ToString("F");
            }
            else
            {
                itemScore = 0;
                textBox3Kind.Text = itemScore.ToString("F");
                checkBox3Kind.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
                buttonRoll.Enabled = true;
                numRoll = 0;
                textBoxRolls.Text = numRoll.ToString("F");
            }
        }

        // full house
        private void checkBoxFHouse_CheckedChanged(object sender, EventArgs e)
        {
            // if true sets the value of the item score to respective number else sets the score to zero
            // Both cases disable the check box, enable the roll button, and set roll number to 0
            if (fullHouse(dieVal))
            {
                itemScore = 25;
                textBoxFullHouse.Text = itemScore.ToString("F");
                checkBoxFHouse.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
                buttonRoll.Enabled = true;
                numRoll = 0;
                textBoxRolls.Text = numRoll.ToString("F");
            }
            else
            {
                itemScore = 0;
                textBoxFullHouse.Text = itemScore.ToString("F");
                checkBoxFHouse.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
                buttonRoll.Enabled = true;
                numRoll = 0;
                textBoxRolls.Text = numRoll.ToString("F");
            }
        }

        // small straight
        private void checkBoxSmStr_CheckedChanged(object sender, EventArgs e)
        {
            // if true sets the value of the item score to respective number else sets the score to zero
            // Both cases disable the check box, enable the roll button, and set roll number to 0
            if (SmallStraight(dieVal))
            {
                itemScore = 30;
                textBoxSmStraight.Text = itemScore.ToString("F");
                checkBoxSmStr.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
                buttonRoll.Enabled = true;
                numRoll = 0;
                textBoxRolls.Text = numRoll.ToString("F");
            }
            else
            {
                itemScore = 0;
                textBoxSmStraight.Text = itemScore.ToString("F");
                checkBoxSmStr.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
                buttonRoll.Enabled = true;
                numRoll = 0;
                textBoxRolls.Text = numRoll.ToString("F");
            }
        }

        // large straight
        private void checkBoxLgStr_CheckedChanged(object sender, EventArgs e)
        {
            // if true sets the value of the item score to respective number else sets the score to zero
            // Both cases disable the check box, enable the roll button, and set roll number to 0
            if (LongStraight(dieVal))
            {
                itemScore = 40;
                textBoxLgStraight.Text = itemScore.ToString("F");
                checkBoxLgStr.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
                buttonRoll.Enabled = true;
                numRoll = 0;
                textBoxRolls.Text = numRoll.ToString("F");
            }
            else
            {
                itemScore = 0;
                textBoxLgStraight.Text = itemScore.ToString("F");
                checkBoxLgStr.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
                buttonRoll.Enabled = true;
                numRoll = 0;
                textBoxRolls.Text = numRoll.ToString("F");
            }
        }

        // Chance
        private void checkBoxChan_CheckedChanged(object sender, EventArgs e)
        {
            // if true sets the value of the item score to respective number else sets the score to zero
            // Both cases disable the check box, enable the roll button, and set roll number to 0
            if (scoreChance(dieVal) != 0)
            {
                itemScore = scoreChance(dieVal);
                textBoxChance.Text = itemScore.ToString("F");
                checkBoxChan.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
                buttonRoll.Enabled = true;
                numRoll = 0;
                textBoxRolls.Text = numRoll.ToString("F");
            }
            else
            {
                itemScore = 0;
                textBoxChance.Text = itemScore.ToString("F");
                checkBoxChan.Enabled = false;
                totalScore += itemScore;
                textBoxTotalScore.Text = totalScore.ToString("F");
                buttonRoll.Enabled = true;
                numRoll = 0;
                textBoxRolls.Text = numRoll.ToString("F");
            }
        }






        // Methods


        // sum up the array
        public int scoreChance(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;


        }


        // Three of a kind 
        public bool threeOfAKind(int[] arr)
        {
            /*
			* Determines if the array has 3 of a kind
			*/
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Array.Sort(arr);
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
            int currentNum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Array.Sort(arr);
                currentNum = arr[i];
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

            sum = currentNum * 3;
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
            int currentNum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Array.Sort(arr);
                currentNum = arr[i];
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

            sum = currentNum * 4;
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
                Array.Sort(arr);
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
                Array.Sort(arr);
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
                Array.Sort(arr);
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
                Array.Sort(arr);
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
            Array.Sort(arr);
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




        
    }
}
