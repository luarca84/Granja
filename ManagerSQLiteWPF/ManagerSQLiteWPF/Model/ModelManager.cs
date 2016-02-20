using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSQLiteWPF.Model
{
    class ModelManager
    {
        static ModelManager instance = new ModelManager();
        SQLiteConnection m_dbConnection;

        private ModelManager() { }

        internal static ModelManager Instance
        {
            get
            {
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        public void ConnectToDataBase()
        {            
            m_dbConnection = new SQLiteConnection("Data Source=DataBase/granja.sqlite;Version=3;");
            m_dbConnection.Open();
        }

        public List<string> GetLstVacas()
        {
            List<string> lstVacas = new List<string>();
            string sql = "select Nombre from vacas";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lstVacas.Add(reader["Nombre"].ToString());
            }
            return lstVacas;
        }
    }
}
