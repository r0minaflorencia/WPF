using GrupoN.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoN.DB
{

    internal class DB
    {
        private readonly string _connection;
        public string Connection => _connection;

        public DB()
        {
            _connection = @"Server=DESKTOP-PRJRN6F\DBSERVER; Database=GrupoN;";
        }

        internal ObservableCollection<ProfesorModel> Get()
        {
            ObservableCollection<ProfesorModel> lastResult = new ObservableCollection<ProfesorModel>();

            string query = "SELECT * FROM profesores";

            using (SqlConnection connect = new SqlConnection(Connection))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(query, connect);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lastResult.Add(new ProfesorModel()
                    {
                        Id = (int)reader["ID"],
                        Nombre = (string)reader["NOMBRE"],
                        Apellido = (string)reader["APELLIDO"],
                        Especialidad = (string)reader["ESPECIALIDAD"]
                    });
                }
                reader.Close();
                connect.Close();
            }

        }


    }

}