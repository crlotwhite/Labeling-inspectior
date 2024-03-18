namespace Labeling_inspectior
{
    public partial class Form1 : Form
    {
        public Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Shutdown", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void menuLoadDict_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text File (*.txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    string[] lines = File.ReadAllLines(dialog.FileName);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('\t');
                        if (!dictionary.ContainsKey(parts[0]))
                            dictionary.Add(parts[0], parts[1]);
                    }
                    menuDictView.Enabled = true;
                    menuOpenLab.Enabled = true;
                    
                    DictView dictView = new DictView(dictionary);
                    dictView.MdiParent = this;
                    dictView.Show();

                }
                catch
                {
                    MessageBox.Show("Something is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    menuDictView.Enabled = false;
                    menuOpenLab.Enabled = false;
                }

            }

        }

        private void menuDictView_Click(object sender, EventArgs e)
        {
            DictView dictView = new DictView(dictionary);
            dictView.MdiParent = this;
            dictView.Show();
        }

        private void menuOpenLab_Click(object sender, EventArgs e)
        {
            List<string> labs = new List<string>();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Lab File (*.lab)|*.lab";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines(dialog.FileName);

                    foreach (string line in lines)
                    {
                        labs.Add(line);
                    }

                    Form2 form2 = new Form2(labs, dictionary);
                    form2.MdiParent = this;
                    form2.Show();

                }
                catch
                {
                    MessageBox.Show("Something is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    menuDictView.Enabled = false;
                }

            }
        }
    }
}
