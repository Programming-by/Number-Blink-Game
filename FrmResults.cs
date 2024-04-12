using System;
using System.Windows.Forms;

namespace Number_Blink_Game
{
    public partial class FrmResults : Form
    {
        public FrmResults(int CountRightAnswers ,int CountWrongAnswers)
        {
            InitializeComponent();
            lblRightAnswers.Text = CountRightAnswers.ToString();
            lblWrongAnswers.Text = CountWrongAnswers.ToString();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
