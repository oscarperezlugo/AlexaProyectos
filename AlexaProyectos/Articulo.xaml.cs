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
    public partial class Articulo : ContentPage
    {
        string articulo;
        string Almacen;
        string Capitulo;
        string Lote;
        string proyecto;
        string fecha;

        public Articulo(Retorno recibo)
        {
            
            InitializeComponent();


            desc.Text = recibo.DescripcionArticulo;
            precio.Text = recibo.PrecioCoste.ToString();
            tipo.Text = recibo.TipoArticulo;
            factor.Text = recibo.FactorConversion_.ToString();
            precioventa.Text = recibo.PrecioVenta.ToString();
            fecha = recibo.fecha;
            proyecto = recibo.proyecto;
            Lote = recibo.lote;
            Capitulo = recibo.capitulo;
            Almacen = recibo.almacen;
            articulo = recibo.articulo;
        }
        public async void Registro_Clicked(object sender, EventArgs args)
        {
            IUserDialogs Dialogs = UserDialogs.Instance;
            Retorno reposend = new Retorno();
            reposend.PrecioCoste = Decimal.Parse(precio.Text);
            reposend.FactorConversion_ = Decimal.Parse(factor.Text);
            reposend.DescripcionArticulo = desc.Text;
            reposend.TipoArticulo = tipo.Text;
            reposend.PrecioVenta = Decimal.Parse(precioventa.Text);
            reposend.fecha = fecha;
            reposend.proyecto = proyecto;
            reposend.lote = Lote;
            reposend.capitulo = Capitulo;
            reposend.almacen = Almacen;
            reposend.articulo = articulo;
            Repositorio repositorio = new Repositorio();
            Retorno mensaje = repositorio.postLineas(reposend).Result;                        
            await Task.Delay(2000);
            if (mensaje.Message != null)
            {
                Dialogs.ShowLoading(mensaje.Message);
            }
            else
            {
                Dialogs.ShowLoading("Registro Exitoso");
            }
        }




    }
}
        




    



