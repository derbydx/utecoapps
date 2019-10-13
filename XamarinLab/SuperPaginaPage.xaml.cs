using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XamarinLab
{
    public class Fruta
    {
        public string Imagen { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }

    public partial class SuperPaginaPage : ContentPage
    {
        List<Fruta> frutas = new List<Fruta>();

        public SuperPaginaPage()
        {
            frutas.Add(new Fruta() { Nombre = "Uteco", Imagen = "logo.png", Descripcion ="Una universidad" });
            frutas.Add(new Fruta() { Nombre = "Manzana", Imagen = "Manzana.jpeg", Descripcion = "Una manzana" });
            frutas.Add(new Fruta() { Nombre = "Pera", Imagen = "Pera.jpeg", Descripcion = "Una Pera" });
            frutas.Add(new Fruta() { Nombre = "Manzana" });

            InitializeComponent();
            Listado.ItemsSource = frutas;
        }
    }
}
