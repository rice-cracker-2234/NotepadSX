using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadSX
{
    public partial class AboutNotepadSX : Form
    {
        public AboutNotepadSX()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Path.Combine(Environment.SystemDirectory, "notepad.exe"));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/khoaScript/NotepadSX");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
