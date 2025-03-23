using Microsoft.VisualStudio.TestTools.UnitTesting;
using EstructuraDeDatos;
using EstructuraDeDatosI;
using System;

namespace EstructuraDeDatos.Tests
{
    [TestClass]
    public class ColaTests
    {
        [TestMethod]
        public void ColaLista_Encolar_Desencolar()
        {
            var cola = new ColaLista<int>();
            cola.Encolar(10);
            cola.Encolar(20);
            Assert.AreEqual(10, cola.Desencolar());
            Assert.AreEqual(20, cola.Desencolar());
            Assert.IsTrue(cola.IsEmpty());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ColaLista_Desencolar_Empty()
        {
            var cola = new ColaLista<int>();
            cola.Desencolar();
        }

        [TestMethod]
        public void ColaArreglo_Encolar_Desencolar()
        {
            var cola = new ColaArreglo<int>(3);
            cola.Encolar(1);
            cola.Encolar(2);
            cola.Encolar(3);
            Assert.AreEqual(1, cola.Desencolar());
            Assert.AreEqual(2, cola.FrenteElemento());
            Assert.AreEqual(2, cola.Desencolar());
            Assert.AreEqual(3, cola.Desencolar());
            Assert.IsTrue(cola.EstaVacia());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ColaArreglo_Desencolar_Empty()
        {
            var cola = new ColaArreglo<int>(3);
            cola.Desencolar();
        }

        [TestMethod]
        public void ColaLista_Tamano()
        {
            var cola = new ColaLista<int>();
            cola.Encolar(5);
            cola.Encolar(15);
            Assert.AreEqual(2, cola.Tamano());
        }

        [TestMethod]
        public void ColaLista_FrenteElemento()
        {
            var cola = new ColaLista<int>();
            cola.Encolar(42);
            Assert.AreEqual(42, cola.FrenteElemento());
        }

        [TestMethod]
        public void ColaArreglo_Tamano()
        {
            var cola = new ColaArreglo<int>(5);
            cola.Encolar(7);
            cola.Encolar(14);
            cola.Encolar(21);
            Assert.AreEqual(3, cola.Tamano());
        }

        [TestMethod]
        public void ColaArreglo_FrenteElemento()
        {
            var cola = new ColaArreglo<int>(5);
            cola.Encolar(99);
            Assert.AreEqual(99, cola.FrenteElemento());
        }
    }
}