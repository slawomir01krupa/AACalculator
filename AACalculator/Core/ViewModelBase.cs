using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AACalculator.Interfaces;

namespace AACalculator.Core
{
    public class ViewModelBase : IPropertyChangeNotifier
    {

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        protected void InitialiseViewModel()
        {
        }

        /// <summary>
        /// Dont use directly, instead use the <see cref="PropertyNotifierExtensions"/> class
        /// </summary>
        public void RaisePropertyChanged(string propertyName)
        {
            VerifyPropertyExists(propertyName);
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


        [Conditional("DEBUG")]
        private void VerifyPropertyExists(string propertyName)
        {
            PropertyInfo currentProperty = GetType().GetProperty(propertyName);
            string message = string.Format("Property Name \"{0}\" does not exist in {1}", propertyName, GetType());
            Debug.Assert(currentProperty != null, message);
        }

    }
}
