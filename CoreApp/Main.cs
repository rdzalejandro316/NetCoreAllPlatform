using CoreApp.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CoreApp
{
    public class Main
    {
        public string connection = "Data Source=64.250.116.210,8334;Initial Catalog = Milanelo_Emp010; User ID = sa; Password=Q1w2e3r4*/*";

        public Tercero LoadTercero()
        {
            Tercero tercero = new Tercero();


            string query = "select * From Comae_ter where cod_ter='1033796537'";
            DataTable dt = LoadDatatable(query, connection);
            if (dt != null)
            {
                tercero.cod_ter = dt.Rows[0]["cod_ter"].ToString();
                tercero.nom_ter = dt.Rows[0]["nom_ter"].ToString();
                tercero.tel1 = dt.Rows[0]["tel1"].ToString();
                tercero.cel1 = dt.Rows[0]["cel"].ToString();
                tercero.email = dt.Rows[0]["email"].ToString();
            }
            else
            {
                tercero.cod_ter = "vacio";
                tercero.nom_ter = "vacio";
                tercero.tel1 = "vacio";
                tercero.cel1 = "vacio";
                tercero.email = "vacio";
            }

            return tercero;
        }


        public DataTable LoadDatatable(string query, string conn)
        {
            try
            {
                DataTable table = new DataTable();
                using (SqlConnection connection = new SqlConnection(conn))
                {

                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                    table.Load(reader);
                    reader.Close();
                    connection.Close();
                    return table;
                }
            }
            catch (Exception w)
            {
                return null;
            }
        }

        public string retstring()
        {
            return "bebe";
        }

    }
}
