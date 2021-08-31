using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sxlib;
using sxlib.Specialized;
using sxlib.Static;

namespace NotepadSX
{
    public partial class NotepadUI : Form
    {
        public string CurrentFileName;
        public string CurrentFullPath;
        public string FileText;
        public bool IsNewFile;
        public bool IsUnsaved;

        public SxLibWinForms Lib;

        public NotepadUI()
        {
            Lib = SxLib.InitializeWinForms(this, Environment.CurrentDirectory);
            Lib.LoadEvent += Lib_LoadEvent;
            Lib.AttachEvent += Lib_AttachEvent;

            Lib.Load();

            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Path.Combine(Environment.SystemDirectory, "notepad.exe"));
            SetFile("");
        }

        public void SetFile(string path)
        {
            CurrentFullPath = path;
            CurrentFileName = CurrentFullPath == "" ? "Untitled.txt" : Path.GetFileName(path);

            if (string.IsNullOrWhiteSpace(path))
            {
                FileText = "";
                IsNewFile = true;
            }

            else
            {
                FileText = File.ReadAllText(CurrentFullPath, Encoding.Default);
                IsNewFile = false;
            }

            textBox1.Text = FileText;
            FileText = textBox1.Text;

            textBox1.ClearUndo();
            UpdateUI();
        }

        public void UpdateUI()
        {
            IsUnsaved = textBox1.Text != FileText;
            Text = IsUnsaved ? $"*{CurrentFileName} - Notepad" : $"{CurrentFileName} - Notepad";

            undoItem.Enabled = textBox1.CanUndo;
            cutItem.Enabled = copyItem.Enabled = delItem.Enabled = !string.IsNullOrEmpty(textBox1.SelectedText);
            pasteItem.Enabled = textBox1.CanPaste(DataFormats.GetFormat(DataFormats.Text));
        }

        public void Lib_LoadEvent(SxLibBase.SynLoadEvents events, object param)
        {
            var toString = "";

            string str = events.ToString();
            string[] each = str.Split('_');
            for (int i = 0; i != each.Length; i++)
            {
                var stringBuilder = new StringBuilder(each[i].ToLower());
                stringBuilder[0] = char.ToUpper(stringBuilder[0]);

                toString += stringBuilder.ToString();
                if (i < each.Length - 1) toString += " ";
            }

            loadLabel.Text = toString;
        }

        public bool IsAttached;
        public void Lib_AttachEvent(SxLibBase.SynAttachEvents events, object param)
        {
            if (events == SxLibBase.SynAttachEvents.ALREADY_INJECTED ||
                events == SxLibBase.SynAttachEvents.READY) IsAttached = true;
            else IsAttached = false;

            var toString = "";

            string str = events.ToString();
            string[] each = str.Split('_');
            for (int i = 0; i != each.Length; i++)
            {
                var stringBuilder = new StringBuilder(each[i].ToLower());
                stringBuilder[0] = char.ToUpper(stringBuilder[0]);

                toString += stringBuilder.ToString();
                if (i < each.Length - 1) toString += " ";
            }

            attachLabel.Text = toString;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void textBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            zoomLabel.Text = $"{textBox1.ZoomFactor * 100}%";
        }

        private void textBox1_SelectionChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void newItem_Click(object sender, EventArgs e)
        {
            SetFile("");
        }

        private void newWindowItem_Click(object sender, EventArgs e)
        {
            Process.Start(Assembly.GetEntryAssembly().Location);
        }

        private void openItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Title = "Open",
                FilterIndex = 0,
                Filter = "Text Documents (*.txt)|*.txt|Lua Scripts (*.lua)|*.lua|All Files (*.*)|*.*",
                RestoreDirectory = true
            };

            if (dialog.ShowDialog() == DialogResult.OK)
                SetFile(dialog.FileName);
        }

        private void saveItem_Click(object sender, EventArgs e)
        {
            string fileName = CurrentFullPath;

            if (IsNewFile)
            {
                var dialog = new SaveFileDialog
                {
                    Title = "Save",
                    FilterIndex = 0,
                    Filter = "Text Documents (*.txt)|*.txt|Lua Scripts (*.lua)|*.lua|All Files (*.*)|*.*",
                    RestoreDirectory = true,
                    FileName = CurrentFileName
                };

                if (dialog.ShowDialog() != DialogResult.OK) return;
                fileName = dialog.FileName;
            }

            File.WriteAllText(fileName, textBox1.Text);
            SetFile(fileName);
        }

        private void saveAsItem_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                Title = "Save",
                FilterIndex = 0,
                Filter = "Text Documents (*.txt)|*.txt|Lua Scripts (*.lua)|*.lua|All Files (*.*)|*.*",
                RestoreDirectory = true,
                FileName = CurrentFileName
            };

            if (dialog.ShowDialog() != DialogResult.OK) return;
            File.WriteAllText(dialog.FileName, textBox1.Text);
            SetFile(dialog.FileName);
        }

        private void exitItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void cutItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copyItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pasteItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void delItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = "";
        }

        private void selectAllItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void timeDateItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = DateTime.Now.ToString("h:mm tt MM/dd/yyyy");
        }

        private void wordWrapItem_Click(object sender, EventArgs e)
        {
            wordWrapItem.Checked = textBox1.WordWrap = !wordWrapItem.Checked;
        }

        private void fontItem_Click(object sender, EventArgs e)
        {
            var dialog = new FontDialog
            {
                Font = textBox1.Font,
                ShowHelp = true,
                ShowEffects = false,
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = dialog.Font;
            }
        }

        private void statusBarItem_Click(object sender, EventArgs e)
        {
            statusBarItem.Checked = statusStrip.Visible = !statusBarItem.Checked;
        }

        private void viewHelpItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://synapsesupport.io");
        }

        private void aboutNotepadSXItem_Click(object sender, EventArgs e)
        {
            new AboutNotepadSX().ShowDialog();
        }

        private void executeItem_Click(object sender, EventArgs e)
        {
            if (IsAttached)
                Lib.Attach();
            else
                MessageBox.Show("Please attach Synapse X.", "NotepadSX", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void attachItem_Click(object sender, EventArgs e)
        {
            if (Lib.Ready())
                Lib.Execute(textBox1.Text);
            else
                MessageBox.Show("Please wait for Synapse X to finish loading.", "NotepadSX", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
