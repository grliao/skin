using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Skin.Controls
{
    /// <summary>
    /// 透明CheckBox
    /// </summary>
    public class TransparentCheckBox : CheckBox
    {
        public TransparentCheckBox()
        {
            this.BackColor = Color.Transparent;
            this.RegisterEvent();
        }

        public void RegisterEvent()
        {
            this.MouseEnter += OnMouseEnter;
            this.MouseLeave += OnMouseLeave;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        private void OnMouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
    }
}
