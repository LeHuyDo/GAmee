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
    public partial class Level7 : PrefabLevel
    {
        private int currentHour;
        private int answer = 0;

        public Level7()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if(answer == currentHour)
                RightAnswer(EventArgs.Empty);
            else
                WrongAnswer(EventArgs.Empty);
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            answer--;
            UpdateTextbox();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            answer++;
            UpdateTextbox();
        }

        private void UpdateTextbox()
        {
            textBox1.Text = answer.ToString();
        }

        private void Level7_Load(object sender, EventArgs e)
        {
            suggestionText = "Chú ý mấy giờ rồi";
            answerText = "Bây giờ là " + DateTime.Now;

            currentHour = DateTime.Now.Hour;
        }
    }
}
