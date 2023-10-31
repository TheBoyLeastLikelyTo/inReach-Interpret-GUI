using System;
using System.Windows.Forms;

namespace Interpret_Interface
{
    public partial class Form_File : Form
    {
        public Form_File()
        {
            InitializeComponent();
        }

        public File currentFile;

        public void SetText(string text)
        {
            File file = new(Text_FileContents)
            {
                Text = text
            };

        }

        public string GetText()
        {
            return new File(Text_FileContents).Text;
        }

        public enum DataType
        {
            Waypoints,
            Routes,
            Tracks
        }

        public struct File
        {
            private RichTextBox richTextBox;

            public File(RichTextBox rtb)
            {
                richTextBox = rtb;
            }

            public readonly string Text
            {
                get
                {
                    return richTextBox.Text;
                }
                set
                {
                    richTextBox.Text = value;
                }
            }
        }

        public void Cut()
        {
            if (ActiveControl is TextBox Text_FileContents)
            {
                if (!Text_FileContents.SelectionLength.Equals(0))
                {
                    Clipboard.SetText(Text_FileContents.SelectedText);
                    Text_FileContents.SelectedText = "";
                }
            }
        }

        public void Copy()
        {
            if (ActiveControl is TextBox Text_FileContents)
            {
                if (!Text_FileContents.SelectionLength.Equals(0))
                {
                    Clipboard.SetText(Text_FileContents.SelectedText);
                }
            }
        }

        public void Paste()
        {
            if (ActiveControl is TextBox Text_FileContents)
            {
                Text_FileContents.Paste(Clipboard.GetText());
            }
        }
    }
}
