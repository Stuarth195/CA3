using Microsoft.VisualStudio.TestTools.UnitTesting;
using EstructuraDeDatosII;
using EstructuraDeDatosIII;
using System;

namespace EstructuraDeDatosII.Tests
{
    [TestClass]
    public class PilaTests
    {
        [TestMethod]
        public void PilaListaPushTop()
        {
            var pila = new PilaLista<int>();
            pila.Push(10);
            pila.Push(20);
            pila.Push(30);
            Assert.AreEqual(30, pila.Top()); // La cima debe ser 30
        }

        [TestMethod]
        public void PilaListaPop()
        {
            var pila = new PilaLista<int>();
            pila.Push(10);
            pila.Push(20);
            pila.Push(30);

            Assert.AreEqual(30, pila.Pop()); // Se elimina y devuelve el ultimo elemento 30
            Assert.AreEqual(20, pila.Top()); // La cima debe ser 20
        }

        [TestMethod]
        public void PilaListaTop()
        {
            var pila = new PilaLista<int>();
            pila.Push(100);
            pila.Push(200);
            Assert.AreEqual(200, pila.Top()); // La cima sigue siendo 200
            Assert.AreEqual(200, pila.Top()); // Verificamos que sigue en la cima
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PilaListaPopEmpty()
        {
            var pila = new PilaLista<int>();
            pila.Pop(); // Debe lanzar una excepcion
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PilaListaTopEmpty()
        {
            var pila = new PilaLista<int>();
            pila.Top(); // Debe lanzar una excepcion
        }

        [TestMethod]
        public void PilaArregloPushTop()
        {
            var pila = new PilaArreglo<int>(5);
            pila.Push(10);
            pila.Push(20);
            pila.Push(30);
            Assert.AreEqual(30, pila.Top()); // La cima debe ser 30
        }

        [TestMethod]
        public void PilaArregloPop()
        {
            var pila = new PilaArreglo<int>(5);
            pila.Push(10);
            pila.Push(20);
            pila.Push(30);

            Assert.AreEqual(30, pila.Pop()); // Se elimina y devuelve el ultimo elemento (30)
            Assert.AreEqual(20, pila.Top()); // La cima debe ser 20
        }

        [TestMethod]
        public void PilaArregloTop()
        {
            var pila = new PilaArreglo<int>(5);
            pila.Push(100);
            pila.Push(200);
            Assert.AreEqual(200, pila.Top()); // La cima sigue siendo 200
            Assert.AreEqual(200, pila.Top()); // Verificamos que sigue en la cima
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PilaArregloPopEmpty()
        {
            var pila = new PilaArreglo<int>(5);
            pila.Pop(); // Debe lanzar una excepcion
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PilaArregloTopEmpty()
        {
            var pila = new PilaArreglo<int>(5);
            pila.Top(); // Debe lanzar una excepcion
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PilaArregloPushEC()
        {
            var pila = new PilaArreglo<int>(2);
            pila.Push(1);
            pila.Push(2);
            pila.Push(3); // Intenta agregar un tercer elemento en una pila con capacidad 2 debe fallar
        }
    }
}