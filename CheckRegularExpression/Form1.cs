using System;
using System.Windows.Forms;

namespace CheckRegularExpression
{
    public partial class CheckRegularExpression : Form
    {
        RegularExpressionProcess regularExpressionProcess = new RegularExpressionProcess();
        public CheckRegularExpression()
        {
            InitializeComponent();
        }

        private void check_Click(object sender, EventArgs e)
        {
            matchesListBox.Items.Clear();
            regularExpressionProcess.RegularExpression = regularExpression.Text;
            regularExpressionProcess.SourceText = text.Text;
            regularExpressionProcess.Register = registerCheckBox.Checked;
            regularExpressionProcess.Multiline = multilineSearchCheckBox.Checked;
            regularExpressionProcess.Process(matchesListBox);
        }
    }
}
