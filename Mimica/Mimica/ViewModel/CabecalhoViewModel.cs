using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mimica.ViewModel
{
    public class CabecalhoViewModel
    {
        public Command Sair { get; set; }

        public CabecalhoViewModel()
        {
            Sair = new Command(SairACtion);
        }

        private void SairACtion()
        {
            App.Current.MainPage = new View.Inicio();
          

        }
    }
}
