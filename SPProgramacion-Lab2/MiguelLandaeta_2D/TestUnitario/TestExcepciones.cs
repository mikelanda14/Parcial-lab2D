using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exepciones;
using System.Threading.Tasks;
using System.Threading;
using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class TestExcepciones
    {

        /// <summary>
        /// Test de Excepcion particular Disenada especialmente para cumplir con los requerimientos del Segundo Parcial
        /// </summary>
        [TestMethod]
        public void TestExcepcionCola()
        {
            try
            {
                Thread threadB = new Thread(Restaurant.PedidoListo);
                threadB.IsBackground = true;
                threadB.Start();
                
               
            }
            catch (Exception e)
            {

                Assert.IsInstanceOfType(e, typeof(ColaExcetion));
            }
        }
        
        /// <summary>
        /// Segundo test de exceptiones utilizando delegato y hilos 
        /// </summary>
        [TestMethod]

        public void TestExecptio2()
        {
            ThreadStart miDelegato = new ThreadStart(Restaurant.PedidoEntregado);
            Thread miThread = new Thread(miDelegato);
            miThread.Start();
            
            Thread.Sleep(0);
            try
            {
                miThread.Start();
            }
            catch (ThreadStateException e)
            {
                Assert.IsInstanceOfType(e,(typeof(ThreadStateException)));
            }
        }
    
    }
}
