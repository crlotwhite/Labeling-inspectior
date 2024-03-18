using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labeling_inspectior
{
    public partial class Form2 : Form
    {
        List<string> labels;
        Dictionary<string, string> dictionary;
        List<Tuple<int, string[]>> fails;
        Explorer explorer;
        Form1 parent;
        string fileName;
        public ListView.ListViewItemCollection items;

        public Form2(List<string> _labels, Dictionary<string, string> _dictionary, Form1 _parent, string _fileName)
        {
            InitializeComponent();
            labels = _labels;
            dictionary = _dictionary;
            fails = new List<Tuple<int, string[]>>();
            parent = _parent;
            fileName = _fileName;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Text = fileName;
            int i = 0;
            foreach (string label in labels)
            {
                string[] part = label.Split(' ');
                Color c;
                if (dictionary.ContainsKey(part[2]))
                {
                    c = Color.Black;
                }
                else
                {
                    c = Color.Red;
                    fails.Add(new Tuple<int, string[]>(i, part));
                }

                var li = new ListViewItem(part);
                li.ForeColor = c;
                listView1.Items.Add(li);
                i++;
            }

            items = listView1.Items;
            OpenExplorer();
        }

        private void Form2_FormClosing(object sender, EventArgs e)
        {
            // 저장 묻기
            explorer.Close();
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                OpenExplorer();
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                explorer.Close();
            }
        }

        private void OpenExplorer()
        {
            explorer = new Explorer(fails, this);
            explorer.MdiParent = MdiParent;
            explorer.StartPosition = FormStartPosition.Manual;
            explorer.Location = new Point(Location.X + Width, Location.Y - explorer.Width + Height);
            explorer.Show();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem li = listView1.SelectedItems[0];
            EditView editView = new EditView(dictionary, li);
            editView.MdiParent = MdiParent;
            editView.StartPosition = FormStartPosition.Manual;
            editView.Location = new Point(Location.X + Width, Location.Y);
            editView.Show();
        }

        public void ScrollToIndex(int index)
        {
            // listView1.EnsureVisible(index);
            listView1.TopItem = listView1.Items[index];
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            parent.setStatusDescription("Focus lab file view: " + fileName);
            parent.currentForm2 = this;
        }
    }
}
