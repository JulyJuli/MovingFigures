using System;
using System.Windows.Forms;

namespace MovingFigures
{
    partial class FormView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerView = new System.Windows.Forms.Timer(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.mainTree = new System.Windows.Forms.TreeView();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.minusB = new System.Windows.Forms.Button();
            this.plusB = new System.Windows.Forms.Button();
            this.triangleB = new System.Windows.Forms.Button();
            this.squareB = new System.Windows.Forms.Button();
            this.circleB = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionB = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerView
            // 
            this.timerView.Enabled = true;
            this.timerView.Interval = 75;
            this.timerView.Tick += new System.EventHandler(this.TimerView_Tick);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(86, 53);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(376, 221);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxPaint);
            // 
            // mainTree
            // 
            this.mainTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainTree.Location = new System.Drawing.Point(0, 53);
            this.mainTree.Name = "mainTree";
            this.mainTree.Size = new System.Drawing.Size(86, 221);
            this.mainTree.TabIndex = 4;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.minusB);
            this.buttonPanel.Controls.Add(this.plusB);
            this.buttonPanel.Controls.Add(this.triangleB);
            this.buttonPanel.Controls.Add(this.squareB);
            this.buttonPanel.Controls.Add(this.circleB);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel.Location = new System.Drawing.Point(0, 24);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(462, 29);
            this.buttonPanel.TabIndex = 5;
            // 
            // minusB
            // 
            this.minusB.Location = new System.Drawing.Point(58, 3);
            this.minusB.Name = "minusB";
            this.minusB.Size = new System.Drawing.Size(28, 26);
            this.minusB.TabIndex = 4;
            this.minusB.Text = "-";
            this.minusB.UseVisualStyleBackColor = true;
            this.minusB.Click += new System.EventHandler(this.MinusB_Click);
            // 
            // plusB
            // 
            this.plusB.Location = new System.Drawing.Point(0, 3);
            this.plusB.Name = "plusB";
            this.plusB.Size = new System.Drawing.Size(29, 26);
            this.plusB.TabIndex = 3;
            this.plusB.Text = "+";
            this.plusB.UseVisualStyleBackColor = true;
            this.plusB.Click += new System.EventHandler(this.PlusB_Click);
            // 
            // triangleB
            // 
            this.triangleB.Location = new System.Drawing.Point(346, 3);
            this.triangleB.Name = "triangleB";
            this.triangleB.Size = new System.Drawing.Size(83, 23);
            this.triangleB.TabIndex = 2;
            this.triangleB.Text = "Triangle";
            this.triangleB.UseVisualStyleBackColor = true;
            this.triangleB.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // squareB
            // 
            this.squareB.Location = new System.Drawing.Point(249, 3);
            this.squareB.Name = "squareB";
            this.squareB.Size = new System.Drawing.Size(83, 23);
            this.squareB.TabIndex = 1;
            this.squareB.Text = "Square";
            this.squareB.UseVisualStyleBackColor = true;
            this.squareB.Click += new System.EventHandler(this.Square_Click);
            // 
            // circleB
            // 
            this.circleB.Location = new System.Drawing.Point(151, 3);
            this.circleB.Name = "circleB";
            this.circleB.Size = new System.Drawing.Size(83, 23);
            this.circleB.TabIndex = 0;
            this.circleB.Text = "Circle ";
            this.circleB.UseVisualStyleBackColor = true;
            this.circleB.Click += new System.EventHandler(this.Circle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(462, 24);
            this.mainMenuStrip.TabIndex = 8;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(37, 20);
            this.file.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveFileToolStripMenuItem.Text = "Save File as";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveFileToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // actionB
            // 
            this.actionB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionB.Location = new System.Drawing.Point(0, 274);
            this.actionB.Name = "actionB";
            this.actionB.Size = new System.Drawing.Size(462, 23);
            this.actionB.TabIndex = 10;
            this.actionB.Text = "Stop/Move";
            this.actionB.UseVisualStyleBackColor = true;
            this.actionB.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "xml";
            this.saveFile.Filter = "XML-File (.xml)|*.xml|JSON-File (.json)|*.json|Bin-File (.bin)|*.bin";
            // 
            // openFile
            // 
            this.openFile.CheckFileExists = false;
            this.openFile.DefaultExt = "XML-File (.xml)|*.xml|JSON-File (.json)|*.json|Bin-File (.bin)|*.bin";
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Location = new System.Drawing.Point(341, 3);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(121, 21);
            this.languageComboBox.TabIndex = 11;
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.LanguageComboBox_SelectedIndexChanged);
            // 
            // FormView
            // 
            this.ClientSize = new System.Drawing.Size(462, 297);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.mainTree);
            this.Controls.Add(this.actionB);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "FormView";
            this.Text = "Moving Figures";
            this.Load += new System.EventHandler(this.FormView_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxPaint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TreeView mainTree;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button triangleB;
        private System.Windows.Forms.Button squareB;
        private System.Windows.Forms.Button circleB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button actionB;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Timer timerView;
        private Button plusB;
        private Button minusB;
        private ComboBox languageComboBox;
    }
}

