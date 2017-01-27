﻿using Skin.HomePage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Skin
{
    public partial class MainForm : Form
    {
        private static MainForm _form = new MainForm();
        private Control _currentControl;

        public MainForm()
        {
            InitializeComponent();
        }

        public static MainForm Instance
        {
            get
            {
                return _form;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.SetCurrentContentPanel(typeof(HomePageControl));
        }

        // 设置当前内容面板
        public void SetCurrentContentPanel(Control contentPanel)
        {
            if(contentPanel == null)
            {
                return;
            }

            this.Controls.Clear();

            contentPanel.BackColor = System.Drawing.Color.Transparent;
            contentPanel.Dock = DockStyle.Fill;
            this.Controls.Add(contentPanel);

            if (this._currentControl != null)
            {
                this._currentControl.Dispose();
            }

            this._currentControl = contentPanel;
        }

        /// <summary>
        /// 设置当前内容面板
        /// </summary>
        /// <param name="contentPanelType"></param>
        public void SetCurrentContentPanel(Type contentPanelType)
        {
            this.SetCurrentContentPanel(Activator.CreateInstance(contentPanelType) as Control);
        }
    }
}
