using SolutionGenerator.Models;

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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label includeGitAttributeLabel;
            System.Windows.Forms.Label includeGitIgnoreLabel;
            System.Windows.Forms.Label includeLicenseLabel;
            System.Windows.Forms.Label includeReadmeLabel;
            System.Windows.Forms.Label includeResharperLabel;
            System.Windows.Forms.Label includeStylecopLabel;
            System.Windows.Forms.Label includeTestProjectLabel;
            System.Windows.Forms.Label targetFrameworkLabel1;
            this.projectAssemblyNameTextBox = new System.Windows.Forms.TextBox();
            this.solutionModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectGuidTextBox = new System.Windows.Forms.TextBox();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.projectRootNameSpaceTextBox = new System.Windows.Forms.TextBox();
            this.rootPathTextBox = new System.Windows.Forms.TextBox();
            this.solutionGuidTextBox = new System.Windows.Forms.TextBox();
            this.solutionNameTextBox = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.readmeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.chkStartVisualStudio = new System.Windows.Forms.CheckBox();
            this.includeGitAttributeCheckBox = new System.Windows.Forms.CheckBox();
            this.includeGitIgnoreCheckBox = new System.Windows.Forms.CheckBox();
            this.includeLicenseCheckBox = new System.Windows.Forms.CheckBox();
            this.includeReadmeCheckBox = new System.Windows.Forms.CheckBox();
            this.includeResharperCheckBox = new System.Windows.Forms.CheckBox();
            this.includeStylecopCheckBox = new System.Windows.Forms.CheckBox();
            this.includeTestProjectCheckBox = new System.Windows.Forms.CheckBox();
            this.targetFrameworkComboBox = new System.Windows.Forms.ComboBox();
            projectAssemblyNameLabel = new System.Windows.Forms.Label();
            projectGuidLabel = new System.Windows.Forms.Label();
            projectNameLabel = new System.Windows.Forms.Label();
            projectRootNameSpaceLabel = new System.Windows.Forms.Label();
            rootPathLabel = new System.Windows.Forms.Label();
            solutionGuidLabel = new System.Windows.Forms.Label();
            solutionNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            includeGitAttributeLabel = new System.Windows.Forms.Label();
            includeGitIgnoreLabel = new System.Windows.Forms.Label();
            includeLicenseLabel = new System.Windows.Forms.Label();
            includeReadmeLabel = new System.Windows.Forms.Label();
            includeResharperLabel = new System.Windows.Forms.Label();
            includeStylecopLabel = new System.Windows.Forms.Label();
            includeTestProjectLabel = new System.Windows.Forms.Label();
            targetFrameworkLabel1 = new System.Windows.Forms.Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 225);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 13);
            label1.TabIndex = 14;
            label1.Text = "ReadMe Content:";
            // 
            // includeGitAttributeLabel
            // 
            includeGitAttributeLabel.AutoSize = true;
            includeGitAttributeLabel.Location = new System.Drawing.Point(577, 15);
            includeGitAttributeLabel.Name = "includeGitAttributeLabel";
            includeGitAttributeLabel.Size = new System.Drawing.Size(103, 13);
            includeGitAttributeLabel.TabIndex = 21;
            includeGitAttributeLabel.Text = "Include Git Attribute:";
            // 
            // includeGitIgnoreLabel
            // 
            includeGitIgnoreLabel.AutoSize = true;
            includeGitIgnoreLabel.Location = new System.Drawing.Point(577, 45);
            includeGitIgnoreLabel.Name = "includeGitIgnoreLabel";
            includeGitIgnoreLabel.Size = new System.Drawing.Size(94, 13);
            includeGitIgnoreLabel.TabIndex = 23;
            includeGitIgnoreLabel.Text = "Include Git Ignore:";
            // 
            // includeLicenseLabel
            // 
            includeLicenseLabel.AutoSize = true;
            includeLicenseLabel.Location = new System.Drawing.Point(577, 75);
            includeLicenseLabel.Name = "includeLicenseLabel";
            includeLicenseLabel.Size = new System.Drawing.Size(85, 13);
            includeLicenseLabel.TabIndex = 25;
            includeLicenseLabel.Text = "Include License:";
            // 
            // includeReadmeLabel
            // 
            includeReadmeLabel.AutoSize = true;
            includeReadmeLabel.Location = new System.Drawing.Point(577, 105);
            includeReadmeLabel.Name = "includeReadmeLabel";
            includeReadmeLabel.Size = new System.Drawing.Size(88, 13);
            includeReadmeLabel.TabIndex = 27;
            includeReadmeLabel.Text = "Include Readme:";
            // 
            // includeResharperLabel
            // 
            includeResharperLabel.AutoSize = true;
            includeResharperLabel.Location = new System.Drawing.Point(577, 135);
            includeResharperLabel.Name = "includeResharperLabel";
            includeResharperLabel.Size = new System.Drawing.Size(97, 13);
            includeResharperLabel.TabIndex = 29;
            includeResharperLabel.Text = "Include Resharper:";
            // 
            // includeStylecopLabel
            // 
            includeStylecopLabel.AutoSize = true;
            includeStylecopLabel.Location = new System.Drawing.Point(577, 165);
            includeStylecopLabel.Name = "includeStylecopLabel";
            includeStylecopLabel.Size = new System.Drawing.Size(89, 13);
            includeStylecopLabel.TabIndex = 31;
            includeStylecopLabel.Text = "Include Stylecop:";
            // 
            // includeTestProjectLabel
            // 
            includeTestProjectLabel.AutoSize = true;
            includeTestProjectLabel.Location = new System.Drawing.Point(577, 195);
            includeTestProjectLabel.Name = "includeTestProjectLabel";
            includeTestProjectLabel.Size = new System.Drawing.Size(105, 13);
            includeTestProjectLabel.TabIndex = 33;
            includeTestProjectLabel.Text = "Include Test Project:";
            // 
            // targetFrameworkLabel1
            // 
            targetFrameworkLabel1.AutoSize = true;
            targetFrameworkLabel1.Location = new System.Drawing.Point(12, 198);
            targetFrameworkLabel1.Name = "targetFrameworkLabel1";
            targetFrameworkLabel1.Size = new System.Drawing.Size(96, 13);
            targetFrameworkLabel1.TabIndex = 35;
            targetFrameworkLabel1.Text = "Target Framework:";
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
            this.solutionModelBindingSource.DataSource = typeof(SolutionGenerator.Models.SolutionModel);
            // 
            // projectGuidTextBox
            // 
            this.projectGuidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.solutionModelBindingSource, "ProjectGuid", true));
            this.projectGuidTextBox.Location = new System.Drawing.Point(152, 169);
            this.projectGuidTextBox.Name = "projectGuidTextBox";
            this.projectGuidTextBox.Size = new System.Drawing.Size(381, 20);
            this.projectGuidTextBox.TabIndex = 17;
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
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(270, 419);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(263, 23);
            this.btnGenerate.TabIndex = 9;
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
            // readmeRichTextBox
            // 
            this.readmeRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.solutionModelBindingSource, "SolutionReadme", true));
            this.readmeRichTextBox.Location = new System.Drawing.Point(152, 222);
            this.readmeRichTextBox.Name = "readmeRichTextBox";
            this.readmeRichTextBox.Size = new System.Drawing.Size(381, 191);
            this.readmeRichTextBox.TabIndex = 7;
            this.readmeRichTextBox.Text = "";
            // 
            // chkStartVisualStudio
            // 
            this.chkStartVisualStudio.AutoSize = true;
            this.chkStartVisualStudio.Location = new System.Drawing.Point(152, 423);
            this.chkStartVisualStudio.Name = "chkStartVisualStudio";
            this.chkStartVisualStudio.Size = new System.Drawing.Size(112, 17);
            this.chkStartVisualStudio.TabIndex = 8;
            this.chkStartVisualStudio.Text = "Start Visual Studio";
            this.chkStartVisualStudio.UseVisualStyleBackColor = true;
            // 
            // includeGitAttributeCheckBox
            // 
            this.includeGitAttributeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.solutionModelBindingSource, "IncludeGitAttribute", true));
            this.includeGitAttributeCheckBox.Location = new System.Drawing.Point(688, 10);
            this.includeGitAttributeCheckBox.Name = "includeGitAttributeCheckBox";
            this.includeGitAttributeCheckBox.Size = new System.Drawing.Size(104, 24);
            this.includeGitAttributeCheckBox.TabIndex = 22;
            this.includeGitAttributeCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeGitIgnoreCheckBox
            // 
            this.includeGitIgnoreCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.solutionModelBindingSource, "IncludeGitIgnore", true));
            this.includeGitIgnoreCheckBox.Location = new System.Drawing.Point(688, 40);
            this.includeGitIgnoreCheckBox.Name = "includeGitIgnoreCheckBox";
            this.includeGitIgnoreCheckBox.Size = new System.Drawing.Size(104, 24);
            this.includeGitIgnoreCheckBox.TabIndex = 24;
            this.includeGitIgnoreCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeLicenseCheckBox
            // 
            this.includeLicenseCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.solutionModelBindingSource, "IncludeLicense", true));
            this.includeLicenseCheckBox.Location = new System.Drawing.Point(688, 70);
            this.includeLicenseCheckBox.Name = "includeLicenseCheckBox";
            this.includeLicenseCheckBox.Size = new System.Drawing.Size(104, 24);
            this.includeLicenseCheckBox.TabIndex = 26;
            this.includeLicenseCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeReadmeCheckBox
            // 
            this.includeReadmeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.solutionModelBindingSource, "IncludeReadme", true));
            this.includeReadmeCheckBox.Location = new System.Drawing.Point(688, 100);
            this.includeReadmeCheckBox.Name = "includeReadmeCheckBox";
            this.includeReadmeCheckBox.Size = new System.Drawing.Size(104, 24);
            this.includeReadmeCheckBox.TabIndex = 28;
            this.includeReadmeCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeResharperCheckBox
            // 
            this.includeResharperCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.solutionModelBindingSource, "IncludeResharper", true));
            this.includeResharperCheckBox.Location = new System.Drawing.Point(688, 130);
            this.includeResharperCheckBox.Name = "includeResharperCheckBox";
            this.includeResharperCheckBox.Size = new System.Drawing.Size(104, 24);
            this.includeResharperCheckBox.TabIndex = 30;
            this.includeResharperCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeStylecopCheckBox
            // 
            this.includeStylecopCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.solutionModelBindingSource, "IncludeStylecop", true));
            this.includeStylecopCheckBox.Location = new System.Drawing.Point(688, 160);
            this.includeStylecopCheckBox.Name = "includeStylecopCheckBox";
            this.includeStylecopCheckBox.Size = new System.Drawing.Size(104, 24);
            this.includeStylecopCheckBox.TabIndex = 32;
            this.includeStylecopCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeTestProjectCheckBox
            // 
            this.includeTestProjectCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.solutionModelBindingSource, "IncludeTestProject", true));
            this.includeTestProjectCheckBox.Location = new System.Drawing.Point(688, 190);
            this.includeTestProjectCheckBox.Name = "includeTestProjectCheckBox";
            this.includeTestProjectCheckBox.Size = new System.Drawing.Size(104, 24);
            this.includeTestProjectCheckBox.TabIndex = 34;
            this.includeTestProjectCheckBox.UseVisualStyleBackColor = true;
            // 
            // targetFrameworkComboBox
            // 
            this.targetFrameworkComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.solutionModelBindingSource, "TargetFramework", true));
            this.targetFrameworkComboBox.FormattingEnabled = true;
            this.targetFrameworkComboBox.Items.AddRange(new object[] {
            "v2.0",
            "v3.0",
            "v3.5",
            "v4.0",
            "v4.5"});
            this.targetFrameworkComboBox.Location = new System.Drawing.Point(152, 195);
            this.targetFrameworkComboBox.Name = "targetFrameworkComboBox";
            this.targetFrameworkComboBox.Size = new System.Drawing.Size(381, 21);
            this.targetFrameworkComboBox.TabIndex = 36;
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 462);
            this.Controls.Add(targetFrameworkLabel1);
            this.Controls.Add(this.targetFrameworkComboBox);
            this.Controls.Add(includeGitAttributeLabel);
            this.Controls.Add(this.includeGitAttributeCheckBox);
            this.Controls.Add(includeGitIgnoreLabel);
            this.Controls.Add(this.includeGitIgnoreCheckBox);
            this.Controls.Add(includeLicenseLabel);
            this.Controls.Add(this.includeLicenseCheckBox);
            this.Controls.Add(includeReadmeLabel);
            this.Controls.Add(this.includeReadmeCheckBox);
            this.Controls.Add(includeResharperLabel);
            this.Controls.Add(this.includeResharperCheckBox);
            this.Controls.Add(includeStylecopLabel);
            this.Controls.Add(this.includeStylecopCheckBox);
            this.Controls.Add(includeTestProjectLabel);
            this.Controls.Add(this.includeTestProjectCheckBox);
            this.Controls.Add(this.chkStartVisualStudio);
            this.Controls.Add(this.readmeRichTextBox);
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
            this.Controls.Add(label1);
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
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox readmeRichTextBox;
        private System.Windows.Forms.CheckBox chkStartVisualStudio;
        private System.Windows.Forms.CheckBox includeGitAttributeCheckBox;
        private System.Windows.Forms.CheckBox includeGitIgnoreCheckBox;
        private System.Windows.Forms.CheckBox includeLicenseCheckBox;
        private System.Windows.Forms.CheckBox includeReadmeCheckBox;
        private System.Windows.Forms.CheckBox includeResharperCheckBox;
        private System.Windows.Forms.CheckBox includeStylecopCheckBox;
        private System.Windows.Forms.CheckBox includeTestProjectCheckBox;
        private System.Windows.Forms.ComboBox targetFrameworkComboBox;
    }
}
