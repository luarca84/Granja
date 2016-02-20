using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSQLiteWPF.Model
{
    class Tractor
    {
        int idTractor;
        string nombre;

        public int IdTractor
        {
            get
            {
                return idTractor;
            }

            set
            {
                idTractor = value;
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
