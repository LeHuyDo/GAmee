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
    public partial class Level1 : PrefabLevel
    {
        public Level1()
        {
            InitializeComponent();
        }

        private void Level1_Load(object sender, EventArgs e)
        {
            suggestionText = "Chú ý là hoa quả nhé :3";

            ControlExtension.Draggable(btn_QuaDua, true);
            ControlExtension.Draggable(btn_CaRot, true);
            ControlExtension.Draggable(btn_QuaTao, true);
        }

        private void btn_QuaDua_MouseUp(object sender, MouseEventArgs e)
        {
            Point centerQuaDua = GameLogic.CenterOfControl(btn_QuaDua.Location, btn_QuaDua.Size);

            if (GameLogic.IsInArea(centerQuaDua, btn_Xo.Location, btn_Xo.Size))
            {
                btn_QuaDua.Hide();
                CheckResult(e);
            }
        }

        private void btn_CaRot_MouseUp(object sender, MouseEventArgs e)
        {
            Point centerCaRot = GameLogic.CenterOfControl(btn_CaRot.Location, btn_CaRot.Size);

            if (GameLogic.IsInArea(centerCaRot, btn_Xo.Location, btn_Xo.Size))
            {
                btn_CaRot.Hide();
                CheckResult(e);
            }
        }

        private void btn_QuaTao_MouseUp(object sender, MouseEventArgs e)
        {
            Point centerQuaTao = GameLogic.CenterOfControl(btn_QuaTao.Location, btn_QuaTao.Size);

            if (GameLogic.IsInArea(centerQuaTao, btn_Xo.Location, btn_Xo.Size))
            {
                btn_QuaTao.Hide();
                CheckResult(e);
            }
        }

        private void CheckResult(EventArgs e)
        {
            if (btn_QuaDua.Visible == false && btn_QuaTao.Visible == false)
            {
                if (btn_CaRot.Visible == true)
                {
                    RightAnswer(EventArgs.Empty);
                }
                else
                {
                    WrongAnswer(EventArgs.Empty);
                }
            }
        }
    }
}
