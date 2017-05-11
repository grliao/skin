using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skin.Controls
{
    public class TransparentRadioButton : RadioButton
    {
        public TransparentRadioButton()
        {
            this.BackColor = Color.Transparent;
        }
    }
}
