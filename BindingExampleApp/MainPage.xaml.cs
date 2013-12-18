using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace BindingExampleApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            //Creamos un nuevo objeto AppModel, que tendrá las propiedades de nuestro modelo
            Models.AppModel CurrentModel = Models.ModelGenerator.getLineaModel();

            //Creamos un nuevo ViewModel para añadirlo a la vista
            ViewModels.MainViewModel CurrentViewModel = new ViewModels.MainViewModel();

            //Establecemos las propiedades de nuestra ViewModel con datos del modelo
            CurrentViewModel.NumeroLinea = CurrentModel.NumeroLinea;
            CurrentViewModel.Operador = CurrentModel.Operador;

            //Especificamos que modelo deberá utilizarse en nuestra vista
            this.DataContext = CurrentViewModel;

            //Especificamos la lista del modelo que se incluirá en la lista que hay en la vista
            this.ListaLLamadas.ItemsSource = CurrentModel.llamadas;
            
        }
    }
}