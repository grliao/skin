using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Skin.Controls
{
    /// <summary>
    /// 自动Resize控件
    /// </summary>
    public class AutoResizeControl:UserControl
    {
        private Size DefaultSize = new Size(1024, 560);

        private Control[] _controls = null;
        private List<Point> _controlPositions = new List<Point>();

        public void RegistResizeControls(params Control[] controls)
        {
            _controls = controls;

            if (controls != null)
            {
                for (int index = 0; index < controls.Count(); index++) 
                {
                    this._controlPositions[index] = controls[index].Location;
                }
            }
        }
    }
}
