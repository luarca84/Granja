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
        List<Vaca> vacas;
        List<Tractor> tractores;
        List<Gasto> gastos;

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

        internal List<Vaca> Vacas
        {
            get
            {
                return vacas;
            }

            set
            {
                vacas = value;
            }
        }

        internal List<Tractor> Tractores
        {
            get
            {
                return tractores;
            }

            set
            {
                tractores = value;
            }
        }

        internal List<Gasto> Gastos
        {
            get
            {
                return gastos;
            }

            set
            {
                gastos = value;
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

        public void LoadTables()
        {
            LoadTableVacas();
            LoadTableTractores();
            LoadTableGastos();
        }

        private void LoadTableVacas()
        {
            vacas = new List<Vaca>();
            string sql = "select * from vacas";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Vaca v = new Vaca();
                v.IdVaca = int.Parse(reader["IdVaca"].ToString());
                v.Nombre = reader["Nombre"].ToString();
                vacas.Add(v);
            }
        }

        private void LoadTableTractores()
        {
            tractores = new List<Tractor>();
            string sql = "select * from tractores";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Tractor t = new Tractor();
                t.IdTractor = int.Parse(reader["IdTractor"].ToString());
                t.Nombre = reader["Nombre"].ToString();
                tractores.Add(t);
            }
        }

        private void LoadTableGastos()
        {
            gastos = new List<Gasto>();
            string sql = "select * from gastos";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Gasto g = new Gasto();
                g.IdGasto = int.Parse(reader["IdGasto"].ToString());
                g.Nombre = reader["Nombre"].ToString();
                g.Cantidad = double.Parse(reader["Cantidad"].ToString());
                gastos.Add(g);
            }
        }
    }
}
