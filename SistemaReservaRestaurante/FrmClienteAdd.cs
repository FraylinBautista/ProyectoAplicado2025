using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaReservaRestaurante
{
    public partial class FrmClienteAdd : Form
    {
        // Crear el metodo para llamar los elementos en dgv
        //Cadena de Conexión 
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-375JS55; Initial Catalog=DBSistemaReservaRestaurante; Integrated security = true");

        private void CargarDatos()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                    connect.Open();

                string query = "SELECT Clienteid, Nombre, Apellidos, Telefono FROM Clientes";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Desactivar generación automática y limpiar columnas previas
                dgvclientes.AutoGenerateColumns = false;
                dgvclientes.Columns.Clear();

                // Agregar columnas manualmente
                dgvclientes.Columns.Add("Clienteid", "Clienteid");
                dgvclientes.Columns["Clienteid"].DataPropertyName = "Clienteid";

                dgvclientes.Columns.Add("Nombre", "Nombre");
                dgvclientes.Columns["Nombre"].DataPropertyName = "Nombre";

                dgvclientes.Columns.Add("Apellidos", "Apellidos");
                dgvclientes.Columns["Apellidos"].DataPropertyName = "Apellidos";

                dgvclientes.Columns.Add("Telefono", "Teléfono");
                dgvclientes.Columns["Telefono"].DataPropertyName = "Telefono";

                dgvclientes.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }


        public FrmClienteAdd()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {

            if (txtnombre.Text == "" || txtapellido.Text == ""
                || txttele.Text == "")
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
                        String checkUsername = "SELECT * FROM Clientes WHERE Nombre = '"
                            + txtnombre.Text.Trim() + "'"; // 'admin' es el nombre de nuestra tabla

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(txtnombre.Text + " ya existe", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO Clientes (Nombre, Apellidos, Telefono) " +
                                    "VALUES(@nombre, @apellido, @telefono)";
                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@nombre", txtnombre.Text.Trim());
                                    cmd.Parameters.AddWithValue("@apellido", txtapellido.Text.Trim());
                                    cmd.Parameters.AddWithValue("@telefono", txttele.Text.Trim());


                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Cliente Registrado", "Mensaje de Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CargarDatos();
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
        // eventos de inicio del formulario
        private void FrmClienteAdd_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        // Funcionalidades Para Eliminar
        int idSeleccionado = -1; // Variable global para almacenar el ID de la fila actual
        private void btbeliminar_Click(object sender, EventArgs e)
        {
            
                if (idSeleccionado == -1)
                {
                    MessageBox.Show("Mueve el cursor sobre un cliente antes de eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("¿Está seguro de eliminar este cliente?",
                                                      "Confirmación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (connect.State != ConnectionState.Open)
                            connect.Open();

                        string query = "DELETE FROM Clientes WHERE Clienteid = @id";
                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", idSeleccionado);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Cliente eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        idSeleccionado = -1; // Resetear variable
                        CargarDatos(); // Refrescar el DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

        }

        private void dgvclientes_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
           
            //Para eliminar
            if (e.RowIndex >= 0) // Verificamos que no sea la cabecera
                {
                    idSeleccionado = Convert.ToInt32(dgvclientes.Rows[e.RowIndex].Cells["Clienteid"].Value);
                }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            Hide();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

            
                if (idSeleccionado == -1)
                {
                    MessageBox.Show("Mueve el cursor sobre un cliente antes de modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtnombre.Text == "" || txtapellido.Text == "" || txttele.Text == "")
                {
                    MessageBox.Show("Por favor, complete todos los campos", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("¿Está seguro de modificar este cliente?",
                                                      "Confirmación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (connect.State != ConnectionState.Open)
                            connect.Open();

                        string query = "UPDATE Clientes SET Nombre = @nombre, Apellidos = @apellido, Telefono = @telefono WHERE Clienteid = @id";
                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {
                            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text.Trim());
                            cmd.Parameters.AddWithValue("@apellido", txtapellido.Text.Trim());
                            cmd.Parameters.AddWithValue("@telefono", txttele.Text.Trim());
                            cmd.Parameters.AddWithValue("@id", idSeleccionado);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Cliente modificado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        idSeleccionado = -1; // Resetear variable
                        CargarDatos(); // Refrescar el DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
             

        }
        //Cuando dor enter carga la edicion de modificar 
        private void dgvclientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Detectar la tecla Enter
            {
                e.SuppressKeyPress = true; // Evitar que el DataGridView haga un salto de línea automático

                if (dgvclientes.CurrentRow != null) // Verificar que haya una fila seleccionada
                {
                    DataGridViewRow fila = dgvclientes.CurrentRow;
                    idSeleccionado = Convert.ToInt32(fila.Cells["Clienteid"].Value);

                    // Cargar los datos en los TextBox
                    txtnombre.Text = fila.Cells["Nombre"].Value.ToString();
                    txtapellido.Text = fila.Cells["Apellidos"].Value.ToString();
                    txttele.Text = fila.Cells["Telefono"].Value.ToString();
                }
            }
        }
    }
}
