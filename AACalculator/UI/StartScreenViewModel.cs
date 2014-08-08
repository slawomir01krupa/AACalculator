using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AACalculator.Core;
using AACalculator.Util;
using AACalculator.Extensions;

namespace AACalculator.UI
{
    public class StartScreenViewModel : ViewModelBase
    {

        #region fields and properties
        private readonly StartScreen _view;
        private string _labelContent;

        public string LabelContent
        {
            get { return _labelContent; }
            set 
            { 
                _labelContent = value;
                this.RaisePropertyChanged(() => LabelContent);
            }
        }

        public StartScreenModel MainModel { get; set; }

        #endregion

        public StartScreenViewModel()
        {
            LabelContent = "Hello form ";

            _view = new StartScreen { DataContext = this };
            _view.Show();

        }


        #region Relay Commands
        private RelayCommand _menu1Pressed;
        public RelayCommand Menu1Pressed 
        {
            get 
            {
                if (_menu1Pressed != null) return _menu1Pressed;
                _menu1Pressed = new RelayCommand(a => Menu1PressedExecute());
                return _menu1Pressed;
            }
        }

        private void Menu1PressedExecute()
        {
            LabelContent = "Menu BTN 1 Was Pressed";
        }


        #endregion

    }
}
