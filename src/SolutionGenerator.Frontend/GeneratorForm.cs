using System.Diagnostics;
using SolutionGenerator.Models;

namespace SolutionGenerator.Frontend
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public partial class GeneratorForm : Form
    {
        private readonly SolutionModel _solutionModel;

        public GeneratorForm()
        {
            InitializeComponent();

            _solutionModel = new SolutionModel();

            _solutionModel.PropertyChanged += (sender, args) =>
                {
                    errorProvider1.UpdateBinding();

                    switch (args.PropertyName)
                    {
                        case "SolutionName":
                            _solutionModel.ProjectName = string.IsNullOrEmpty(_solutionModel.ProjectName)
                                                             ? _solutionModel.SolutionName
                                                             : _solutionModel.ProjectName;
                            _solutionModel.ProjectRootNameSpace = string.IsNullOrEmpty(_solutionModel.ProjectRootNameSpace)
                                                                      ? _solutionModel.SolutionName
                                                                      : _solutionModel.ProjectRootNameSpace;
                            _solutionModel.ProjectAssemblyName = string.IsNullOrEmpty(_solutionModel.ProjectAssemblyName)
                                                                     ? _solutionModel.SolutionName
                                                                     : _solutionModel.ProjectAssemblyName;
                            break;
                        case "ProjectName":
                            _solutionModel.ProjectRootNameSpace = _solutionModel.ProjectName;
                            _solutionModel.ProjectAssemblyName = _solutionModel.ProjectName;
                            break;
                    }
                };

            solutionModelBindingSource.DataSource = _solutionModel;

            btnGenerate.Enabled = Controls.OfType<Control>().Select(x => errorProvider1.GetError(x)).All(string.IsNullOrWhiteSpace);

            _solutionModel.PropertyChanged += (sender, args) =>
                {
                    btnGenerate.Enabled = Controls.OfType<Control>().Select(x => errorProvider1.GetError(x)).All(string.IsNullOrWhiteSpace);
                };
        }

        private void BtnGenerateClick(object sender, EventArgs e)
        {
            var solutionGeneratorService = new SolutionGeneratorService();
            solutionGeneratorService.DoWork(_solutionModel);

            if (chkStartVisualStudio.Checked)
            {
                var fileName = string.Format("{0}/src/{1}.sln", _solutionModel.RootPath, _solutionModel.SolutionName);
                Process.Start(fileName);
            }
        }

        private void BtnBrowseClick(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                _solutionModel.RootPath = folderBrowserDialog.SelectedPath;
            }
        }
    }
}