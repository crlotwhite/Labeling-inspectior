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
    public partial class DictView : Form
    {
        Dictionary<string, string> dictionary;
        Form1 parent;

        public DictView(Dictionary<string, string> _dictionary, Form1 _parent)
        {
            InitializeComponent();
            dictionary = _dictionary ?? new Dictionary<string, string>();
            parent = _parent;
        }

        private void DictView_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, string> entry in dictionary)
            {
                lvDict.Items.Add(new ListViewItem(new string[] { entry.Key, entry.Value }));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DictView_FormClosing(object sender, FormClosingEventArgs e)
        {
            // if (parent.openedLabIds.Count > 0)
            // {
            //     MessageBox.Show("Lab files are still opened!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // }
        }
    }
}
