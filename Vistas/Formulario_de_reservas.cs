using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaGestionBiblioteca.Vistas
{
    public partial class Formulario_de_reservas : Form
    {
        public Formulario_de_reservas()
        {
            InitializeComponent();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            // Obtener la conexión a la base de datos
            SqlConnection sql = new SqlConnection("Data Source=DANIEL;Initial Catalog=biblioteca;Integrated Security=True;Encrypt=False");

            try
            {
                // Abrir la conexión
                sql.Open();

                // Configurar el comando para ejecutar el procedimiento almacenado
                SqlCommand command = new SqlCommand("GestionarReservas", sql);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros necesarios
                command.Parameters.AddWithValue("@Accion", "Agregar");
                command.Parameters.AddWithValue("@Usuario", Usuarioreserva.Text);
                command.Parameters.AddWithValue("@LibroReservado",Reservado.Text);
                command.Parameters.AddWithValue("@FechaReserva", DateTime.Now);
                command.Parameters.AddWithValue("@FechaRetorno", DateTime.Now.AddDays(5));

                // Ejecutar el procedimiento almacenado
                int rowsAffected = command.ExecuteNonQuery();

                // Verificar si se insertó la reserva correctamente
                if (rowsAffected > 0)
                {
                    MessageBox.Show("La reserva fue insertada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo insertar la reserva.");
                }
            }
            catch (Exception ex)
            {
                // Manejar errores
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                sql.Close();
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            // Obtener la conexión a la base de datos
            SqlConnection sql = new SqlConnection("Data Source=DANIEL;Initial Catalog=biblioteca;Integrated Security=True;Encrypt=False");

            try
            {
                // Abrir la conexión
                sql.Open();

                // Configurar el comando para ejecutar el procedimiento almacenado
                SqlCommand command = new SqlCommand("GestionarReservas", sql);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros necesarios
                command.Parameters.AddWithValue("@Accion", "Buscar");
                command.Parameters.AddWithValue("@Usuario", Usuarioreserva.Text);

                // Crear un adaptador para llenar un DataTable con los resultados
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Si se encuentra al menos una reserva, llenar los TextBoxes con los datos
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    
                    Reservado.Text = row["LibroReservado"].ToString();
                    FechaReserva.Text = Convert.ToDateTime(row["FechaReserva"]).ToString("yyyy-MM-dd");
                    FechaRetorno.Text = Convert.ToDateTime(row["FechaRetorno"]).ToString("yyyy-MM-dd");

                    MessageBox.Show("Reserva encontrada y datos cargados.");
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna reserva para el usuario especificado.");
                }
            }
            catch (Exception ex)
            {
                // Manejar errores
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                sql.Close();
            }
        }
    }
}
