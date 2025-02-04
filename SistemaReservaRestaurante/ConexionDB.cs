using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaReservaRestaurante
{
    internal class ConexionDB
    {                                                                                                                                               // public static SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-375JS55;Initial Catalog=DespidoDeEmpleadoDb;Integrated Security=True;Encrypt=False");
                                                                                                                                                     // private  static SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-375JS55; Initial Catalog=DespidoDeEmpleadoDb; Integrated security = true");
        public static SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-375JS55; Initial Catalog=DBSistemaReservaRestaurante; Integrated security = true");

        public static DataTable ConsultaDB(string DespidoDeEmpleadoDb)
        {
            DataTable datos = new DataTable();
            SqlCommand cmd = new SqlCommand(DespidoDeEmpleadoDb, conectar);
            SqlDataAdapter Mensaje = new SqlDataAdapter(cmd);

            try
            {
                //datos.Clear();
                Mensaje.Fill(datos);
                conectar.Open();
                Mensaje.SelectCommand.ExecuteNonQuery();
                //MessageBox.Show("Conectado");
                conectar.Close();
            }
            catch
            {
                MessageBox.Show("Error");
                if (datos == null)
                {
                    MessageBox.Show("No Hay Registro");
                    conectar.Close();
                }
            }
            return datos;
        }

    }
}
