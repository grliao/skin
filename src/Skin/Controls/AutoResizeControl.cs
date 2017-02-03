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
        private Size _previousSize = new Size(1024, 560);
        

        private Control[] _controls = null;

        public AutoResizeControl()
        {
            //this.Resize += OnResize;
        }

        public void RegistResizeControls(params Control[] controls)
        {
            _controls = controls;
        }

        private void OnResize(object sender, EventArgs e)
        {
            if(this.Size != this._previousSize)
            {
                if (this._controls != null)
                {
                    foreach (var eachControl in _controls)
                    {
                        int x = (int)(((double)eachControl.Location.X * this.Size.Width) / this._previousSize.Width);
                        //int y = (int)(((double)eachControl.Location.Y * this.Size.Height) / this._previousSize.Height);
                        int y = eachControl.Location.Y;
                        eachControl.Location = new Point(x, y);
                    }
                }
            }

            this._previousSize = this.Size;
        }
    }
}
