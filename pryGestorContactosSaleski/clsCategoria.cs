using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryGestorContactosSaleski
{
    internal class clsCategoria
    {

        OleDbConnection conexionBD = new OleDbConnection();
        OleDbCommand comandoBD = new OleDbCommand();
        OleDbDataReader lectorBD;
        OleDbDataAdapter adaptadorBD = new OleDbDataAdapter();
        //DataSet objDS;

        string cadenaDeConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\Contacto.accdb";

        public string EstadoDeConexion = "";
        private string Tabla = "Contactos";
        private string Tabla2 = "Categorias";
        Int32 id_c;
        string deta;
        public Int32 Id_Categoria
        {
            get { return id_c; }
            set { id_c = value; }
        }
        public string Detalle
        {
            get { return deta; }
            set { deta = value; }
        }
        public void CargaCmbCategoria(ComboBox combo)
        {
            try
            {
                conexionBD.ConnectionString = cadenaDeConexion;
                conexionBD.Open();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.CommandText = Tabla2;
                adaptadorBD = new OleDbDataAdapter(comandoBD);
                DataSet ds = new DataSet();
                adaptadorBD.Fill(ds, Tabla2);
                combo.DataSource = ds.Tables[Tabla2];
                combo.DisplayMember = "Detalle";
                combo.ValueMember = "Id_Categoria";
                conexionBD.Close();
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);
                throw;
            }
        }
        public void BuscarCateogira(int id)
        {
            try
            {
                conexionBD.ConnectionString = cadenaDeConexion;
                conexionBD.Open();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.CommandText = "SELECT * FROM Categorias WHERE Id_Categoria =" + id;
                lectorBD = comandoBD.ExecuteReader();
                while (lectorBD.Read())
                {
                    Detalle = lectorBD[1].ToString();
                }
                conexionBD.Close();
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);
                throw;
            }
        }


        public string BuscarParaGrillaa(Int32 Id)
        {
            try
            {
                //Conecto con la base de datos
                conexionBD.ConnectionString = cadenaDeConexion;
                //Abro Conexion
                conexionBD.Open();
                //Indico cual es la conexion que voy a utilizar
                comandoBD.Connection = conexionBD;
                //Indico que voy a trabajar directamente con table
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.CommandText = Tabla2;

                OleDbDataReader Lector = comandoBD.ExecuteReader();
                string varDetalle = "";
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == Id)
                        {
                            varDetalle = Lector.GetString(1);
                        }
                    }
                }
                conexionBD.Close();
                return varDetalle;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
