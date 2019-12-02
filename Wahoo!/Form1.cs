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
        public Form1()
        {
            InitializeComponent();
        }

        int totalScore = 0;
        int itemScore = 0;

        int[] dieVal = new int[5];

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
                    break;
                }
            }

            sum *= count;
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
                    break;
                }
            }

            sum *= count;
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




    }
}
