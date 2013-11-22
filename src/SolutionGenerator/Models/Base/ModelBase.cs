namespace SolutionGenerator.Models.Base
{
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;

    public abstract class ModelBase : INotifyPropertyChanged, IDataErrorInfo
    {
        public virtual event PropertyChangedEventHandler PropertyChanged;
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