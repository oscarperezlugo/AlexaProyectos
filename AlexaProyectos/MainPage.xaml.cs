using System;
using Acr.UserDialogs;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using ZXing;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AlexaProyectos.models;
using AlexaProyectos.viewmodels;
using System.Windows.Input;
using System.Runtime.CompilerServices;
using AlexaProyectos.Servicios;

namespace AlexaProyectos
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        string descripcion;
        string tipo;
        decimal factor;
        decimal precio;
        decimal precioventa;

        public MainPage()
        {
            InitializeComponent();
            
            
            
        }
        protected async void OnAppearing()
        {
            Repositorio repo = new Repositorio();
            Alamacenes listalmacenes = repo.getAlmacenes();
            foreach (var item in listalmacenes.CodigoAlmacen.ToString())
            {
                base.OnAppearing();
                Almacen.Items.Add(item.ToString());
            }
        }
            public async void Registro_Clicked(object sender, EventArgs args)
        {
            IUserDialogs Dialogs = UserDialogs.Instance;
            Scan scan = new Scan();
            scan.articulo = Articulo.Text;
            scan.almacen = Almacen.SelectedItem.ToString();
            scan.capitulo = Capitulo.Text;
            scan.lote = Lote.Text;
            scan.proyecto = Proyecto.Text;
            scan.fecha = Fecha.ToString();
            if (Cargo != null)
            {
                scan.unidad = "1";
            }
            else
            {
                scan.unidad = "-1";
            }
            Repositorio repositorio = new Repositorio();
            Retorno mensaje = repositorio.postRegistro(scan).Result;
            Dialogs.ShowLoading(mensaje.Message);
            Retorno coste = repositorio.getCoste(scan).Result;
            Retorno datos = repositorio.getArticulo(scan).Result;
            precio = coste.PrecioCoste;
            factor = datos.FactorConversion_;
            tipo = datos.TipoArticulo;
            descripcion = datos.DescripcionArticulo;
            precioventa = datos.PrecioVenta;
            Retorno envio = new Retorno();
            envio.PrecioCoste = precio;
            envio.FactorConversion_ = factor;
            envio.TipoArticulo = tipo;
            envio.DescripcionArticulo = descripcion;
            envio.PrecioVenta = precioventa;
            envio.articulo = Articulo.Text;
            envio.almacen = Almacen.SelectedItem.ToString();
            envio.capitulo = Capitulo.Text;
            envio.lote = Lote.Text;
            envio.proyecto = Proyecto.Text;
            envio.fecha = Fecha.ToString();                        
            Articulo myHomePage = new Articulo(envio);
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            await Navigation.PushModalAsync(myHomePage);
        }



    }
}
        




    



