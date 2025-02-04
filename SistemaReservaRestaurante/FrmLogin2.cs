using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using CarWashManagementSystem;
using SistemaReservaRestaurante;

namespace LoginRegistrationForm
{
    public partial class FrmLogin2 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\WINDOWS 10\Documents\loginData.mdf;Integrated Security=True;Connect Timeout=30");
        public FrmLogin2()
        {
            InitializeComponent();
        }

        private void login_registerHere_Click(object sender, EventArgs e)
        {
            FrmRegistrar sForm = new FrmRegistrar();
            sForm.Show();
            this.Hide();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showPass.Checked)
            {
                login_password.PasswordChar = '\0';
            }
            else
            {
                login_password.PasswordChar = '*';
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
        //Configuracion de conexion 
           SqlConnection connect = new SqlConnection("Data Source=DESKTOP-375JS55; Initial Catalog=DBSistemaReservaRestaurante; Integrated security = true");
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos vacíos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         else
            {
              if(connect.State != ConnectionState.Open)
                {
                    try
                     {
                connect.Open();

                String selectData = "SELECT * FROM Usuarios WHERE Correo = @username AND Clave = @pass";
                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@username", login_username.Text);
                    cmd.Parameters.AddWithValue("@pass", login_password.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if(table.Rows.Count >= 1)
                    {
                        //MessageBox.Show("Inicio de sesión exitoso", "Mensaje de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               
                        FrmLoading load = new FrmLoading();
                        load.Show();
                        Hide();
                            }
                            else
                    {
                        MessageBox.Show("Usuario/contraseña incorrectos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
                    }
                }
            } 
        }
    }
}
