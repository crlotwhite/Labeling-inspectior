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
    public partial class EditView : Form
    {
        Dictionary<string, string> dictionary;
        ListViewItem li;

        public EditView(Dictionary<string, string> _dictionary, ListViewItem _li)
        {
            InitializeComponent();
            dictionary = _dictionary;
            li = _li;
        }

        private void EditView_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, string> entry in dictionary)
            {
                listView1.Items.Add(new ListViewItem(entry.Key));
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            li.SubItems[2].Text = listView1.SelectedItems[0].Text;
            Close();
        }
    }
}
