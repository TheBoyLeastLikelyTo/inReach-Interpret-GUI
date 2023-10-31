using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Windows.Input;

namespace Interpret_Interface
{
    public partial class Form_Main : Form
    {
        private int childFormNumber = 0;

        private Stack<ICommand> undoStack = new Stack<ICommand>();
        private Stack<ICommand> redoStack = new Stack<ICommand>();

        public Form_Main()
        {
            InitializeComponent();
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            Form childForm = new Form_File
            {
                MdiParent = this,
                Text = "new " + childFormNumber++
            };
            childForm.Show();
        }

        private void CloseFile_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Form_File childForm)
            {
                childForm.Close();
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Form_File childForm)
            {
                childForm.Cut();
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Form_File childForm)
            {
                childForm.Copy();
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Form_File childForm)
            {
                childForm.Paste();
            }
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Open_FromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "Text Files|*.txt|All Files|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;

                Form_File childForm = new Form_File
                {
                    MdiParent = this,
                    Text = Path.GetFileName(fileName)
                };
                childForm.Show();

                string fileContent = File.ReadAllText(fileName);
                childForm.SetText(fileContent);
            }
        }

        private void Save_ToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;

                if (ActiveMdiChild is Form_File childForm)
                {
                    string fileContents = childForm.GetText();
                    File.WriteAllText(FileName, fileContents);

                    childForm.Text = Path.GetFileName(FileName);
                }
            }
        }
    }
}
