using System;
using System.Windows.Forms;

namespace Number_Blink_Game
{
    public partial class FrmResults : Form
    {

        int _CountRight;
        int _CountWrong;
        public FrmResults(int CountRight ,int CountWrong)
        {
            InitializeComponent();

            _CountRight = CountRight;
            _CountWrong = CountWrong;

        }

        private void FrmResults_Load(object sender, EventArgs e)
        {
            lblRightAnswers.Text = _CountRight.ToString();
            lblWrongAnswers.Text = _CountWrong.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
