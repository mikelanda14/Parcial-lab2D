using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class TestAtributoNulo
    {
        /// <summary>
        /// Test que no sea nulo prueba de constructor produco
        /// </summary>
        [TestMethod]
        
        public void TestNulo()
        {

            Producto producto = new Producto(789, "promo 500", 5699.95F);

            Assert.IsNotNull(producto);
        }
    }
}
