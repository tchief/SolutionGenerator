namespace SolutionGenerator.Frontend
{
    partial class GeneratorForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label projectAssemblyNameLabel;
            System.Windows.Forms.Label projectGuidLabel;
            System.Windows.Forms.Label projectNameLabel;
            System.Windows.Forms.Label projectRootNameSpaceLabel;
            System.Windows.Forms.Label rootPathLabel;
            System.Windows.Forms.Label solutionGuidLabel;
            System.Windows.Forms.Label solutionNameLabel;
            System.Windows.Forms.Label targetFrameworkLabel;
            this.projectAssemblyNameTextBox = new System.Windows.Forms.TextBox();
            this.solutionModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectGuidTextBox = new System.Windows.Forms.TextBox();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.projectRootNameSpaceTextBox = new System.Windows.Forms.TextBox();
            this.rootPathTextBox = new System.Windows.Forms.TextBox();
            this.solutionGuidTextBox = new System.Windows.Forms.TextBox();
            this.solutionNameTextBox = new System.Windows.Forms.TextBox();
            this.targetFrameworkTextBox = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            projectAssemblyNameLabel = new System.Windows.Forms.Label();
            projectGuidLabel = new System.Windows.Forms.Label();
            projectNameLabel = new System.Windows.Forms.Label();
            projectRootNameSpaceLabel = new System.Windows.Forms.Label();
            rootPathLabel = new System.Windows.Forms.Label();
            solutionGuidLabel = new System.Windows.Forms.Label();
            solutionNameLabel = new System.Windows.Forms.Label();
            targetFrameworkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.solutionModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // projectAssemblyNameLabel
            // 
            projectAssemblyNameLabel.AutoSize = true;
            projectAssemblyNameLabel.Location = new System.Drawing.Point(12, 146);
            projectAssemblyNameLabel.Name = "projectAssemblyNameLabel";
            projectAssemblyNameLabel.Size = new System.Drawing.Size(121, 13);
            projectAssemblyNameLabel.TabIndex = 0;
            projectAssemblyNameLabel.Text = "Project Assembly Name:";
            this.toolTip1.SetToolTip(projectAssemblyNameLabel, "Output dll name (without extension) of the generated project");
            // 
            // projectGuidLabel
            // 
            projectGuidLabel.AutoSize = true;
            projectGuidLabel.Location = new System.Drawing.Point(12, 172);
            projectGuidLabel.Name = "projectGuidLabel";
            projectGuidLabel.Size = new System.Drawing.Size(68, 13);
            projectGuidLabel.TabIndex = 2;
            projectGuidLabel.Text = "Project Guid:";
            this.toolTip1.SetToolTip(projectGuidLabel, "Internally used Id for the project. This is auto generated when this form starts," +
        " no need to change it");
            // 
            // projectNameLabel
            // 
            projectNameLabel.AutoSize = true;
            projectNameLabel.Location = new System.Drawing.Point(12, 94);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new System.Drawing.Size(74, 13);
            projectNameLabel.TabIndex = 4;
            projectNameLabel.Text = "Project Name:";
            this.toolTip1.SetToolTip(projectNameLabel, "Besides a solution, we have a Project. Use this field to have a different Project" +
        "name then the solution.");
            // 
            // projectRootNameSpaceLabel
            // 
            projectRootNameSpaceLabel.AutoSize = true;
            projectRootNameSpaceLabel.Location = new System.Drawing.Point(12, 120);
            projectRootNameSpaceLabel.Name = "projectRootNameSpaceLabel";
            projectRootNameSpaceLabel.Size = new System.Drawing.Size(134, 13);
            projectRootNameSpaceLabel.TabIndex = 6;
            projectRootNameSpaceLabel.Text = "Project Root Name Space:";
            this.toolTip1.SetToolTip(projectRootNameSpaceLabel, "This will be the namespace used for classes added to the root of the generated pr" +
        "oject.");
            // 
            // rootPathLabel
            // 
            rootPathLabel.AutoSize = true;
            rootPathLabel.Location = new System.Drawing.Point(12, 15);
            rootPathLabel.Name = "rootPathLabel";
            rootPathLabel.Size = new System.Drawing.Size(58, 13);
            rootPathLabel.TabIndex = 8;
            rootPathLabel.Text = "Root Path:";
            this.toolTip1.SetToolTip(rootPathLabel, "Root folder the solution and project structure will be created in");
            // 
            // solutionGuidLabel
            // 
            solutionGuidLabel.AutoSize = true;
            solutionGuidLabel.Location = new System.Drawing.Point(12, 67);
            solutionGuidLabel.Name = "solutionGuidLabel";
            solutionGuidLabel.Size = new System.Drawing.Size(73, 13);
            solutionGuidLabel.TabIndex = 10;
            solutionGuidLabel.Text = "Solution Guid:";
            this.toolTip1.SetToolTip(solutionGuidLabel, "This Guid is used in the internal Visual Studio system and identifies the Solutio" +
        "n. No need to change this, it is generated when the program starts.");
            // 
            // solutionNameLabel
            // 
            solutionNameLabel.AutoSize = true;
            solutionNameLabel.Location = new System.Drawing.Point(12, 41);
            solutionNameLabel.Name = "solutionNameLabel";
            solutionNameLabel.Size = new System.Drawing.Size(79, 13);
            solutionNameLabel.TabIndex = 12;
            solutionNameLabel.Text = "Solution Name:";
            this.toolTip1.SetToolTip(solutionNameLabel, "Name for the main solution");
            // 
            // targetFrameworkLabel
            // 
            targetFrameworkLabel.AutoSize = true;
            targetFrameworkLabel.Location = new System.Drawing.Point(12, 198);
            targetFrameworkLabel.Name = "targetFrameworkLabel";
            targetFrameworkLabel.Size = new System.Drawing.Size(96, 13);
            targetFrameworkLabel.TabIndex = 14;
            targetFrameworkLabel.Text = "Target Framework:";
            this.toolTip1.SetToolTip(targetFrameworkLabel, "The version of .Net framework to build the project in.");
            // 
            // projectAssemblyNameTextBox
            // 
            this.projectAssemblyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.solutionModelBindingSource, "ProjectAssemblyName", true));
            this.projectAssemblyNameTextBox.Location = new System.Drawing.Point(152, 143);
            this.projectAssemblyNameTextBox.Name = "projectAssemblyNameTextBox";
            this.projectAssemblyNameTextBox.Size = new System.Drawing.Size(381, 20);
            this.projectAssemblyNameTextBox.TabIndex = 5;
            // 
            // solutionModelBindingSource
            // 
            this.solutionModelBindingSource.DataSource = typeof(SolutionGenerator.SolutionModel);
            // 
            // projectGuidTextBox
            // 
            this.projectGuidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.solutionModelBindingSource, "ProjectGuid", true));
            this.projectGuidTextBox.Location = new System.Drawing.Point(152, 169);
            this.projectGuidTextBox.Name = "projectGuidTextBox";
            this.projectGuidTextBox.Size = new System.Drawing.Size(381, 20);
            this.projectGuidTextBox.TabIndex = 3;
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.solutionModelBindingSource, "ProjectName", true));
            this.projectNameTextBox.Location = new System.Drawing.Point(152, 91);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(381, 20);
            this.projectNameTextBox.TabIndex = 3;
            // 
            // projectRootNameSpaceTextBox
            // 
            this.projectRootNameSpaceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.solutionModelBindingSource, "ProjectRootNameSpace", true));
            this.projectRootNameSpaceTextBox.Location = new System.Drawing.Point(152, 117);
            this.projectRootNameSpaceTextBox.Name = "projectRootNameSpaceTextBox";
            this.projectRootNameSpaceTextBox.Size = new System.Drawing.Size(381, 20);
            this.projectRootNameSpaceTextBox.TabIndex = 4;
            // 
            // rootPathTextBox
            // 
            this.rootPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.solutionModelBindingSource, "RootPath", true));
            this.rootPathTextBox.Location = new System.Drawing.Point(152, 12);
            this.rootPathTextBox.Name = "rootPathTextBox";
            this.rootPathTextBox.Size = new System.Drawing.Size(293, 20);
            this.rootPathTextBox.TabIndex = 0;
            // 
            // solutionGuidTextBox
            // 
            this.solutionGuidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.solutionModelBindingSource, "SolutionGuid", true));
            this.solutionGuidTextBox.Location = new System.Drawing.Point(152, 64);
            this.solutionGuidTextBox.Name = "solutionGuidTextBox";
            this.solutionGuidTextBox.Size = new System.Drawing.Size(381, 20);
            this.solutionGuidTextBox.TabIndex = 11;
            // 
            // solutionNameTextBox
            // 
            this.solutionNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.solutionModelBindingSource, "SolutionName", true));
            this.solutionNameTextBox.Location = new System.Drawing.Point(152, 38);
            this.solutionNameTextBox.Name = "solutionNameTextBox";
            this.solutionNameTextBox.Size = new System.Drawing.Size(381, 20);
            this.solutionNameTextBox.TabIndex = 2;
            // 
            // targetFrameworkTextBox
            // 
            this.targetFrameworkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.solutionModelBindingSource, "TargetFramework", true));
            this.targetFrameworkTextBox.Location = new System.Drawing.Point(152, 195);
            this.targetFrameworkTextBox.Name = "targetFrameworkTextBox";
            this.targetFrameworkTextBox.Size = new System.Drawing.Size(381, 20);
            this.targetFrameworkTextBox.TabIndex = 6;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(152, 222);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(381, 23);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerateClick);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(464, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(69, 20);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowseClick);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select a root folder";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.solutionModelBindingSource;
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 259);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(projectAssemblyNameLabel);
            this.Controls.Add(this.projectAssemblyNameTextBox);
            this.Controls.Add(projectGuidLabel);
            this.Controls.Add(this.projectGuidTextBox);
            this.Controls.Add(projectNameLabel);
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(projectRootNameSpaceLabel);
            this.Controls.Add(this.projectRootNameSpaceTextBox);
            this.Controls.Add(rootPathLabel);
            this.Controls.Add(this.rootPathTextBox);
            this.Controls.Add(solutionGuidLabel);
            this.Controls.Add(this.solutionGuidTextBox);
            this.Controls.Add(solutionNameLabel);
            this.Controls.Add(this.solutionNameTextBox);
            this.Controls.Add(targetFrameworkLabel);
            this.Controls.Add(this.targetFrameworkTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GeneratorForm";
            this.Text = "Solution Generator";
            ((System.ComponentModel.ISupportInitialize)(this.solutionModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource solutionModelBindingSource;
        private System.Windows.Forms.TextBox projectAssemblyNameTextBox;
        private System.Windows.Forms.TextBox projectGuidTextBox;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.TextBox projectRootNameSpaceTextBox;
        private System.Windows.Forms.TextBox rootPathTextBox;
        private System.Windows.Forms.TextBox solutionGuidTextBox;
        private System.Windows.Forms.TextBox solutionNameTextBox;
        private System.Windows.Forms.TextBox targetFrameworkTextBox;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
