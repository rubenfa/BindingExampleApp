using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections;

namespace BindingExampleApp.ViewModels
{
   
        public class MainViewModel : INotifyPropertyChanged
        {

            private string _NumeroLinea;

            public string NumeroLinea
            {
                get
                {
                    return _NumeroLinea;
                }
                set
                {
                    if (value != _NumeroLinea)
                    {
                        _NumeroLinea = value;
                        NotifyPropertyChanged("NumeroLinea");
                    }
                }
            }


            private string _Operador;

            public string Operador
            {
                get
                {
                    return _Operador;
                }
                set
                {
                    if (value != _Operador)
                    {
                        _Operador = value;
                        NotifyPropertyChanged("Operador");
                    }
                }
            }




            public event PropertyChangedEventHandler PropertyChanged;
            private void NotifyPropertyChanged(String propertyName)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                if (null != handler)
                {
                    handler(this, new PropertyChangedEventArgs(propertyName));
                }
            }

        }
    }





