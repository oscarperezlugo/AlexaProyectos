using System;
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
                

            

            

        }


    }
}
        




    



