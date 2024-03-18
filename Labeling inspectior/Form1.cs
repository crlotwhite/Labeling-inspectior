using System.Windows.Forms;

namespace Labeling_inspectior
{
    public partial class Form1 : Form
    {
        public Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public Form2? currentForm2 = null;
        // public List<Form2> openedLabIds = new List<Form2>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openDictionaryFile();
            Activate();
            statusDescription.Text = "Ready";
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
            openDictionaryFile();
        }

        private void menuDictView_Click(object sender, EventArgs e)
        {
            DictView dictView = new DictView(dictionary, this);
            dictView.MdiParent = this;
            dictView.Show();
            menuDictView.Enabled = false;
            statusDescription.Text = "Dictionary view opened";
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

                    Form2 form2 = new Form2(labs, dictionary, this, dialog.FileName);
                    form2.MdiParent = this;
                    form2.Show();

                    statusDescription.Text = "Lab file opened";
                }
                catch
                {
                    MessageBox.Show("Something is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    menuDictView.Enabled = false;
                    statusDescription.Text = "Failed to open lab file";
                }

            }
        }

        private void saveLabFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Lab File (*.lab)|*.lab";
            saveFileDialog1.Title = "Save a Lab File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName == "")
            {
                return;
            }

            if (currentForm2 == null)
            {
                MessageBox.Show("No active lab file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string text = "";
            foreach (ListViewItem li in currentForm2!.items)
            {
                text += li.SubItems[0].Text + " " + li.SubItems[1].Text + " " + li.SubItems[2].Text + "\n";

            }

            File.WriteAllText(saveFileDialog1.FileName, text, System.Text.Encoding.Default);

        }

        public void setStatusDescription(string text)
        {
            statusDescription.Text = text;
        }

        public void openDictionaryFile()
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
                    statusDescription.Text = "Dictionary loaded";
                }
                catch
                {
                    MessageBox.Show("Something is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    menuDictView.Enabled = false;
                    menuOpenLab.Enabled = false;
                    statusDescription.Text = "Failed to load dictionary";
                }

            }
        }

    }

}
