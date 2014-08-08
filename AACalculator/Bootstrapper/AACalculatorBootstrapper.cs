using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using AACalculator.UI;
using log4net;

namespace AACalculator.Bootstrapper
{
    class AACalculatorBootstrapper
    {

        private static readonly ILog Logger = LogManager.GetLogger(typeof(AACalculatorBootstrapper));

        public void Run() 
        {
            try
            {
                var splashScreen = new SplashScreen(@"\Resources\Images\CalculatorImage.png");
                splashScreen.Show(true, true);

                // things to do goes here 
                // i.e clean up 
                // initialization of parameters

                splashScreen.Close(TimeSpan.FromMilliseconds(1750));
                Thread.Sleep(500);
                var screen = new StartScreenViewModel();
                
            }
            catch (Exception e)
            {
                Logger.ErrorFormat("Error in the AACalculatorBootstraper: {0}", e.Message);
                throw;
            }


        }




    }
}
