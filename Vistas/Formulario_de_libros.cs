using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionBiblioteca.Vistas
{
    public partial class Formulario_de_libros : Form
    {
        public Formulario_de_libros()
        {
            InitializeComponent();
        }

        private void Formulario_de_libros_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=DANIEL;Initial Catalog=biblioteca;Integrated Security=True;Encrypt=False");

            try
            {

                // Abrir la conexión
                sql.Open();

                // Configurar el comando para ejecutar el procedimiento almacenado
                SqlCommand command = new SqlCommand("GestionarLibros", sql);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros necesarios
                command.Parameters.AddWithValue("@Accion", "Agregar");
                command.Parameters.AddWithValue("@Titulo", titulo);
                command.Parameters.AddWithValue("@Autor", autor);
                command.Parameters.AddWithValue("@Editorial", editorial);
                command.Parameters.AddWithValue("@AñoPublicacion", añoPublicacion);
                command.Parameters.AddWithValue("@Genero", genero);
                command.Parameters.AddWithValue("@NumeroCopias", numeroCopias);

                // Ejecutar el procedimiento almacenado
                int rowsAffected = command.ExecuteNonQuery();

                // Verificar si se insertó el libro correctamente
                if (rowsAffected > 0)
                {
                    Console.WriteLine("El libro fue insertado correctamente.");
                }
                else
                {
                    Console.WriteLine("No se insertó el libro.");
                }
            }
            catch (Exception ex)
            {
                // Manejar errores
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión


                sql.Close();
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=DANIEL;Initial Catalog=biblioteca;Integrated Security=True;Encrypt=False");

            try
            {

                // Abrir la conexión
                sql.Open();

                // Configurar el comando para ejecutar el procedimiento almacenado
                SqlCommand command = new SqlCommand("GestionarLibros", sql);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros necesarios
                command.Parameters.AddWithValue("@Accion", "Agregar");
                command.Parameters.AddWithValue("@ISBN", ISBN.Text);
                command.Parameters.AddWithValue("@Titulo", titulo.Text);
                command.Parameters.AddWithValue("@Autor", autor.Text);
                command.Parameters.AddWithValue("@Editorial", editorial.Text);
                command.Parameters.AddWithValue("@AñoPublicacion", Convert.ToInt32(añoPublicacion.Text));
                command.Parameters.AddWithValue("@Genero", genero.Text);
                command.Parameters.AddWithValue("@NumeroCopias", Convert.ToInt32(numeroCopias.Text));

                // Ejecutar el procedimiento almacenado
                int rowsAffected = command.ExecuteNonQuery();

                // Verificar si se insertó el libro correctamente

                {
                    MessageBox.Show("El libro fue insertado correctamente.");
                }

                {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        
       private void buscar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=DANIEL;Initial Catalog=biblioteca;Integrated Security=True;Encrypt=False");

            try
            {
                // Abrir la conexión
                sql.Open();

                // Configurar el comando para ejecutar el procedimiento almacenado
                SqlCommand command = new SqlCommand("GestionarLibros", sql);
                command.CommandType = CommandType.StoredProcedure;

                // Configurar los parámetros necesarios para buscar
                command.Parameters.AddWithValue("@Accion", "Buscar");
                command.Parameters.AddWithValue("@Titulo", buscartitulo.Text);

                // Ejecutar el comando y leer los resultados
                SqlDataReader reader = command.ExecuteReader();

                // Verificar si hay resultados
                if (reader.Read())
                {
                    // Llenar los TextBox con los valores del libro encontrado
                    ISBN.Text = reader["ISBN"].ToString();
                    titulo.Text = reader["Titulo"].ToString();
                    autor.Text = reader["Autor"].ToString();
                    editorial.Text = reader["Editorial"].ToString();
                    añoPublicacion.Text = reader["AñoPublicacion"].ToString();
                    genero.Text = reader["Genero"].ToString();
                    numeroCopias.Text = reader["NumeroCopias"].ToString();

                    MessageBox.Show("Libro encontrado.");
                }
                else
                {
                    MessageBox.Show("No se encontró un libro con ese título.");
                }

                // Cerrar el reader
                reader.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=DANIEL;Initial Catalog=biblioteca;Integrated Security=True;Encrypt=False");

            try
            {
                // Abrir la conexión
                sql.Open();

                // Configurar el comando para ejecutar el procedimiento almacenado
                SqlCommand command = new SqlCommand("GestionarLibros", sql);
                command.CommandType = CommandType.StoredProcedure;

                // Configurar los parámetros necesarios para editar
                command.Parameters.AddWithValue("@Accion", "Editar");
                command.Parameters.AddWithValue("@ISBN", ISBN.Text);
                command.Parameters.AddWithValue("@Titulo", titulo.Text);
                command.Parameters.AddWithValue("@Autor", autor.Text);
                command.Parameters.AddWithValue("@Editorial", editorial.Text);
                command.Parameters.AddWithValue("@AñoPublicacion", Convert.ToInt32(añoPublicacion.Text));
                command.Parameters.AddWithValue("@Genero", genero.Text);
                command.Parameters.AddWithValue("@NumeroCopias", Convert.ToInt32(numeroCopias.Text));

                // Ejecutar el procedimiento almacenado
                int rowsAffected = command.ExecuteNonQuery();

                // Verificar si se actualizó el libro correctamente
                if (rowsAffected > 0)
                {
                    MessageBox.Show("El libro fue editado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo editar el libro.");
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


        private void borrar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=DANIEL;Initial Catalog=biblioteca;Integrated Security=True;Encrypt=False");

            try
            {
                // Abrir la conexión
                sql.Open();

                // Configurar el comando para ejecutar el procedimiento almacenado
                SqlCommand command = new SqlCommand("GestionarLibros", sql);
                command.CommandType = CommandType.StoredProcedure;

                // Configurar los parámetros necesarios para eliminar
                command.Parameters.AddWithValue("@Accion", "Eliminar");
                command.Parameters.AddWithValue("@Titulo", titulo.Text);

                // Ejecutar el procedimiento almacenado
                int rowsAffected = command.ExecuteNonQuery();

                // Verificar si se eliminó el libro correctamente
                if (rowsAffected > 0)
                {
                    MessageBox.Show("El libro fue eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el libro.");
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