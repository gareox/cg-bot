namespace TibiaInfo
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fileName = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.rope = new System.Windows.Forms.Button();
            this.use = new System.Windows.Forms.Button();
            this.enableWalker = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cGBotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tPForumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bojekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusExp = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusToLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusHp = new System.Windows.Forms.ToolStripStatusLabel();
            this.xpbar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusBarTimer = new System.Windows.Forms.Timer(this.components);
            this.statusMp = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 251);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enableWalker);
            this.groupBox1.Controls.Add(this.use);
            this.groupBox1.Controls.Add(this.rope);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.loadButton);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.fileName);
            this.groupBox1.Controls.Add(this.removeButton);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 275);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Walker";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(133, 165);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(74, 20);
            this.fileName.TabIndex = 6;
            this.fileName.Text = "C:\\Users\\Josh\\Documents\\test.txt";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(132, 220);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(132, 191);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(132, 135);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(132, 106);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(132, 19);
            this.addButton.Name = "addButton";
            this.addButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // rope
            // 
            this.rope.Location = new System.Drawing.Point(132, 77);
            this.rope.Name = "rope";
            this.rope.Size = new System.Drawing.Size(75, 23);
            this.rope.TabIndex = 7;
            this.rope.Text = "Rope";
            this.rope.UseVisualStyleBackColor = true;
            // 
            // use
            // 
            this.use.Location = new System.Drawing.Point(132, 48);
            this.use.Name = "use";
            this.use.Size = new System.Drawing.Size(75, 23);
            this.use.TabIndex = 2;
            this.use.Text = "Use";
            this.use.UseVisualStyleBackColor = true;
            // 
            // enableWalker
            // 
            this.enableWalker.AutoSize = true;
            this.enableWalker.Location = new System.Drawing.Point(133, 249);
            this.enableWalker.Name = "enableWalker";
            this.enableWalker.Size = new System.Drawing.Size(65, 17);
            this.enableWalker.TabIndex = 8;
            this.enableWalker.Text = "Enabled";
            this.enableWalker.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAllToolStripMenuItem,
            this.loadAllToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cGBotToolStripMenuItem,
            this.tPForumsToolStripMenuItem,
            this.bojekToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // cGBotToolStripMenuItem
            // 
            this.cGBotToolStripMenuItem.Name = "cGBotToolStripMenuItem";
            this.cGBotToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cGBotToolStripMenuItem.Text = "CGBot";
            // 
            // tPForumsToolStripMenuItem
            // 
            this.tPForumsToolStripMenuItem.Name = "tPForumsToolStripMenuItem";
            this.tPForumsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tPForumsToolStripMenuItem.Text = "TPForums";
            // 
            // bojekToolStripMenuItem
            // 
            this.bojekToolStripMenuItem.Name = "bojekToolStripMenuItem";
            this.bojekToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bojekToolStripMenuItem.Text = "Bojek";
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAllToolStripMenuItem.Text = "Save All";
            // 
            // loadAllToolStripMenuItem
            // 
            this.loadAllToolStripMenuItem.Name = "loadAllToolStripMenuItem";
            this.loadAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadAllToolStripMenuItem.Text = "Load All";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLevel,
            this.statusExp,
            this.statusToLevel,
            this.statusHp,
            this.statusMp,
            this.xpbar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 324);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(713, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLevel
            // 
            this.statusLevel.Name = "statusLevel";
            this.statusLevel.Size = new System.Drawing.Size(34, 17);
            this.statusLevel.Text = "Level";
            // 
            // statusExp
            // 
            this.statusExp.Name = "statusExp";
            this.statusExp.Size = new System.Drawing.Size(25, 17);
            this.statusExp.Text = "Exp";
            // 
            // statusToLevel
            // 
            this.statusToLevel.Name = "statusToLevel";
            this.statusToLevel.Size = new System.Drawing.Size(51, 17);
            this.statusToLevel.Text = "To Level";
            // 
            // statusHp
            // 
            this.statusHp.Name = "statusHp";
            this.statusHp.Size = new System.Drawing.Size(42, 17);
            this.statusHp.Text = "Health";
            // 
            // xpbar
            // 
            this.xpbar.Name = "xpbar";
            this.xpbar.Size = new System.Drawing.Size(100, 16);
            this.xpbar.Value = 100;
            // 
            // statusBarTimer
            // 
            this.statusBarTimer.Enabled = true;
            this.statusBarTimer.Tick += new System.EventHandler(this.statusBarTimer_Tick);
            // 
            // statusMp
            // 
            this.statusMp.Name = "statusMp";
            this.statusMp.Size = new System.Drawing.Size(37, 17);
            this.statusMp.Text = "Mana";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 346);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CGBot";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.CheckBox enableWalker;
        private System.Windows.Forms.Button use;
        private System.Windows.Forms.Button rope;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cGBotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tPForumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bojekToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLevel;
        private System.Windows.Forms.ToolStripStatusLabel statusExp;
        private System.Windows.Forms.ToolStripStatusLabel statusToLevel;
        private System.Windows.Forms.ToolStripStatusLabel statusHp;
        private System.Windows.Forms.ToolStripStatusLabel statusMp;
        private System.Windows.Forms.ToolStripProgressBar xpbar;
        private System.Windows.Forms.Timer statusBarTimer;

    }
}

