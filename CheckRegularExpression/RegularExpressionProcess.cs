using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CheckRegularExpression
{
    class RegularExpressionProcess
    {
        private String _regularExpression = String.Empty;
        private String _sourceText = String.Empty;
        private bool _register;
        private bool _multiline;

        public string RegularExpression
        {
            get { return _regularExpression; }
            set { _regularExpression = value; }
        }

        public string SourceText
        {
            get { return _sourceText; }
            set { _sourceText = value; }
        }

        public bool Register
        {
            get { return _register; }
            set { _register = value; }
        }

        public bool Multiline
        {
            get { return _multiline; }
            set { _multiline = value; }
        }

        public void Process(ListBox listBox)
        {
            RegexOptions options = RegexOptions.None;
            if (Register) options = RegexOptions.IgnoreCase;
            if (Multiline) options = options | RegexOptions.Multiline;
            ListBox.ObjectCollection newCollection = new ListBox.ObjectCollection(listBox);

            Regex regex = new Regex(_regularExpression, options);
            if (regex.IsMatch(_sourceText))
            {
                MatchCollection matches = regex.Matches(_sourceText);
                foreach (var item in matches)
                {
                    newCollection.Add(item);
                }
            }
            else
            {
                MessageBox.Show(@"Совпадений не найдено!", @"ошибка!");
            }
        }
    }
}
