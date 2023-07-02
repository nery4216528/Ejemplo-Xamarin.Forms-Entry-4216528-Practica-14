using System;

using Xamarin.Forms;

namespace Video6

{

    public partial class MainPage : ContentPage

    {

        public MainPage()

        {

            InitializeComponent();

        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)

            // Creamos dos variables las cuales seran las encargadas de almacenar todos los datos enviados desde el Entry //
        {

            string Pasado = e.OldTextValue;

            string Nuevo = e.NewTextValue;

        }

        private void Entry_Completed(object sender, EventArgs e)

            // Esta funcion nos permite guardar en una cadena string el contenido que ingrese en el Entry//

        {

            string text = ((Entry)sender).Text;

        }

    }

}
