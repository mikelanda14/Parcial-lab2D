using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Exepciones;

namespace Entidades
{
    public static class DB
    {
        static SqlConnection conexionDB;
        /// <summary>
        /// Constructro que inicializa la conexion par la BD
        /// </summary>
        static DB()
        {
            conexionDB = new SqlConnection("Data Source=localhost\\MSSQLSERVER01; Initial Catalog = SParcial; Integrated security = true ");
        }
        /// <summary>
        /// Metodo el cual conecta con la base de datos ejecuta el Select y carga la el menu del restaurant
        /// </summary>
        public static void GetMenu()
        {
            try
            {
                SqlCommand comandoSql = new SqlCommand();
                comandoSql.Connection = conexionDB;
                comandoSql.CommandType = CommandType.Text;
                comandoSql.CommandText = "SELECT * from Productos";
                if (conexionDB.State != ConnectionState.Open)
                {
                    conexionDB.Open();
                }
                SqlDataReader datosTablaProductos = comandoSql.ExecuteReader();
                while (datosTablaProductos.Read())
                {
                    Restaurant.AgregarMenu(int.Parse(datosTablaProductos["IDproducto"].ToString()), datosTablaProductos["Descripcion"].ToString(), float.Parse(datosTablaProductos["Precio"].ToString()));
                }
            }
            catch (Exception e)
            {

                e.Message.ToString();


            }
            finally
            {
                if (conexionDB.State == ConnectionState.Open)
                {
                    conexionDB.Close();
                }
            }


        }
        /// <summary>
        /// Metodo el cual registra en la BD los pedidos al ejecutar la compra
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="importeTotal"></param>
        public static void InsertPedido(string descripcion, float importeTotal)
        {
            try
            {

                SqlCommand comandoSql = new SqlCommand();
                comandoSql.Connection = conexionDB;
                comandoSql.CommandType = CommandType.Text;
                comandoSql.CommandText = "Insert into Pedidos(pedido,ImporteTotal) values(@descripcion,@precio)";
                comandoSql.Parameters.AddWithValue("@descripcion", descripcion);
                comandoSql.Parameters.AddWithValue("@precio", importeTotal);

                if (conexionDB.State != ConnectionState.Open)
                {
                    conexionDB.Open();
                }

                comandoSql.ExecuteReader();

            }
            catch (Exception e)
            {
                e.Message.ToString();


            }
            finally
            {
                if (conexionDB.State == ConnectionState.Open)
                {
                    conexionDB.Close();
                }
            }

        }
    }
}
