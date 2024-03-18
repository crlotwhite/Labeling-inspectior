using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Labeling_inspectior
{
    public partial class Form2 : Form
    {
        List<string> labels;
        Dictionary<string, string> dictionary;
        public Form2(List<string> _labels, Dictionary<string, string> _dictionary)
        {
            InitializeComponent();
            labels = _labels;
            dictionary = _dictionary;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach(string label in labels)
            {
                string[] part = label.Split(' ');
                var c = (dictionary.ContainsKey(part[2])) ? Color.Black : Color.Red;
                var li = new ListViewItem(part);
                li.ForeColor = c;
                listView1.Items.Add(li);

            }
        }
    }
}
