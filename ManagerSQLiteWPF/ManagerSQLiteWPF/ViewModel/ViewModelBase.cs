using ManagerSQLiteWPF.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSQLiteWPF
{
    class ViewModelBase
    {
        List<string> lstVacas = new List<string>();
        List<string> lstTractores = new List<string>();
        List<string> lstGastos = new List<string>();

        public ViewModelBase()
        {
            ModelManager.Instance.ConnectToDataBase();
            ModelManager.Instance.LoadTables();
            lstVacas = ModelManager.Instance.GetLstVacas();
            LstTractores = ModelManager.Instance.Tractores.Select(e => e.Nombre).ToList();
            LstGastos = ModelManager.Instance.Gastos.Select(e => e.Nombre).ToList();       
        }

        public List<string> LstVacas
        {
            get
            {
                return lstVacas;
            }

            set
            {
                lstVacas = value;
            }
        }

        public List<string> LstTractores
        {
            get
            {
                return lstTractores;
            }

            set
            {
                lstTractores = value;
            }
        }

        public List<string> LstGastos
        {
            get
            {
                return lstGastos;
            }

            set
            {
                lstGastos = value;
            }
        }
    }
}
