namespace Labeling_inspectior
{
    partial class DictView
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
            lvDict = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            SuspendLayout();
            // 
            // lvDict
            // 
            lvDict.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvDict.Dock = DockStyle.Fill;
            lvDict.Location = new Point(0, 0);
            lvDict.Name = "lvDict";
            lvDict.Size = new Size(215, 339);
            lvDict.TabIndex = 0;
            lvDict.UseCompatibleStateImageBehavior = false;
            lvDict.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Key";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Value";
            // 
            // DictView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 339);
            Controls.Add(lvDict);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "DictView";
            Text = "Dictionary";
            Load += DictView_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lvDict;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}