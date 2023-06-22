using System;
using System.Drawing;
using System.Windows.Forms;

namespace Number_Blink_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Counter = 0;
        public int CountRightAnswers = 0;
        public int CountWrongAnswers = 0;
        private string HiddenNumber = "";

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbDigits.Text)
            {

                case "4":
                    Counter = 2;
                    lblTime.Text = Counter.ToString() + "S";
                    break;
                case "5":
                    Counter = 4;
                    lblTime.Text = Counter.ToString() + "S";

                    break;
                case "6":
                    Counter = 6;
                    lblTime.Text = Counter.ToString() + "S";

                    break;
                case "7":
                    Counter = 8;
                    lblTime.Text = Counter.ToString() + "S";

                    break;
                case "8":
                    Counter = 10;
                    lblTime.Text = Counter.ToString() + "S";

                    break;
                case "9":
                    Counter = 12;
                    lblTime.Text = Counter.ToString() + "S";

                    break;
                case "10":
                    Counter = 14;
                    lblTime.Text = Counter.ToString() + "S";

                    break;
                default:
                    Counter = 2;
                    lblTime.Text = Counter.ToString() + "S";

                    break;


            }

        }

        private void RandomNumber()
        {
            Random rnd = new Random();

            switch (cbDigits.Text)
            {

                case "4":
            lblNumber.Text = rnd.Next(1000, 9000).ToString();
                    Counter = 2;
                    break;
                case "5":
            lblNumber.Text = rnd.Next(10000, 99000).ToString();
                    Counter = 4;
                    break;
                case "6":
             lblNumber.Text = rnd.Next(100000, 999000).ToString();
                    Counter = 6;
                    break;
                case "7":
              lblNumber.Text = rnd.Next(1000000, 9000000).ToString();
                    Counter = 8;
                    break;
                case "8":
              lblNumber.Text = rnd.Next(100000000, 999000000).ToString();
                    Counter = 10;
                    break;
                case "9":
            //  lblNumber.Text = rnd.Next(1000000000, 999999).ToString();
                    Counter = 12;
                    break;
                    case "10":
          //    lblNumber.Text = rnd.Next(1000000000, 9000).ToString();
                    Counter = 14;
                    break;
                default:
              lblNumber.Text = rnd.Next(1000, 9000).ToString();
                    Counter = 2;
                    break;
            }


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            RandomNumber();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbDigits.SelectedIndex = 0;
            lblTime.Text = "2S";
        }

        private void ShowButtons()
        {
            btnZero.Visible = true;
            btnOne.Visible = true;
            btnTwo.Visible = true;
            btnThree.Visible = true;
            btnFour.Visible = true;
            btnFive.Visible = true;
            btnSix.Visible = true;
            btnSeven.Visible = true;
            btnEight.Visible = true;
            btnNine.Visible = true;
            btnClear.Visible = true;
        }

      
       private void timer1_Tick(object sender, EventArgs e)
        {
            Counter--;

            if(Counter == 0)
            {
                timer1.Enabled = false;
                HiddenNumber = lblNumber.Text;
                lblNumber.Text = "?";
                ShowButtons();

            }

                lblTime.Text = Counter.ToString() + "S";

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (HiddenNumber == lblGuess.Text) {

                lblNumber.Text = HiddenNumber;
                groupBox1.BackColor = Color.Green;
                groupBox2.BackColor = Color.Green;
                CountRightAnswers++;
                MessageBox.Show("True Answer", "True",MessageBoxButtons.OK);
            }
            else
            {
                lblNumber.Text = HiddenNumber;
                groupBox1.BackColor = Color.Red;
                groupBox2.BackColor = Color.Red;
                CountWrongAnswers++;
                MessageBox.Show("Wrong Answer", "Wrong", MessageBoxButtons.OK);
            }

            lblNumber.Text = "";
            lblGuess.Text = "";
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;


        }

        private void AddNumbers(Button btn)
        {
            lblGuess.Text += btn.Tag.ToString();
        }

        private void button_Click(object sender, EventArgs e)
        {
            AddNumbers((Button) sender);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblGuess.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmResults frm = new FrmResults(CountRightAnswers, CountWrongAnswers);

            frm.ShowDialog();

            

        }
    }
}
