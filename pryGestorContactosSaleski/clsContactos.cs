using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace pryGestorContactosSaleski
{
    internal class clsContactos
    {
        OleDbConnection conexionBD = new OleDbConnection();
        OleDbCommand comandoBD = new OleDbCommand();
        OleDbDataReader lectorBD;
        OleDbDataAdapter adaptadorBD = new OleDbDataAdapter();
        //DataSet objDS;

        string cadenaDeConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\Contacto.accdb";

        public string EstadoDeConexion = "";
        private string Tabla = "Contactos";
        private string Tabla2 = "Categoria";
        string num;
        string nom;
        string ape;

        Int32 cate;
        string co;
        Int32 id;
        public Int32 ID_Contacto
        {
            get { return id; }
            set { id = value; }
        }
        public string Numero
        {
            get { return num; }
            set { num = value; }
        }
        public string Apellido
        {
            get { return ape; }
            set { ape = value; }
        }
        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public Int32 Categoria
        {
            get { return cate; }
            set { cate = value; }
        }

        public string Correo
        {
            get { return co; }
            set { co = value; }
        }

        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaDeConexion;
                conexionBD.Open();
                EstadoDeConexion = "Conectado";
            }
            catch (Exception ex)
            {
                EstadoDeConexion = "Error" + ex.Message;
            }

        }
        public void AgregarContacto()
        {

            try
            {
                conexionBD.ConnectionString = cadenaDeConexion;
                conexionBD.Open();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.CommandText = Tabla;
                adaptadorBD = new OleDbDataAdapter(comandoBD);
                DataSet DS = new DataSet();
                //LLENA EL DATA SET CON LOS DATOS DE LA TABLA
                adaptadorBD.Fill(DS, Tabla);
                //RECIBE LOS DATOS
                DataTable tabla = DS.Tables[Tabla];
                DataRow Fila = tabla.NewRow();
                Fila["ID_Contacto"] = ID_Contacto;
                Fila["Numero"] = Numero;
                Fila["Nombre"] = Nombre;
                Fila["Apellido"] = Apellido;
                Fila["Correo"] = Correo;
                Fila["Categoria"] = Categoria;


                tabla.Rows.Add(Fila);

                OleDbCommandBuilder HacerCompatiblesLosCambios = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(DS, Tabla);
                conexionBD.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo registrar contacto", "ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void Buscar(Int32 i)
        {
            OleDbConnection conexionBD = new OleDbConnection();
            OleDbCommand comandoBD = new OleDbCommand();

            try
            {
                conexionBD.ConnectionString = cadenaDeConexion;
                conexionBD.Open();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.CommandText = Tabla;

                OleDbDataReader Lector = comandoBD.ExecuteReader();
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == i)
                        {
                            ID_Contacto = Lector.GetInt32(0);
                            Numero = Lector.GetString(1);
                            Nombre = Lector.GetString(2);
                            Apellido = Lector.GetString(3);
                            Correo = Lector.GetString(4);
                            Categoria = Lector.GetInt32(5);

                        }
                    }
                }

                conexionBD.Close();
            }
            catch (Exception MensajeAviso)
            {
                MessageBox.Show(MensajeAviso.Message);
            }
        }
        public void EliminarContacto(Int32 Id_Contacto)
        {
            try
            {
                string EContacto = " DELETE FROM Contactos " + "WHERE(" + Id_Contacto + "=[ID_Contacto])";
                conexionBD.ConnectionString = cadenaDeConexion;
                conexionBD.Open();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = CommandType.Text;
                comandoBD.CommandText = EContacto;
                comandoBD.ExecuteNonQuery();
                conexionBD.Close();
                MessageBox.Show("Contacto Eliminado con éxito");
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show("El Contacto no se pudo eliminar " + Mensaje.Message);
                //throw;
            }
        }
        public void ModificarContacto(Int32 id_Contacto)
        {
            try
            {
                using (OleDbConnection conexionBD = new OleDbConnection(cadenaDeConexion))
                {
                    conexionBD.Open();

                    // Sentencia SQL para modificar el producto con parámetros
                    string MContacto = "UPDATE Contactos SET " +
                                       "Numero = @Numero," +   
                                       "Nombre = @Nombre, " +
                                       "Apellido = @Apellido, " +
                                       "Correo = @Correo, " +
                                       "Categoria = @Categoria " +
                                       "WHERE ID_Contacto = @ID_Contacto";

                    using (OleDbCommand comandoBD = new OleDbCommand(MContacto, conexionBD))
                    {
                        // Asignar los valores a los parámetros
                        comandoBD.Parameters.AddWithValue("@Numero", OleDbType.VarChar).Value = Numero;
                        comandoBD.Parameters.AddWithValue("@Nombre", Nombre);
                        comandoBD.Parameters.AddWithValue("@Apellido", Apellido);
                        comandoBD.Parameters.AddWithValue("@Correo", Correo);
                        comandoBD.Parameters.AddWithValue("@Categoria", Categoria);
                        comandoBD.Parameters.AddWithValue("@ID_Contacto", id_Contacto);

                        // Ejecutar la actualización
                        comandoBD.ExecuteNonQuery();
                    }
                    //conexionBD.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("el Contacto no se pudo Modificar ");
                //throw;

            }

        }
        public void ListarContactos(DataGridView grilla)
        {
            try
            {
                conexionBD.ConnectionString = cadenaDeConexion;
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.CommandText = Tabla;
                conexionBD.Open();
                grilla.Rows.Clear();
                OleDbDataReader DR = comandoBD.ExecuteReader();
                clsContactos objBaseDatos = new clsContactos();
                clsCategoria objCategoria = new clsCategoria();
                string DetalleCategoria = "";
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        DetalleCategoria = objCategoria.BuscarParaGrillaa(DR.GetInt32(5));
                        grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetString(2), DR.GetString(3), DR.GetString(4), DetalleCategoria);
                    }
                }
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.Message);
                //throw;
            }

        }
        public void ListarUsuariosxCat(DataGridView GrillaUxCat, Int32 idcategoria)
        {
            try
            {
                conexionBD.ConnectionString = cadenaDeConexion;
                conexionBD.Open();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.CommandText = Tabla;

                OleDbDataReader DR = comandoBD.ExecuteReader();
                GrillaUxCat.Rows.Clear();
                //si hay filas
                if (DR.HasRows)
                {
                    //Recorro la tabla 
                    while (DR.Read())
                    {
                        //Comparo el categoria que seria el campo numero 5 con el detalle que nos enviaron desde la interfaz grafica
                        if (DR.GetInt32(5) == idcategoria)
                        {
                            GrillaUxCat.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetString(2), DR.GetString(3), DR.GetString(4));
                        }
                    }
                }
                conexionBD.Close();
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.Message);
                //throw;
            }

        }
        public List<clsContactos> BuscarContactoPorNombre(string nombre)
        {
            List<clsContactos> contactos = new List<clsContactos>();
            List<clsCategoria> categoria = new List<clsCategoria>();
            string query = "SELECT ID_Contacto, Numero, Nombre, Apellido, Correo, Categoria FROM Contactos WHERE Nombre LIKE @Nombre";

            using (OleDbConnection connection = new OleDbConnection(cadenaDeConexion))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", "%" + nombre + "%"); // El uso de % permite buscar coincidencias parciales

                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        clsContactos contacto = new clsContactos
                        {
                            ID_Contacto = Convert.ToInt32(reader["ID_Contacto"]),
                            Numero = reader["Numero"].ToString(),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Correo = reader["Correo"].ToString(),
                            Categoria = Convert.ToInt32(reader["Categoria"]),
                        };
                        contactos.Add(contacto);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al buscar el contacto: " + ex.Message);
                }
            }

            return contactos;
        }
        public void guardarArchivo()
        {
            try
            {

                conexionBD.ConnectionString = cadenaDeConexion;
                conexionBD.Open();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.CommandText = Tabla;
                OleDbDataReader DR = comandoBD.ExecuteReader();
                using (StreamWriter sw = new StreamWriter("datos.csv", false))
                {
                    sw.WriteLine("Listado de productos\n"); //n es para el salto de linea
                    sw.WriteLine();
                    sw.WriteLine("ID_Contacto;Numero;Nombre;Apellido;Correo;Categoria");
                    if (DR.HasRows)
                    {
                        while (DR.Read())
                        {
                            sw.Write(DR.GetInt32(0));
                            sw.Write(";");
                            sw.Write(DR.GetString(1));
                            sw.Write(";");
                            sw.Write(DR.GetString(2));
                            sw.Write(";");
                            sw.Write(DR.GetString(3));
                            sw.Write(";");
                            sw.Write(DR.GetString(4));
                            sw.Write(";");
                            sw.Write(DR.GetInt32(5));
                            sw.Write("\n");
                        }
                    }
                    conexionBD.Close();
                    sw.Close();
                    MessageBox.Show("Exportado con exito");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }

}
