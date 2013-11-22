namespace SolutionGenerator
{
    using System;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;

    public class SolutionModel : INotifyPropertyChanged, IDataErrorInfo
    {
        private string _solutionGuid;
        private string _projectGuid;
        private string _targetFramework;
        private string _projectAssemblyName;
        private string _projectRootNameSpace;
        private string _rootPath;
        private string _solutionName;
        private string _projectName;

        public SolutionModel()
        {
            ProjectGuid = Guid.NewGuid().ToString("B");
            SolutionGuid = Guid.NewGuid().ToString("B");
            TargetFramework = "v4.5";
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        public string SolutionGuid
        {
            get
            {
                return _solutionGuid;
            }
            set
            {
                if (value == _solutionGuid)
                {
                    return;
                }
                _solutionGuid = value;
                OnPropertyChanged();
            }
        }

        public string ProjectGuid
        {
            get
            {
                return _projectGuid;
            }
            set
            {
                if (value == _projectGuid)
                {
                    return;
                }
                _projectGuid = value;
                OnPropertyChanged();
            }
        }

        public string ProjectName
        {
            get
            {
                return _projectName;
            }
            set
            {
                if (value == _projectName)
                {
                    return;
                }
                _projectName = value;
                OnPropertyChanged();
            }
        }

        public string SolutionName
        {
            get
            {
                return _solutionName;
            }
            set
            {
                if (value == _solutionName)
                {
                    return;
                }
                _solutionName = value;
                OnPropertyChanged();
            }
        }

        public string RootPath
        {
            get
            {
                return _rootPath;
            }
            set
            {
                if (value == _rootPath)
                {
                    return;
                }
                _rootPath = value;
                OnPropertyChanged();
            }
        }

        public string ProjectRootNameSpace
        {
            get
            {
                return _projectRootNameSpace;
            }
            set
            {
                if (value == _projectRootNameSpace)
                {
                    return;
                }
                _projectRootNameSpace = value;
                OnPropertyChanged();
            }
        }

        public string ProjectAssemblyName
        {
            get
            {
                return _projectAssemblyName;
            }
            set
            {
                if (value == _projectAssemblyName)
                {
                    return;
                }
                _projectAssemblyName = value;
                OnPropertyChanged();
            }
        }

        public string TargetFramework
        {
            get
            {
                return _targetFramework;
            }
            set
            {
                if (value == _targetFramework)
                {
                    return;
                }
                _targetFramework = value;
                OnPropertyChanged();
            }
        }

        public string Error { get; private set; }
        
        public string this[string columnName]
        {
            get
            {
                Error = string.Empty;
                var columnNamePropertyInfo = GetType().GetProperties().FirstOrDefault(p => p.Name == columnName);
                if (columnNamePropertyInfo != null)
                {
                    object value = columnNamePropertyInfo.GetValue(this);
                    if (value == null)
                    {
                        Error = columnName + " cannot be null";
                    }
                    else if (string.IsNullOrWhiteSpace(value.ToString()))
                    {
                        Error = columnName + " cannot be empty";
                    }
                }
                return Error;
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}