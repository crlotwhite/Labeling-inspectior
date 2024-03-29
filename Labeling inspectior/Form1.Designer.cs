﻿namespace Labeling_inspectior
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            menuOpenLab = new ToolStripMenuItem();
            menuSaveLab = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            windowToolStripMenuItem = new ToolStripMenuItem();
            menuDictView = new ToolStripMenuItem();
            menuValidView = new ToolStripMenuItem();
            menuReassView = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            menuLoadDict = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusDescription = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, windowToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1014, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuOpenLab, menuSaveLab, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // menuOpenLab
            // 
            menuOpenLab.Name = "menuOpenLab";
            menuOpenLab.ShortcutKeyDisplayString = "";
            menuOpenLab.ShortcutKeys = Keys.Control | Keys.O;
            menuOpenLab.Size = new Size(184, 22);
            menuOpenLab.Text = "Open lab file";
            menuOpenLab.Click += menuOpenLab_Click;
            // 
            // menuSaveLab
            // 
            menuSaveLab.Name = "menuSaveLab";
            menuSaveLab.ShortcutKeys = Keys.Control | Keys.S;
            menuSaveLab.Size = new Size(184, 22);
            menuSaveLab.Text = "Save lab file";
            menuSaveLab.Click += saveLabFileToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(184, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // windowToolStripMenuItem
            // 
            windowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuDictView, menuValidView, menuReassView });
            windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            windowToolStripMenuItem.Size = new Size(63, 20);
            windowToolStripMenuItem.Text = "Window";
            // 
            // menuDictView
            // 
            menuDictView.Enabled = false;
            menuDictView.Name = "menuDictView";
            menuDictView.Size = new Size(136, 22);
            menuDictView.Text = "Dictionary";
            menuDictView.Click += menuDictView_Click;
            // 
            // menuValidView
            // 
            menuValidView.Enabled = false;
            menuValidView.Name = "menuValidView";
            menuValidView.Size = new Size(136, 22);
            menuValidView.Text = "Validator";
            // 
            // menuReassView
            // 
            menuReassView.Enabled = false;
            menuReassView.Name = "menuReassView";
            menuReassView.Size = new Size(136, 22);
            menuReassView.Text = "Reassemble";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuLoadDict });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // menuLoadDict
            // 
            menuLoadDict.Name = "menuLoadDict";
            menuLoadDict.Size = new Size(157, 22);
            menuLoadDict.Text = "Load Dictionary";
            menuLoadDict.Click += menuLoadDict_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, statusDescription });
            statusStrip1.Location = new Point(0, 728);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1014, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(53, 17);
            toolStripStatusLabel1.Text = "Message";
            // 
            // statusDescription
            // 
            statusDescription.Name = "statusDescription";
            statusDescription.Size = new Size(946, 17);
            statusDescription.Spring = true;
            statusDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 750);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Label Inspectior";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem menuOpenLab;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem menuDictView;
        private ToolStripMenuItem menuValidView;
        private ToolStripMenuItem menuReassView;
        private ToolStripMenuItem menuLoadDict;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel statusDescription;
        private ToolStripMenuItem menuSaveLab;
    }
}
