using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME
{
    public partial class Level6 : PrefabLevel
    {
        int answerNumber = 0;

        public Level6()
        {
            InitializeComponent();
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            answerNumber--;
            UpdateTextbox();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            answerNumber++;
            UpdateTextbox();
        }

        private void UpdateTextbox()
        {
            textBox1.Text = answerNumber.ToString();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (answerNumber == 12)
                RightAnswer(EventArgs.Empty);
            else
                WrongAnswer(EventArgs.Empty);
        }

        private void Level6_Load(object sender, EventArgs e)
        {
            suggestionText = "Ngày 28 thì xuất hiện ở tháng nào nhỉ ?";
            answerText = "Tháng nào mà chả có 28 ngày đúng không !";
        }
    }
}
