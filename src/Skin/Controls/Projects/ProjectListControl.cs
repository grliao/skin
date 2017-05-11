using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Skin.Controls;
using Skin.HomePage;
using Skin.EF;
using Skin.Models;

namespace Skin.Controls.Projects
{
    public partial class ProjectListControl : UserControl
    {

        public ProjectListControl()
        {
            InitializeComponent();
        }

        public string CurrentSequence
        {
            get
            {
                return this.cboxSequence.SelectedItem as string;
            }
        }

        public Project CurrentProject
        {
            get
            {
                if (this.dgvProject.SelectedRows.Count == 0)
                {
                    return null;
                }

                return this.dgvProject.SelectedRows[0].DataBoundItem as Project;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dgvProject.AutoGenerateColumns = false;
            this.InitControlData();
            this.RegisterEvent();
        }

        private void RegisterEvent()
        {
            foreach (var eachControl in this.pbProjectList.Controls)
            {
                var pb = eachControl as TransparentPictureBox;
                if (pb != null)
                {
                    pb.RegisterEvent();
                }
            }

            this.pbPrevious.MouseClick += GoHomePage;
            this.pbHomePage.MouseClick += GoHomePage;

            this.pbSearch.Click += OnSearch;
            this.pbDeleteProject.Click += OnDeleteProject;
            this.pbNewProject.Click += OnNewProject;

            this.dgvProject.DoubleClick += OnSelectionChanged;
        }

        private void InitControlData()
        {
            List<string> sequences;
            using (SkinDbContext context = new SkinDbContext())
            {
                sequences = context.Projects.Select(p => p.Sequence).OrderBy(p => p).ToList();
            }

            foreach (var eachSequence in sequences)
            {
                this.cboxSequence.Items.Add(eachSequence);
            }
        }

        private void OnSearch(object sender, EventArgs e)
        {
            string name = this.txtProjectName.Text.Trim();
            string sequence  = this.CurrentSequence;
            if (sequence == null)
            {
                sequence = string.Empty;
            }
            string code = this.txtProjectCode.Text.Trim();

            List<Project> projects = null;
            using (SkinDbContext context = new SkinDbContext())
            {
                projects = context.Projects.Where(p => (name.Length == 0 || p.Name.Contains(name)) || (sequence.Length == 0 || p.Sequence.Contains(sequence))
                || (code.Length == 0 || p.Code.Contains(code))).OrderBy(p => p.Id).ToList();
            }

            this.dgvProject.DataSource = new List<Project>();
            this.dgvProject.DataSource = projects;
        }

        public void Research()
        {
            this.OnSearch(this, null);
        }

        private void OnDeleteProject(object sender, EventArgs e)
        {
            if (this.CurrentProject == null)
            {
                return;
            }
            using (SkinDbContext context = new SkinDbContext())
            {
                var dbProject = context.Projects.FirstOrDefault(p => p.Id == this.CurrentProject.Id);
                if (dbProject != null)
                {
                    context.Projects.Remove(dbProject);
                    context.SaveChanges();
                }
            }

            // 执行重新查询
            this.OnSearch(this, null);
        }


        private void OnNewProject(object sender, EventArgs e)
        {
            MainForm.Instance.SetCurrentContentPanel(typeof(NewProjectControl), false);

            var newControl = MainForm.Instance.CurrentControl as NewProjectControl;
            newControl.ParentControl = this;
        }

        private void OnSelectionChanged(object sender, EventArgs e)
        {
            if (this.CurrentProject == null)
            {
                return;
            }

            MainForm.Instance.SetCurrentContentPanel(typeof(ProjectDetailControl),false);

            var detailControl = MainForm.Instance.CurrentControl as ProjectDetailControl;
            detailControl.CurrentProject = this.CurrentProject;
            detailControl.ParentControl = this;
        }

        private void GoHomePage(object sender, MouseEventArgs e)
        {
            MainForm.Instance.SetCurrentContentPanel(typeof(HomePageControl));
        }
    }
}
