using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkubakSlot001
{
    public partial class frmSlotMachine : Form
    {
        public frmSlotMachine()
        {
            InitializeComponent();
        }
        //money set up
        decimal mydecBalance = 1000;
        decimal mydecWager = 200;
    
        //Variables for which window to flash
        private bool myblnFlash1 = false;
        private bool myblnFlash2 = false;
        private bool myblnFlash3 = false;

        private void ResetGame()
        {
            //this will reset game to original
            mydecBalance = 1000;
            mydecWager = 200;
            DisplayScreen();
        }

        private void DisplayScreen()
        {
            //storage update
            if (mydecBalance > 1000)//full when over 1000
            {
                picStorage3.Visible = true;

            }
            else if (mydecBalance < 300)//empty when below 300
            {
                picStorage1.Visible = true;
            }
            else//else medium
            {
                picStorage2.Visible = true;
                picStorage1.Visible = false;
                picStorage3.Visible = false;
            }

            //if user goes broke
            if (mydecBalance <= 0)
            {
                MessageBox.Show("Chief! We need more Gold! Let's reset and try again.");
                ResetGame();
            }
                        
            //Avoid over betting
            if (mydecWager > mydecBalance)
            {
                mydecWager = mydecBalance;
            }

            btnBet200.Visible = mydecBalance >= 200;

            //this will dislplay the money on the screen
            lblBalance.Text = mydecBalance.ToString("C");
            lblWager.Text = mydecWager.ToString("C");
            lblWinnings.Text = "";
        }
        
        private Random myRnd = new Random();
        private bool StopIt()
        {
            int intCheckNumber = myRnd.Next(7);
            return intCheckNumber == 3;
        }

        private void tmrWindow1_Tick(object sender, EventArgs e)
        {
            PictureChange(lblCounter1, picWindow1);
            if(StopIt())
            {
                tmrWindow1.Enabled = false;
            }
        }

        private void PictureChange(Label lbl, PictureBox picToChange)
        {
            int intCounter = int.Parse(lbl.Text);
            intCounter++;
            if (intCounter == 8)
            {
                intCounter = 1;
            }
            lbl.Text = intCounter.ToString();

            PictureBox pic = (PictureBox)this.Controls.Find("pic" + intCounter.ToString(), true)[0];

            picToChange.BackgroundImage = pic.BackgroundImage;
        }

        private void btnLever_Click(object sender, EventArgs e)
        {
            mydecBalance -= mydecWager;
            btnLever.Enabled = false;
            tmrWindow1.Enabled = true;
            tmrWindow2.Enabled = true;
            tmrWindow3.Enabled = true;

        }

        private void pic1_Click(object sender, EventArgs e)
        {

        }

        private void tmrWindow2_Tick(object sender, EventArgs e)
        {
            PictureChange(lblCounter2, picWindow2);
            if (tmrWindow1.Enabled == false && StopIt())
            {
                tmrWindow2.Enabled = false;
            }
        }

        private void tmrWindow3_Tick(object sender, EventArgs e)
        {
            PictureChange(lblCounter3, picWindow3);
            if (tmrWindow2.Enabled == false && StopIt())
            {
                tmrWindow3.Enabled = false;
                CheckWin();
            }
        }
        private void CheckWin()
        {
            //funtion to check if numbers on screen match. 
            btnLever.Enabled = true; //allow to bet again
            myblnFlash1 = false;
            myblnFlash2 = false;
            myblnFlash3 = false;

            string strWinningMessage = "";

            if (lblCounter1.Text == lblCounter2.Text && lblCounter2.Text == lblCounter3.Text)
            {
                //All three are the same? Big Winner
                myblnFlash1 = true;
                myblnFlash2 = true;
                myblnFlash3 = true;
                mydecBalance += mydecWager * 6;
                strWinningMessage = "Winner Winner Chicken Dinner";

                //superjackpot
                if (lblCounter1.Text == "3")
                {
                    mydecBalance += mydecWager * 10;
                }
            }
            else if (lblCounter1.Text == lblCounter2.Text)
            {
                //only first two
                myblnFlash1 = true;
                myblnFlash2 = true;
                mydecBalance += mydecWager;
                strWinningMessage = "Nice! " + mydecWager.ToString("C");
                if (lblCounter1.Text == "5")
                {
                    mydecBalance += mydecWager * 2;
                    strWinningMessage = "Bonus Loot! " + (mydecWager * 2).ToString("C");
                }
            }
            else if (lblCounter1.Text == lblCounter3.Text)
            {
                //1 and 3
                myblnFlash1 = true;
                myblnFlash3 = true;
                mydecBalance += mydecWager;
                strWinningMessage = "Nice! " + mydecWager.ToString("C");
                if (lblCounter1.Text == "5")
                {
                    mydecBalance += mydecWager * 2;
                    strWinningMessage = "Bonus Loot! " + (mydecWager * 2).ToString("C");
                }

            }
            else if (lblCounter2.Text == lblCounter3.Text)
            {
                //2 and 3
                myblnFlash2 = true;
                myblnFlash3 = true;
                mydecBalance += mydecWager * 2;
                strWinningMessage = "Nice! " + mydecWager.ToString("C");
                if (lblCounter1.Text == "5")
                {
                    mydecBalance += mydecWager * 2;
                    strWinningMessage = "Bonus Loot! " + (mydecWager * 2).ToString("C");
                }
            }
            else
            {
                //big loser
            }                
            tmrFlasher.Enabled = true;  //Begin flashing lights
            DisplayScreen();
            lblWinnings.Text = strWinningMessage;
        }
        private void pic3_Click(object sender, EventArgs e)
        {

        }

        private void pic7_Click(object sender, EventArgs e)
        {

        }

        private void tmrFlasher_Tick(object sender, EventArgs e)
        {
            if(picFlasher1.BackColor == Color.Crimson)
            {
                picFlasher1.BackColor = Color.LightSeaGreen;
            }
            else if(picFlasher1.BackColor == Color.LightSeaGreen)
            {
                picFlasher1.BackColor = Color.LavenderBlush;
            }
            else
            {
                picFlasher1.BackColor = Color.Crimson;
            }
            picFlasher2.BackColor = picFlasher1.BackColor;
            picFlasher3.BackColor = picFlasher1.BackColor;

            if (StopIt())
            {
                tmrFlasher.Enabled = false;
                myblnFlash1 = false;
                myblnFlash2 = false;
                myblnFlash3 = false;
            }
            
            //this sets the flashers for each window
            picFlasher1.Visible = myblnFlash1;
            picFlasher2.Visible = myblnFlash2;
            picFlasher3.Visible = myblnFlash3;
        }


        private void frmSlotMachine_Load(object sender, EventArgs e)
        {
            DisplayScreen();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btnBet100_Click(object sender, EventArgs e)
        {
            mydecWager = 100;
            DisplayScreen();
        }

        private void btnBet300_Click(object sender, EventArgs e)
        {
            mydecWager = 200;
            DisplayScreen();
        }

        private void btnBetMax_Click(object sender, EventArgs e)
        {
            mydecWager = mydecBalance;
            DisplayScreen();
        }

        private void lblWager_Click(object sender, EventArgs e)
        {

        }

        private void picFlasher2_Click(object sender, EventArgs e)
        {

        }

        private void lblWinnings_Click(object sender, EventArgs e)
        {

        }

        private void lblBet_Click(object sender, EventArgs e)
        {

        }

        private void picStorageEmpty_Click(object sender, EventArgs e)
        {
       
        }

        private void picStorage_Click(object sender, EventArgs e)
        {
          
        }

        private void picStorageMedium_Click(object sender, EventArgs e)
        {
           
        }

        private void picStorage_Click_1(object sender, EventArgs e)
        {
            
        }

        private void picStorageFull_Click(object sender, EventArgs e)
        {
            
        }

        private void pic4_Click(object sender, EventArgs e)
        {

        }
    }
}
