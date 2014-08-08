using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACalculator.Interfaces
{
    public interface IPropertyChangeNotifier : INotifyPropertyChanged
    {
        void RaisePropertyChanged(string propertyName);
    }
}
