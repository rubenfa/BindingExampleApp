using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace BindingExampleApp.Models
{

    public class Llamada
    {

        public string Contacto { get; set; }
        public string NumeroTlf { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha{get;set;}
    }

    public class ListaLlamadas : ObservableCollection<Llamada>
    {
        public void AddLlamada(Llamada llamada)
        {
            this.Add(llamada);
        }
    }

    public class AppModel
    {

        public string NumeroLinea { get; set; }
        public string Operador { get; set; }
        public ListaLlamadas llamadas;
    }

    public static class ModelGenerator
    {
        public static AppModel getLineaModel()
        {
            AppModel model = new AppModel();

            model.NumeroLinea = "7412356";
            model.Operador = "MovisFone";

            model.llamadas = new ListaLlamadas();

            Llamada llamada2 = new Llamada() { Contacto = "Pedro Martínez", NumeroTlf = "1234567", Tipo = "Saliente", Fecha = new DateTime(2013, 11, 2, 13, 00, 58) };
            Llamada llamada3 = new Llamada() { Contacto = "María Rebolledo", NumeroTlf = "3489567", Tipo = "Entrante", Fecha = new DateTime(2013, 11, 12, 21, 14, 32) };
            Llamada llamada4 = new Llamada() { Contacto = "Luis Medea", NumeroTlf = "1978654", Tipo = "Saliente", Fecha = new DateTime(2013, 11, 2, 12, 34, 12) };
            Llamada llamada5 = new Llamada() { Contacto = "Lucía Arteaga", NumeroTlf = "8796541", Tipo = "Saliente", Fecha = new DateTime(2013, 11, 24, 17, 54, 02) };
            Llamada llamada1 = new Llamada() { Contacto = "Pedro Martínez", NumeroTlf = "1234567", Tipo = "Entrante", Fecha = new DateTime(2013, 11, 2, 12, 34, 12) };

            model.llamadas.AddLlamada(llamada1);
            model.llamadas.AddLlamada(llamada2);
            model.llamadas.AddLlamada(llamada3);
            model.llamadas.AddLlamada(llamada4);
            model.llamadas.AddLlamada(llamada5);

            return model;
        }


    }
}
