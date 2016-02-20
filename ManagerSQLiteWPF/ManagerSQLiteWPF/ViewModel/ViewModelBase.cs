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

        public ViewModelBase()
        {
            ModelManager.Instance.ConnectToDataBase();
            lstVacas = ModelManager.Instance.GetLstVacas();         
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
    }
}
