using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumberGame
{
    public partial class MainForm : Form
    {
        int computerNumber = 0;
        int playerNumber = 0;
        int tries = 0;
        Random rnd = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (cbLevelRange.SelectedIndex == 0)
            {
                computerNumber = rnd.Next(1, 11);
            }
            else if (cbLevelRange.SelectedIndex == 1)
            {
                computerNumber = rnd.Next(1, 51);
            }
            else if (cbLevelRange.SelectedIndex == 2)
            {
                computerNumber = rnd.Next(1, 101);
            }
            else
            {
                MessageBox.Show("You must enter a range!", "Enter",MessageBoxButtons.OK);
                return;
            }

            lblGuessTheNumber.Visible = true;
            tbNumber.Visible = true;
            btnCheckTheNumber.Visible = true;
            lblTriesText.Visible = true;
            lblTries.Visible = true;
            pbUpDown.Visible = true;
            lblNote.Visible = true;

            btnPlay.Enabled = false;

            if (cbLevelRange.SelectedIndex == 0)
            {
                computerNumber = rnd.Next(1, 11);
            }
            else if (cbLevelRange.SelectedIndex == 1)
            {
                computerNumber = rnd.Next(1, 51);
            }
            else if (cbLevelRange.SelectedIndex == 2)
            {
                computerNumber = rnd.Next(1, 101);
            }
        }

        private void btnCheckTheNumber_Click(object sender, EventArgs e)
        {
            if (tries < 9)
            {
                if (int.TryParse(tbNumber.Text, out playerNumber))
                {

                    if (playerNumber == computerNumber)
                    {
                        pbThumbsUpDown.Visible = true;
                        pbThumbsUpDown.Image = Properties.Resources.thumbs_up;

                        MessageBox.Show("You win! Cheers ;) !", "Congrats!", MessageBoxButtons.OK);
                        DialogResult Result = MessageBox.Show("Play again?", "One more game?", MessageBoxButtons.YesNo);

                        if (Result == DialogResult.Yes)
                        {
                            cbLevelRange.SelectedIndex = -1;
                            pbThumbsUpDown.Visible = false;
                            pbUpDown.Visible = false;
                            tbNumber.Text = "";
                            tbNumber.Visible = false;
                            lblGuessTheNumber.Visible = false;
                            lblTriesText.Visible = false;
                            lblTries.Visible = false;
                            btnCheckTheNumber.Visible = false;
                            lblNote.Visible = false;
                            lblUp.Visible = false;
                            lblDown.Visible = false;
                            tries = 0;
                            lblTries.Text = "0";
                            btnPlay.Enabled = true;

                        }
                        else if (Result == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        if (playerNumber > computerNumber)
                        {
                            pbUpDown.Visible = true;
                            pbUpDown.Image = Properties.Resources.down;
                            lblDown.Visible = true;
                            lblUp.Visible = false;
                            tries++;
                            lblTries.Text = tries.ToString();
                            tbNumber.Text = "";
                        }
                        else if (playerNumber < computerNumber)
                        {
                            pbUpDown.Visible = true;
                            pbUpDown.Image = Properties.Resources.up;
                            lblUp.Visible = true;
                            lblDown.Visible = false;
                            tries++;
                            lblTries.Text = tries.ToString();
                            tbNumber.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please, enter number!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbNumber.Text = "";
                }
            }
            else
            {
                lblTries.Text = tries.ToString();
                pbUpDown.Visible = false;
                lblUp.Visible = false;
                lblDown.Visible = false;
                pbThumbsUpDown.Visible = true;
                pbThumbsUpDown.Image = Properties.Resources.thumbs_down;

                MessageBox.Show("Sorry, you lost... :( ", "Sorry", MessageBoxButtons.OK);
                MessageBox.Show("The right number was:" + computerNumber, "Right number", MessageBoxButtons.OK);
                DialogResult Result = MessageBox.Show("One more game?", "Again?", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    cbLevelRange.SelectedIndex = -1;
                    lblGuessTheNumber.Visible = false;
                    tbNumber.Visible = false;
                    lblTriesText.Visible = false;
                    lblTries.Visible = false;
                    lblTries.Text = "";
                    tries = 0;
                    btnCheckTheNumber.Visible = false;
                    pbUpDown.Visible = false;
                    lblUp.Visible = false;
                    lblDown.Visible = false;
                    pbThumbsUpDown.Visible = false;
                    lblNote.Visible = false;

                    btnPlay.Enabled = true;
                }
                else if(Result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }
    }
}
