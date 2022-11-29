using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApp01{
    public partial class MainPage : ContentPage{
        // El public tiene que tener el mismo nombre
        public MainPage(){
            //Pagina de Inicilizacion
            InitializeComponent();
            //Especificando la pagina de arranque
            //Main Page=new MainPage();
            var entry = new Entry();
            entry.TextColor = Color.Green;
        }
        private void Editor_TextChanged(object sender, TextChangedEventArgs e){
            string pasado = e.OldTextValue;
            string nuevo = e.NewTextValue;
        }
        private void Editor_Completed(object sender, TextChangedEventArgs e){
            string textFinal = ((Editor)sender).Text;
        }
    }
}   
