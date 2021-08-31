
using System.Windows.Forms;

namespace NotepadSX
{
    partial class NotepadUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.zoomLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.carriageReturn = new System.Windows.Forms.ToolStripStatusLabel();
            this.attachLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.loadLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.fileMenu = new System.Windows.Forms.MenuItem();
            this.newItem = new System.Windows.Forms.MenuItem();
            this.newWindowItem = new System.Windows.Forms.MenuItem();
            this.openItem = new System.Windows.Forms.MenuItem();
            this.saveItem = new System.Windows.Forms.MenuItem();
            this.saveAsItem = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.exitItem = new System.Windows.Forms.MenuItem();
            this.editMenu = new System.Windows.Forms.MenuItem();
            this.undoItem = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.cutItem = new System.Windows.Forms.MenuItem();
            this.copyItem = new System.Windows.Forms.MenuItem();
            this.pasteItem = new System.Windows.Forms.MenuItem();
            this.delItem = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.selectAllItem = new System.Windows.Forms.MenuItem();
            this.timeDateItem = new System.Windows.Forms.MenuItem();
            this.formatMenu = new System.Windows.Forms.MenuItem();
            this.wordWrapItem = new System.Windows.Forms.MenuItem();
            this.fontItem = new System.Windows.Forms.MenuItem();
            this.viewMenu = new System.Windows.Forms.MenuItem();
            this.statusBarItem = new System.Windows.Forms.MenuItem();
            this.helpMenu = new System.Windows.Forms.MenuItem();
            this.viewHelpItem = new System.Windows.Forms.MenuItem();
            this.sendFeedbackItem = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.aboutNotepadSXItem = new System.Windows.Forms.MenuItem();
            this.synapseXItem = new System.Windows.Forms.MenuItem();
            this.executeItem = new System.Windows.Forms.MenuItem();
            this.attachItem = new System.Windows.Forms.MenuItem();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.textBox1.Size = new System.Drawing.Size(1051, 562);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "";
            this.textBox1.WordWrap = false;
            this.textBox1.SelectionChanged += new System.EventHandler(this.textBox1_SelectionChanged);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseWheel);
            // 
            // statusStrip
            // 
            this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.zoomLabel,
            this.carriageReturn,
            this.attachLabel,
            this.loadLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 540);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1051, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(431, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // zoomLabel
            // 
            this.zoomLabel.AutoSize = false;
            this.zoomLabel.BackColor = System.Drawing.Color.Transparent;
            this.zoomLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.zoomLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(45, 17);
            this.zoomLabel.Text = "100%";
            this.zoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // carriageReturn
            // 
            this.carriageReturn.AutoSize = false;
            this.carriageReturn.BackColor = System.Drawing.Color.Transparent;
            this.carriageReturn.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.carriageReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.carriageReturn.Name = "carriageReturn";
            this.carriageReturn.Size = new System.Drawing.Size(120, 17);
            this.carriageReturn.Text = "Synapse X";
            this.carriageReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // attachLabel
            // 
            this.attachLabel.AutoSize = false;
            this.attachLabel.BackColor = System.Drawing.Color.Transparent;
            this.attachLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.attachLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.attachLabel.Name = "attachLabel";
            this.attachLabel.Size = new System.Drawing.Size(200, 17);
            this.attachLabel.Text = "Not Attached";
            this.attachLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loadLabel
            // 
            this.loadLabel.AutoSize = false;
            this.loadLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.loadLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(240, 17);
            this.loadLabel.Text = "Not Loaded";
            this.loadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenu,
            this.editMenu,
            this.formatMenu,
            this.viewMenu,
            this.helpMenu,
            this.synapseXItem});
            // 
            // fileMenu
            // 
            this.fileMenu.Index = 0;
            this.fileMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.newItem,
            this.newWindowItem,
            this.openItem,
            this.saveItem,
            this.saveAsItem,
            this.menuItem6,
            this.exitItem});
            this.fileMenu.Text = "File";
            // 
            // newItem
            // 
            this.newItem.Index = 0;
            this.newItem.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.newItem.Text = "New";
            this.newItem.Click += new System.EventHandler(this.newItem_Click);
            // 
            // newWindowItem
            // 
            this.newWindowItem.Index = 1;
            this.newWindowItem.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftN;
            this.newWindowItem.Text = "New Window";
            this.newWindowItem.Click += new System.EventHandler(this.newWindowItem_Click);
            // 
            // openItem
            // 
            this.openItem.Index = 2;
            this.openItem.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.openItem.Text = "Open...";
            this.openItem.Click += new System.EventHandler(this.openItem_Click);
            // 
            // saveItem
            // 
            this.saveItem.Index = 3;
            this.saveItem.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.saveItem.Text = "Save";
            this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
            // 
            // saveAsItem
            // 
            this.saveAsItem.Index = 4;
            this.saveAsItem.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
            this.saveAsItem.Text = "Save As...";
            this.saveAsItem.Click += new System.EventHandler(this.saveAsItem_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 5;
            this.menuItem6.Text = "-";
            // 
            // exitItem
            // 
            this.exitItem.Index = 6;
            this.exitItem.Text = "Exit";
            this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.Index = 1;
            this.editMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.undoItem,
            this.menuItem2,
            this.cutItem,
            this.copyItem,
            this.pasteItem,
            this.delItem,
            this.menuItem8,
            this.selectAllItem,
            this.timeDateItem});
            this.editMenu.Text = "Edit";
            // 
            // undoItem
            // 
            this.undoItem.Index = 0;
            this.undoItem.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.undoItem.Text = "Undo";
            this.undoItem.Click += new System.EventHandler(this.undoItem_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // cutItem
            // 
            this.cutItem.Index = 2;
            this.cutItem.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.cutItem.Text = "Cut";
            this.cutItem.Click += new System.EventHandler(this.cutItem_Click);
            // 
            // copyItem
            // 
            this.copyItem.Index = 3;
            this.copyItem.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.copyItem.Text = "Copy";
            this.copyItem.Click += new System.EventHandler(this.copyItem_Click);
            // 
            // pasteItem
            // 
            this.pasteItem.Index = 4;
            this.pasteItem.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.pasteItem.Text = "Paste";
            this.pasteItem.Click += new System.EventHandler(this.pasteItem_Click);
            // 
            // delItem
            // 
            this.delItem.Index = 5;
            this.delItem.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.delItem.Text = "Delete";
            this.delItem.Click += new System.EventHandler(this.delItem_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 6;
            this.menuItem8.Text = "-";
            // 
            // selectAllItem
            // 
            this.selectAllItem.Index = 7;
            this.selectAllItem.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.selectAllItem.Text = "Select All";
            this.selectAllItem.Click += new System.EventHandler(this.selectAllItem_Click);
            // 
            // timeDateItem
            // 
            this.timeDateItem.Index = 8;
            this.timeDateItem.Shortcut = System.Windows.Forms.Shortcut.F5;
            this.timeDateItem.Text = "Time/Date";
            this.timeDateItem.Click += new System.EventHandler(this.timeDateItem_Click);
            // 
            // formatMenu
            // 
            this.formatMenu.Index = 2;
            this.formatMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.wordWrapItem,
            this.fontItem});
            this.formatMenu.Text = "Format";
            // 
            // wordWrapItem
            // 
            this.wordWrapItem.Index = 0;
            this.wordWrapItem.Text = "Word Wrap";
            this.wordWrapItem.Click += new System.EventHandler(this.wordWrapItem_Click);
            // 
            // fontItem
            // 
            this.fontItem.Index = 1;
            this.fontItem.Text = "Font...";
            this.fontItem.Click += new System.EventHandler(this.fontItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.Index = 3;
            this.viewMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.statusBarItem});
            this.viewMenu.Text = "View";
            // 
            // statusBarItem
            // 
            this.statusBarItem.Checked = true;
            this.statusBarItem.Index = 0;
            this.statusBarItem.Text = "Status Bar";
            this.statusBarItem.Click += new System.EventHandler(this.statusBarItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.Index = 4;
            this.helpMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.viewHelpItem,
            this.sendFeedbackItem,
            this.menuItem15,
            this.aboutNotepadSXItem});
            this.helpMenu.Text = "Help";
            // 
            // viewHelpItem
            // 
            this.viewHelpItem.Index = 0;
            this.viewHelpItem.Text = "View Help";
            this.viewHelpItem.Click += new System.EventHandler(this.viewHelpItem_Click);
            // 
            // sendFeedbackItem
            // 
            this.sendFeedbackItem.Enabled = false;
            this.sendFeedbackItem.Index = 1;
            this.sendFeedbackItem.Text = "Send Feedback";
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 2;
            this.menuItem15.Text = "-";
            // 
            // aboutNotepadSXItem
            // 
            this.aboutNotepadSXItem.Index = 3;
            this.aboutNotepadSXItem.Text = "About NotepadSX";
            this.aboutNotepadSXItem.Click += new System.EventHandler(this.aboutNotepadSXItem_Click);
            // 
            // synapseXItem
            // 
            this.synapseXItem.Index = 5;
            this.synapseXItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.executeItem,
            this.attachItem});
            this.synapseXItem.Text = "Synapse X";
            // 
            // executeItem
            // 
            this.executeItem.Index = 0;
            this.executeItem.Text = "Execute";
            this.executeItem.Click += new System.EventHandler(this.executeItem_Click);
            // 
            // attachItem
            // 
            this.attachItem.Index = 1;
            this.attachItem.Text = "Attach";
            this.attachItem.Click += new System.EventHandler(this.attachItem_Click);
            // 
            // NotepadUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1051, 562);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.textBox1);
            this.Menu = this.mainMenu;
            this.Name = "NotepadUI";
            this.Text = "NotepadUI";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel loadLabel;
        private System.Windows.Forms.ToolStripStatusLabel zoomLabel;
        private System.Windows.Forms.ToolStripStatusLabel carriageReturn;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private MainMenu mainMenu;
        private MenuItem fileMenu;
        private MenuItem newItem;
        private MenuItem newWindowItem;
        private MenuItem openItem;
        private MenuItem saveItem;
        private MenuItem saveAsItem;
        private MenuItem menuItem6;
        private MenuItem exitItem;
        private MenuItem editMenu;
        private MenuItem undoItem;
        private MenuItem menuItem2;
        private MenuItem cutItem;
        private MenuItem copyItem;
        private MenuItem pasteItem;
        private MenuItem delItem;
        private MenuItem menuItem8;
        private MenuItem selectAllItem;
        private MenuItem timeDateItem;
        private MenuItem formatMenu;
        private MenuItem wordWrapItem;
        private MenuItem fontItem;
        private MenuItem viewMenu;
        private MenuItem statusBarItem;
        private MenuItem helpMenu;
        private MenuItem viewHelpItem;
        private MenuItem sendFeedbackItem;
        private MenuItem menuItem15;
        private MenuItem aboutNotepadSXItem;
        private ToolStripStatusLabel attachLabel;
        private MenuItem synapseXItem;
        private MenuItem executeItem;
        private MenuItem attachItem;
    }
}

