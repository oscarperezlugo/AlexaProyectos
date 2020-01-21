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


        public MainPage()
        {
            InitializeComponent();

            
                

            

            

        }
        public async void Registro_Clicked(object sender, EventArgs args)
        {
            IUserDialogs Dialogs = UserDialogs.Instance;
            Scan scan = new Scan();
            scan.articulo = Articulo.Text;
            scan.articulo = Almacen.Text;
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
            if (mensaje.message == null)
            {
                Dialogs.ShowLoading("Registro Exitoso");
                await Task.Delay(2000);
                Dialogs.HideLoading();
            }
            else
            {
                Dialogs.ShowLoading(mensaje.message.ToString());
                await Task.Delay(2000);
                Dialogs.HideLoading();
            }
        }



    }
}
        




    



