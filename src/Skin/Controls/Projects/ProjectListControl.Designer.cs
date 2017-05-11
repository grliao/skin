namespace Skin.Controls.Projects
{
    partial class ProjectListControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectListControl));
            this.cboxSequence = new System.Windows.Forms.ComboBox();
            this.dgvProject = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbProjectList = new Skin.Controls.TransparentPictureBox();
            this.pbDeleteProject = new Skin.Controls.TransparentPictureBox();
            this.pbNewProject = new Skin.Controls.TransparentPictureBox();
            this.pbHomePage = new Skin.Controls.TransparentPictureBox();
            this.pbPrevious = new Skin.Controls.TransparentPictureBox();
            this.pbSearch = new Skin.Controls.TransparentPictureBox();
            this.txtProjectCode = new Skin.Controls.TransparentTextBox();
            this.txtProjectName = new Skin.Controls.TransparentTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProjectList)).BeginInit();
            this.pbProjectList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxSequence
            // 
            this.cboxSequence.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxSequence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxSequence.FormattingEnabled = true;
            this.cboxSequence.ItemHeight = 12;
            this.cboxSequence.Location = new System.Drawing.Point(454, 53);
            this.cboxSequence.Name = "cboxSequence";
            this.cboxSequence.Size = new System.Drawing.Size(124, 20);
            this.cboxSequence.TabIndex = 1;
            // 
            // dgvProject
            // 
            this.dgvProject.AllowUserToAddRows = false;
            this.dgvProject.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colSequence,
            this.colCode});
            this.dgvProject.Location = new System.Drawing.Point(109, 95);
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.ReadOnly = true;
            this.dgvProject.RowHeadersVisible = false;
            this.dgvProject.RowTemplate.Height = 23;
            this.dgvProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProject.Size = new System.Drawing.Size(784, 341);
            this.dgvProject.TabIndex = 2;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "产品名称";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 250;
            // 
            // colSequence
            // 
            this.colSequence.DataPropertyName = "Sequence";
            this.colSequence.HeaderText = "产品序列";
            this.colSequence.Name = "colSequence";
            this.colSequence.ReadOnly = true;
            this.colSequence.Width = 250;
            // 
            // colCode
            // 
            this.colCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "产品代码";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // pbProjectList
            // 
            this.pbProjectList.BackColor = System.Drawing.Color.Transparent;
            this.pbProjectList.Controls.Add(this.pbDeleteProject);
            this.pbProjectList.Controls.Add(this.pbNewProject);
            this.pbProjectList.Controls.Add(this.pbHomePage);
            this.pbProjectList.Controls.Add(this.pbPrevious);
            this.pbProjectList.Controls.Add(this.pbSearch);
            this.pbProjectList.Controls.Add(this.txtProjectCode);
            this.pbProjectList.Controls.Add(this.txtProjectName);
            this.pbProjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProjectList.Image = global::Skin.Resources.ProjectList;
            this.pbProjectList.Location = new System.Drawing.Point(0, 0);
            this.pbProjectList.Name = "pbProjectList";
            this.pbProjectList.Size = new System.Drawing.Size(1024, 560);
            this.pbProjectList.TabIndex = 0;
            this.pbProjectList.TabStop = false;
            // 
            // pbDeleteProject
            // 
            this.pbDeleteProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDeleteProject.BackColor = System.Drawing.Color.Transparent;
            this.pbDeleteProject.Image = global::Skin.Resources.DeleteProject;
            this.pbDeleteProject.Location = new System.Drawing.Point(881, 490);
            this.pbDeleteProject.Name = "pbDeleteProject";
            this.pbDeleteProject.Size = new System.Drawing.Size(109, 35);
            this.pbDeleteProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeleteProject.TabIndex = 8;
            this.pbDeleteProject.TabStop = false;
            // 
            // pbNewProject
            // 
            this.pbNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbNewProject.BackColor = System.Drawing.Color.Transparent;
            this.pbNewProject.Image = ((System.Drawing.Image)(resources.GetObject("pbNewProject.Image")));
            this.pbNewProject.Location = new System.Drawing.Point(704, 490);
            this.pbNewProject.Name = "pbNewProject";
            this.pbNewProject.Size = new System.Drawing.Size(157, 35);
            this.pbNewProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewProject.TabIndex = 7;
            this.pbNewProject.TabStop = false;
            // 
            // pbHomePage
            // 
            this.pbHomePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHomePage.BackColor = System.Drawing.Color.Transparent;
            this.pbHomePage.Image = global::Skin.Resources.GoHomePage;
            this.pbHomePage.Location = new System.Drawing.Point(934, 28);
            this.pbHomePage.Name = "pbHomePage";
            this.pbHomePage.Size = new System.Drawing.Size(51, 50);
            this.pbHomePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHomePage.TabIndex = 6;
            this.pbHomePage.TabStop = false;
            // 
            // pbPrevious
            // 
            this.pbPrevious.BackColor = System.Drawing.Color.Transparent;
            this.pbPrevious.Image = global::Skin.Resources.Previous;
            this.pbPrevious.Location = new System.Drawing.Point(34, 28);
            this.pbPrevious.Name = "pbPrevious";
            this.pbPrevious.Size = new System.Drawing.Size(51, 50);
            this.pbPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrevious.TabIndex = 5;
            this.pbPrevious.TabStop = false;
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.Transparent;
            this.pbSearch.Image = global::Skin.Resources.ProjectSearch;
            this.pbSearch.Location = new System.Drawing.Point(854, 44);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(39, 38);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 4;
            this.pbSearch.TabStop = false;
            // 
            // txtProjectCode
            // 
            this.txtProjectCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtProjectCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProjectCode.Location = new System.Drawing.Point(705, 57);
            this.txtProjectCode.Name = "txtProjectCode";
            this.txtProjectCode.Size = new System.Drawing.Size(124, 14);
            this.txtProjectCode.TabIndex = 2;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtProjectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProjectName.Location = new System.Drawing.Point(202, 57);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(124, 14);
            this.txtProjectName.TabIndex = 1;
            // 
            // ProjectListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvProject);
            this.Controls.Add(this.cboxSequence);
            this.Controls.Add(this.pbProjectList);
            this.Name = "ProjectListControl";
            this.Size = new System.Drawing.Size(1024, 560);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProjectList)).EndInit();
            this.pbProjectList.ResumeLayout(false);
            this.pbProjectList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.TransparentPictureBox pbProjectList;
        private TransparentTextBox txtProjectName;
        private TransparentTextBox txtProjectCode;
        private Controls.TransparentPictureBox pbSearch;
        private Controls.TransparentPictureBox pbHomePage;
        private Controls.TransparentPictureBox pbPrevious;
        private Controls.TransparentPictureBox pbNewProject;
        private Controls.TransparentPictureBox pbDeleteProject;
        private System.Windows.Forms.ComboBox cboxSequence;
        private System.Windows.Forms.DataGridView dgvProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
    }
}
