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
        public DictView(Dictionary<string, string> _dictionary)
        {
            InitializeComponent();
            dictionary = _dictionary ?? new Dictionary<string, string>();
        }

        private void DictView_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, string> entry in dictionary)
            {
                lvDict.Items.Add(new ListViewItem(entry.Key, entry.Value));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
