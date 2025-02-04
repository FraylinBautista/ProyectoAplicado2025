using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginRegistrationForm
{
    public partial class FrmRegistrar : Form
    {
        //Cadena de Conexión 
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-375JS55; Initial Catalog=DBSistemaReservaRestaurante; Integrated security = true");

        public FrmRegistrar()
        {
            InitializeComponent();
        }

        private void signup_loginHere_Click(object sender, EventArgs e)
        {
            FrmLogin2 lForm = new FrmLogin2();
            lForm.Show();
            this.Hide();
        }

        private void signup_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (signup_email.Text == "" || signup_username.Text == ""
                || signup_password.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        String checkUsername = "SELECT * FROM Usuarios WHERE Correo = '"
                            + signup_username.Text.Trim() + "'"; // 'admin' es el nombre de nuestra tabla

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(signup_username.Text + " ya existe", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO Usuarios (Correo, Nombre, Clave) " +
                                    "VALUES(@correo, @nombre, @clave)";

                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@correo", signup_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@nombre", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@clave", signup_password.Text.Trim());
                                    

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registro exitoso", "Mensaje de Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // CAMBIAR DE FORMULARIO 
                                    FrmLogin2 lForm = new FrmLogin2();
                                    lForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al conectar con la base de datos: " + ex, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_showPass.Checked)
            {
                signup_password.PasswordChar = '\0';
            }
            else
            {
                signup_password.PasswordChar = '*';
            }
        }
    }
}
