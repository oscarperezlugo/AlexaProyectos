using System;
using System.Collections.Generic;
using System.Text;

namespace AlexaProyectos.models
{
    public class Scan
    {
        public string articulo { get; set; }
        public string almacen { get; set; }
        public string proyecto { get; set; }
        public string lote { get; set; }
        public string capitulo { get; set; }
        public string unidad { get; set; }
        public string fecha { get; set; }
        public string codigo { get; set; }
        public string CodigoArticulos { get; set; }
        public string CodigoAlmacens { get; set; }

    }
    public class Send
    {
        public string CodigoProyecto { get; set; }
        public string AnaCapitulo { get; set; }
        public string AnaLote { get; set; }
    }
    public class Retorno
    {
        public string retorno { get; set; }
        public string Message { get; set; }
        public decimal PrecioCoste { get; set; }
        public string DescripcionArticulo { get; set; }
        public string TipoArticulo { get; set; }
        public decimal FactorConversion_ { get; set; }
        public decimal PrecioVenta { get; set; }
        public string articulo { get; set; }
        public string almacen { get; set; }
        public string proyecto { get; set; }
        public string lote { get; set; }
        public string capitulo { get; set; }
        public string unidad { get; set; }
        public string fecha { get; set; }
        public string codigo { get; set; }
        public string CodigoArticulos { get; set; }
        public string CodigoAlmacens { get; set; }

    }
    public class LineasParteTrabajo
    {
        public short CodigoEmpresa { get; set; }
        public int EjercicioParteTrabajo { get; set; }
        public string SerieParteTrabajo { get; set; }
        public int NumeroParteTrabajo { get; set; }
        public short TipoCodificado { get; set; }
        public System.Guid LineasPosicion { get; set; }
        public string CodigoArticulo { get; set; }
        public string DescripcionArticulo { get; set; }
        public string DescripcionLinea { get; set; }
        public decimal Unidades { get; set; }
        public decimal PrecioCoste { get; set; }
        public decimal PrecioVenta { get; set; }
        public string CodigoEmpleadoLc { get; set; }
        public string CodigoProyecto { get; set; }
        public string AnaCapitulo { get; set; }
        public string AnaLote { get; set; }
        public System.Guid IdTareaLc { get; set; }
        public string CodigoAlmacen { get; set; }
        public string Partida { get; set; }
        public string Medida { get; set; }
        public short LiquidableLc { get; set; }
        public short PrecioCosteEditableLc { get; set; }
        public short SonHorasLc { get; set; }
        public decimal Importe { get; set; }
        public decimal ImporteCoste { get; set; }
        public decimal MaximoSinRetencionLc { get; set; }
        public decimal ImporteConRetencionLc { get; set; }
        public string CodigoMunicipio { get; set; }
        public string Municipio { get; set; }
        public string TrayectoLc { get; set; }
        public short LiquidadoLc { get; set; }
        public short EjercicioLiquidacionLc { get; set; }
        public string SerieLiquidacionLc { get; set; }
        public int NumeroLiquidacionLc { get; set; }
        public System.DateTime Fecha { get; set; }
        public string TipoArticulo { get; set; }
        public string CodigoFamilia { get; set; }
        public string CodigoSubfamilia { get; set; }
        public short BloqueoRebaje_ { get; set; }
        public string CodigoDefinicion_ { get; set; }
        public string CodigoActividadParteLc { get; set; }
        public string CodigoGastoComercialLc { get; set; }
        public string Comentarios { get; set; }
        public string IdDelegacionTecnicoLc { get; set; }
        public string CodigoDepartamentoTecnicoLc { get; set; }
        public string NombreTareaLc { get; set; }
        public short TratamientoPartidas { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public string UnidadMedida1_ { get; set; }
        public decimal FactorConversion_ { get; set; }
        public decimal Unidades2_ { get; set; }
        public short StatusStock { get; set; }
        public short StatusAnalitica { get; set; }
        public System.Guid MovAnalitica { get; set; }
    }
    public class Alamacenes
    {
        public int CodigoEmpresa { get; set; }
        public string CodigoAlmacen { get; set; }
        public string GrupoAlmacen { get; set; }
        public string Responsable { get; set; }
        public string Almacen { get; set; }
        public string Domicilio { get; set; }
        public string CodigoPostal { get; set; }
        public string CodigoMunicipio { get; set; }
        public string Municipio { get; set; }
        public string CodigoProvincia { get; set; }
        public string Provincia { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public int AgruparMovimientos { get; set; }
        public string IdDelegacion { get; set; }
        public string IdAlmacen { get; set; }
    }
}
