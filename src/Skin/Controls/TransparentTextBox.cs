using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Skin.Controls
{
    /// <summary>
    /// 透明TextBox
    /// </summary>
    public class TransparentTextBox : TextBox
    {
        public TransparentTextBox()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        //[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        //private static extern IntPtr LoadLibrary(string lpFileName);
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams prams = base.CreateParams;
        //        if (LoadLibrary("msftedit.dll") != IntPtr.Zero)
        //        {
        //            prams.ExStyle |= 0x020; // transparent   
        //            prams.ClassName = "RICHEDIT50W";
        //        }
        //        return prams;
        //    }
        //}
    }
}
