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
    public partial class SuggestionTable : UserControl
    {
        public SuggestionTable()
        {
            InitializeComponent();
        }

        public void SetSuggestionText(string text)
        {
            label_Suggestion.Text = text;
        }

        private void btn_PayForSuggestion_Click(object sender, EventArgs e)
        {
            PayToSuggestion?.Invoke(this, e);
        }

        public void panel_SuggestionText_Show()
        {
            panel_SuggestionText.Show();
        }

        #region Thêm một số Event
        [Browsable(true)]
        [Category("CustomAction")]
        [Description("PayToSuggestion")]
        public event EventHandler PayToSuggestion;

        #endregion
    }
}
