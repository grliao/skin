using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFWTest
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        public Dictionary<string, string> ItemResults
        {
            set
            {
                foreach (var eachKV in value)
                {
                    var currentItem = this.lvResult.Items.Add(eachKV.Key);
                    currentItem.SubItems.Add(eachKV.Value);
                }
            }
        }
    }
}
