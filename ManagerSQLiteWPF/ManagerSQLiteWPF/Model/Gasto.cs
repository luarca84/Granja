using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSQLiteWPF.Model
{
    class Gasto
    {
        int idGasto;
        string nombre;
        double cantidad;

        public int IdGasto
        {
            get
            {
                return idGasto;
            }

            set
            {
                idGasto = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public double Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }
    }
}
