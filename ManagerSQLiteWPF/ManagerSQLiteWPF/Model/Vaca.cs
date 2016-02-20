using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSQLiteWPF.Model
{
    class Vaca
    {
        int idVaca;
        string nombre;

        public int IdVaca
        {
            get
            {
                return idVaca;
            }

            set
            {
                idVaca = value;
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
    }
}
