using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpret_Interface
{
    public partial class Form_File : Form
    {
        public Form_File()
        {
            InitializeComponent();
        }

        private void Button_Receive_Click(object sender, EventArgs e)
        {

        }

        private void Button_Send_Click(object sender, EventArgs e)
        {

        }

        public void SetText(string text)
        {
            Text_FileContents.Text = text;
        }

        public void SetDropdown(DataType type)
        {
            Dropdown_DataType.Text = type.ToString();
        }

        public enum DataType
        {
            Waypoints,
            Routes,
            Tracks
        }
    }
}
