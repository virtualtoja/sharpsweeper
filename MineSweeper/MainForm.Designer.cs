
namespace MineSweeper
{
    partial class MainForm
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
            this.panelGame = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showDebugInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMinesweeperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableMineButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGame
            // 
            this.panelGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGame.Location = new System.Drawing.Point(0, 24);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(224, 245);
            this.panelGame.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.cheatsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(224, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.showDebugInfoToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.newToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.ToolTipText = "Starts a new game";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // showDebugInfoToolStripMenuItem
            // 
            this.showDebugInfoToolStripMenuItem.Name = "showDebugInfoToolStripMenuItem";
            this.showDebugInfoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.showDebugInfoToolStripMenuItem.Text = "Show Debug Info";
            this.showDebugInfoToolStripMenuItem.Click += new System.EventHandler(this.showDebugInfoToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMinesweeperToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMinesweeperToolStripMenuItem
            // 
            this.aboutMinesweeperToolStripMenuItem.Name = "aboutMinesweeperToolStripMenuItem";
            this.aboutMinesweeperToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutMinesweeperToolStripMenuItem.Text = "About Minesweeper";
            this.aboutMinesweeperToolStripMenuItem.Click += new System.EventHandler(this.aboutMinesweeperToolStripMenuItem_Click);
            // 
            // cheatsToolStripMenuItem
            // 
            this.cheatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showBoardToolStripMenuItem,
            this.showHintToolStripMenuItem,
            this.showMinesToolStripMenuItem,
            this.disableMineButtonsToolStripMenuItem});
            this.cheatsToolStripMenuItem.Name = "cheatsToolStripMenuItem";
            this.cheatsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cheatsToolStripMenuItem.Text = "Cheats";
            // 
            // showBoardToolStripMenuItem
            // 
            this.showBoardToolStripMenuItem.Name = "showBoardToolStripMenuItem";
            this.showBoardToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.showBoardToolStripMenuItem.Text = "Show Board";
            this.showBoardToolStripMenuItem.Click += new System.EventHandler(this.showBoardToolStripMenuItem_Click);
            // 
            // showHintToolStripMenuItem
            // 
            this.showHintToolStripMenuItem.Name = "showHintToolStripMenuItem";
            this.showHintToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.showHintToolStripMenuItem.Text = "Show Hint";
            this.showHintToolStripMenuItem.Click += new System.EventHandler(this.showHintToolStripMenuItem_Click);
            // 
            // showMinesToolStripMenuItem
            // 
            this.showMinesToolStripMenuItem.Name = "showMinesToolStripMenuItem";
            this.showMinesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.showMinesToolStripMenuItem.Text = "Show Mines";
            this.showMinesToolStripMenuItem.Click += new System.EventHandler(this.showMinesToolStripMenuItem_Click);
            // 
            // disableMineButtonsToolStripMenuItem
            // 
            this.disableMineButtonsToolStripMenuItem.Name = "disableMineButtonsToolStripMenuItem";
            this.disableMineButtonsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.disableMineButtonsToolStripMenuItem.Text = "Disable Mine Buttons";
            this.disableMineButtonsToolStripMenuItem.Click += new System.EventHandler(this.disableMineButtonsToolStripMenuItem_Click);
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(182, 8);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(10, 13);
            this.labelC.TabIndex = 0;
            this.labelC.Text = " ";
            this.labelC.Visible = false;
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(157, 8);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(10, 13);
            this.labelD.TabIndex = 1;
            this.labelD.Text = " ";
            this.labelD.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 269);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Minesweeper";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutMinesweeperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBoardToolStripMenuItem;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.ToolStripMenuItem showHintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMinesToolStripMenuItem;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.ToolStripMenuItem showDebugInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableMineButtonsToolStripMenuItem;
    }
}

