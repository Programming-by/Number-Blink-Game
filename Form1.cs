using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Number_Blink_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Random rnd = new Random();

        private int Counter = 0;
        public int NumberOfRightAnswers = 0;
        public int NumberOfWrongAnswers = 0;
        private string HiddenNumber = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            cbDigits.SelectedIndex = 0;
            lblTime.Text = "2 S";
        }
        private void RandomNumber(int min , int max)
        {
            lblNumber.Text = rnd.Next(min, max).ToString();
        }
        private void RandomNumber()
        {
            switch (cbDigits.SelectedIndex)
            {
                case 0: 
                    RandomNumber(1000, 10000);
                    break;
                    case 1:
                    RandomNumber(10000, 100000);
                    break;
                case 2:
                    RandomNumber(100000, 1000000);
                    break;
                case 3:
                    RandomNumber(1000000, 10000000);
                    break;
                case 4:
                    RandomNumber(10000000, 100000000);
                    break;

            }
        }
        private void GenerateNumber()
        {
            Counter = GetCounter(cbDigits.SelectedIndex);
            lblTime.Text = Counter + " S";
            lblNumber.Text = lblExpectedNumber.Text = "?";
            timer1.Start();
            RandomNumber();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            GenerateNumber();
            btnShow.Enabled = false;
        }
       private void timer1_Tick(object sender, EventArgs e)
        {
            --Counter;
            lblTime.Text = Counter + " S";

            if (Counter == 0)
            {
                timer1.Stop();
                HiddenNumber = lblNumber.Text;
                lblNumber.Text = "?";
                lblExpectedNumber.Text = "";
                lblTime.Text = Counter + " S";
                ShowButtons(true);
            }
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            lblNumber.Text = HiddenNumber;
            if (HiddenNumber == lblExpectedNumber.Text)
            {
                gbNumber.BackColor = gbExpectedNumber.BackColor = Color.DarkCyan;
                NumberOfRightAnswers++;
                MessageBox.Show("True Answer", "True",MessageBoxButtons.OK);
            }
            else
            {
                gbNumber.BackColor = gbExpectedNumber.BackColor = Color.Red;
                NumberOfWrongAnswers++;
                MessageBox.Show("Wrong Answer", "Wrong", MessageBoxButtons.OK);
            }
            btnShow.Enabled = true;
            ShowButtons(false);
            lblNumber.Text = lblExpectedNumber.Text = "";
            gbNumber.BackColor = gbExpectedNumber.BackColor = Color.Transparent;
        }
        private void ShowButtons(bool isVisible)
        {
            btnZero.Visible = isVisible;
            btnOne.Visible = isVisible;
            btnTwo.Visible = isVisible;
            btnThree.Visible = isVisible;
            btnFour.Visible = isVisible;
            btnFive.Visible = isVisible;
            btnSix.Visible = isVisible;
            btnSeven.Visible = isVisible;
            btnEight.Visible = isVisible;
            btnNine.Visible = isVisible;
            btnClear.Visible = isVisible;
        }
        private void AddNumbers(Button btn)
        {
            lblExpectedNumber.Text += btn.Text.ToString();
        }
        private void button_Click(object sender, EventArgs e)
        {
            AddNumbers((Button) sender);
        }
        private short GetCounter(int index)
        {
            short[] Time = { 2, 4, 5, 6, 7 };

            return Time[index];
        }
        private void cbDigits_SelectedIndexChanged(object sender, EventArgs e)
        {
            Counter = GetCounter(cbDigits.SelectedIndex);
            lblTime.Text = Counter + " S";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblExpectedNumber.Text = "";
        }
        private void llStats_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmResults frm = new FrmResults(NumberOfRightAnswers, NumberOfWrongAnswers);

            frm.ShowDialog();
        }
    }
}
