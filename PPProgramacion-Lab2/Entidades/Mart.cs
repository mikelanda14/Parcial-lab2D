using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static public class Mart
    {
        static List<Empleado> empleados;
        static List<Cliente> clientes;
        static List<Producto> reporte;
        


        static Mart()
        {
            #region Listas

            
            clientes = new List<Cliente>();
            empleados = new List<Empleado>();
            reporte = new List<Producto>();

            #endregion

            #region Usuarios, clientes y productos Pre-Cargados

            
            Mart.Add(new Empleado(111, "abu", "123", "abu"));
            Mart.Add(new Empleado(222, "mike", "123", "mike"));
            Mart.AddCliente(new Cliente(111, "Abu Boss"));
            Mart.AddCliente(new Cliente(222, "Mike Landa"));
            Mart.AddCliente(new Cliente(333, "Homero Simpson"));
            Mart.AddCliente(new Cliente(444, "Bart Simpson"));
            Mart.AddCliente(new Cliente(555, "Milhouse Van Houten"));
            Mart.AddCliente(new Cliente(666, "Sean House"));

            empleados[0].Setventa("Recibo Completo de Apu's Mart Codigo: 10 Marca: Clarin Nombre: Clarin Precio: 5,66 Total Abonado 78,89");
            empleados[0].Setventa("Codigo :  9 Marca :El Vigilante Nombre :El Vigilante Precio :12,64 Total Abonado 78,99");
            empleados[0].Setventa("Codigo :  9 Marca :El Vigilante Nombre :El Vigilante Precio :12,64 Total Abonado 78,99");
            empleados[1].Setventa("Recibo Completo de Apu's Mart Codigo: 1 Marca: Duff Nombre :      DuffPrecio: 1,99 Total Abonado 1,99");
            empleados[1].Setventa("Recibo Completo de Apu's Mart Codigo: 2 Marca: Duff Nombre :      DuffPrecio: 0,99 Total Abonado 0,99");
            empleados[1].Setventa("Recibo Completo de Apu's Mart Codigo: 2 Marca: Duff Nombre :      DuffPrecio: 0,99 Total Abonado 0,99");
          
            if (Invetario.View().Count == 0)
            {
                AgregarProductoCategoria(001, "Duff", "Cerveza", 1.99F, 50,"Bebidas");
                AgregarProductoCategoria(002, "Duff", "Cola", .99F, 65,"Bebidas");


                Invetario.Add(new Bebidas(001, "Duff", "Cerveza", 1.99F, 50 ));
                Invetario.Add(new Bebidas(002, "Duff", "Cola", .99F, 65));
                Invetario.Add(new Bebidas(003, "Duff", "Axe Spray", 9.95F, 27));
                Invetario.Add(new Comestible(004, "CandyLand", "Gomitas", 12.64F, 45));
                Invetario.Add(new Comestible(005, "CandyLand", "Veneno Para Ratas", 12.64F, 45));
                Invetario.Add(new Comestible(006, "Tomaco", "Masticable", 9.99F, 150));
                Invetario.Add(new Comestible(007, "Tomaco", "Aderezo", 9, 5));
                Invetario.Add(new Comestible(008, "Tomaco", "Taco", 5.55F, 7));
                Invetario.Add(new Electronico(009, "El Vigilante", "Periodico", 12.64F, 4));
                Invetario.Add(new Electronico(010, "Clarin", "Revista", 5.66F, 45));
                Invetario.Add(new Perfumeria(011, "ape", "apetin", 9.99F, 50));
                Invetario.Add(new Perfumeria(012, "tto", "aweepetin", 9, 5));
                Invetario.Add(new Producto(013, "tre", "tat", 9, 7));
                Invetario.Add(new Producto(014, "tang", "afsdn", 12.64F, 4));
                Invetario.Add(new Producto(015, "thhh", "errn", 5.66F, 45));
                Invetario.Add(new Producto(016, "ape", "apetin", 9.99F, 50));
                Invetario.Add(new Producto(017, "tto", "aweepetin", 9, 5));
                Invetario.Add(new Producto(018, "tre", "tat", 9, 7));
                Invetario.Add(new Producto(019, "tang", "afsdn", 12.64F, 4));
                Invetario.Add(new Producto(020, "thhh", "errn", 5.66F, 45));
                Invetario.Add(new Producto(021, "thhh", "errn", 5.66F, 45));
                Invetario.Add(new Producto(022, "ape", "apetin", 9.99F, 50));
                Invetario.Add(new Producto(023, "tto", "aweepetin", 9, 5));
                Invetario.Add(new Producto(024, "tre", "tat", 9, 7));
                Invetario.Add(new Producto(025, "tang", "afsdn", 12.64F, 4));
                Invetario.Add(new Producto(026, "thhh", "errn", 5.66F, 45));
                Invetario.Add(new Producto(027, "ape", "apetin", 9.99F, 50));
                Invetario.Add(new Producto(028, "tto", "aweepetin", 9, 5));
                Invetario.Add(new Producto(029, "tre", "tat", 9, 7));
                Invetario.Add(new Producto(030, "tang", "afsdn", 12.64F, 4));
                Invetario.Add(new Producto(031, "thhh", "errn", 5.66F, 45));
            }
            #endregion
        }
            #region Metodos

        /// <summary>
        /// Agrega nuevo cliente a la lista de clientes
        /// </summary>
        /// <param name="cliente"></param>
        public static void AddCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }
        /// <summary>
        /// devuelvev la lista de clientes del prestigioso estableciemiento K-MART
        /// </summary>
        /// <returns></returns>
        public static List<Cliente> viewCliente()
        {
            return clientes;
        }
        /// <summary>
        ///  agrega empleado al Exelentisimo sistema de gestion de ventas y produtos Kmart INC
        /// </summary>
        /// <param name="empleado"></param>
        public static void Add(Empleado empleado)
        {
            empleados.Add(empleado);
        }
        public static List<Empleado> View()
        {
            return empleados;
        }
        /// <summary>
        /// Genera Un reporte de Alto detalle y mucho potencial sobre las actividades financieras de los empleados en el establecimiento.
        /// </summary>
        /// <param name="producto"></param>
        public static void AddReporte(Producto producto)
        {
            reporte.Add(producto);
        }
        /// <summary>
        /// retorna lista de productos para reporte con menos de 10 unidades en stock
        /// </summary>
        /// <returns></returns>
        public static List<Producto> Reporte()
        {

            return reporte;
        }
        /// <summary>
        /// Agrega produtos a la lista Inventario del tipo clase deribada dependiendo de la categoria del mismo.
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="marca"></param>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="unidades"></param>
        /// <param name="categoria"></param>
        public static void AgregarProductoCategoria(int codigo, string marca, string nombre, float precio, int unidades, string categoria)
        {
            switch (categoria)
            {
                case "Bebidas":
                    Invetario.Add(new Bebidas(codigo, marca, nombre, precio, unidades));
                    break;
                case "Comestible":
                    Invetario.Add(new Comestible(codigo, marca, nombre, precio, unidades));
                    break;

                case "Electronico":
                    Invetario.Add(new Electronico(codigo, marca, nombre, precio, unidades));
                    break;

                case "Perfumeria":
                    Invetario.Add(new Perfumeria(codigo, marca, nombre, precio, unidades));
                   
                    break;

                    
            }

            
        }
        /// <summary>
        /// Agrega produtos a la lista Compras del tipo clase deribada dependiendo de la categoria del mismo.
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="marca"></param>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="unidades"></param>
        /// <param name="categoria"></param>
        public static void AgregarProductoCategoriaCompras(int codigo, string marca, string nombre, float precio, int unidades, string categoria)
        {
            switch (categoria)
            {
                case "Bebidas":
                    Compras.Add(new Bebidas(codigo, marca, nombre, precio, unidades));
                    break;
                case "Comestible":
                    Compras.Add(new Comestible(codigo, marca, nombre, precio, unidades));
                    break;

                case "Electronico":
                    Compras.Add(new Electronico(codigo, marca, nombre, precio, unidades));
                    break;

                case "Perfumeria":
                    Compras.Add(new Perfumeria(codigo, marca, nombre, precio, unidades));
                   
                    break;

                    
            }


        }
        #endregion
    }
}
