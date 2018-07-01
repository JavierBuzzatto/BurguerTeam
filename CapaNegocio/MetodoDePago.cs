using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{ 
    public class MetodoDePago

{
    #region Variables Miembro
    private string medioDePago;
    private static List<MetodoDePago> metodosdepagos = new List<MetodoDePago>();


    #endregion
    #region Properties



    public static List<MetodoDePago> Metodosdepagos
    {
        get
        {
            return metodosdepagos;
        }

        set
        {
            metodosdepagos = value;
        }
    }

    public string MedioDePago
    {
        get
        {
            return medioDePago;
        }

        set
        {
            medioDePago = value;
        }
    }
    #endregion
    #region Constructores
    public MetodoDePago(string medioDePago)
    {
        this.MedioDePago = medioDePago;

    }
    public MetodoDePago()
    {
        this.MedioDePago = null;
    }

    #endregion
    #region METODOS
    public void Agregar()
    {
        MetodoDePago.Metodosdepagos.Add(this);
    }

    public static void CargarMetDePagos()
    {
        new MetodoDePago("Efectivo").Agregar();
        new MetodoDePago("Debito").Agregar();
        new MetodoDePago("Credito").Agregar();


    }

        public static List<MetodoDePago> Buscar(string busqueda)
        {
            busqueda = busqueda.ToLower().Trim();
            List<MetodoDePago> resultados = new List<MetodoDePago>();

            if (busqueda != "")
            {
                foreach (MetodoDePago m in metodosdepagos)
                {
                    if (m.medioDePago.ToLower().Contains(busqueda))
                    {
                        resultados.Add(m);
                    }
            
                }
                return resultados;
            }
            return metodosdepagos;
        }
        #endregion
        public override string ToString()
        {
            return string.Concat(medioDePago);
        }
    }

}
