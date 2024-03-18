using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labeling_inspectior
{
    public partial class Explorer : Form
    {
        List<Tuple<int, string[]>> fails;
        Form2 form2;

        public Explorer(List<Tuple<int, string[]>> fails, Form2 form2)
        {
            InitializeComponent();
            this.fails = fails;
            this.form2 = form2;
        }

        private void Explorer_Load(object sender, EventArgs e)
        {
            foreach (Tuple<int, string[]> fail in fails)
            {
                var li = new ListViewItem(new string[] { fail.Item1.ToString(), fail.Item2[2] });
                listView1.Items.Add(li);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var li = listView1.SelectedItems[0];
            int index = int.Parse(li.SubItems[0].Text);
            form2.ScrollToIndex(index);
        }
    }
}
