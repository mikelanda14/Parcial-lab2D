using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class TestValorNumerico
    {
        /// <summary>
        /// Retorne un tipo int al utilizar la propiedad Numero de pedido.
        /// </summary>
        [TestMethod]
        
        public void TestNumerico()
        {
           Pedido pedido = new Pedido(99.99F,"Promo1","Pepe",2,false);

            Assert.IsInstanceOfType(pedido.NumeroPedido, typeof(int));
        }
    }
}
