using System;
using System.Windows.Forms;
using System.IO;

namespace Interpret_Interface
{
    public partial class Form_Main : Form
    {
        private int childFormNumber = 1;

        public Form_Main()
        {
            InitializeComponent();
        }

        // File Tools

        // New
        private void NewFile_Click(object sender, EventArgs e)
        {
            Form childForm = new Form_File
            {
                MdiParent = this,
                Text = "new " + childFormNumber++
            };
            childForm.Show();
        }

        // Open
        private void Open_FromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "Text Files|*.txt|All Files|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pathString = openFileDialog.FileName;

                Form_File childForm = new()
                {
                    MdiParent = this,
                    Text = pathString
                };
                childForm.Show();

                string fileContent = File.ReadAllText(pathString);
                childForm.SetText(pathString, fileContent);

                StatusHandler($"Opened '{Path.GetFileName(pathString)}'");
            }
        }

        // Save
        private void Save_ToFile_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Form_File childForm)
            {
                (string pathString, string fileContents) = childForm.GetText();

                if (File.Exists(pathString))
                {
                    File.WriteAllText(pathString, fileContents);

                    childForm.Text = pathString;

                    if (File.Exists(pathString))
                    {
                        StatusHandler($"Saved '{Path.GetFileName(pathString)}'");
                    }
                    else
                    {
                        StatusHandler($"Error saving '{Path.GetFileName(pathString)}'");
                    }
                }
                else
                {
                    SaveAsFile_Click(null, null);
                }
            }
        }

        private void SaveAsFile_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Form_File childForm)
            {
                (_, string fileContents) = childForm.GetText();

                SaveFileDialog saveFileDialog = new()
                {
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                    Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
                };
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string pathString = saveFileDialog.FileName;

                    File.WriteAllText(pathString, fileContents);

                    childForm.Text = pathString;

                    if (File.Exists(pathString))
                    {
                        StatusHandler($"Saved '{Path.GetFileName(pathString)}'");
                    }
                    else
                    {
                        StatusHandler($"Error saving '{Path.GetFileName(pathString)}'");
                    }
                }
            }
        }

        private void StatusHandler(string status)
        {
            Text_Status.Text = status;

            return;
        }

        // Close
        private void CloseFile_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Form_File childForm)
            {
                childForm.Close();
            }
        }

        // Exit Program
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Edit Tools
        
        // Cut
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Form_File childForm)
            {
                childForm.Cut();
            }
        }

        // Copy
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Form_File childForm)
            {
                childForm.Copy();
            }
        }

        // Paste
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Form_File childForm)
            {
                childForm.Paste();
            }
        }

        // Window Tools

        // Cascade
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        // Tile Vertically
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        // Tile Horizontally
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        // Arrange Icons
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        // Close All Windows
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        // Help Tools

        // About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Form_About
            {
                MdiParent = this
            };
            childForm.Show();
        }
    }
}
