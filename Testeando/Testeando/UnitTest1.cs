using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica;

namespace Testeando
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanciaEstacionamiento() // Debe instanciar el objeto.
        {
            Estacionamiento estacionamientoUno;
            estacionamientoUno = new Estacionamiento();
            Assert.IsNotNull(estacionamientoUno);
        }

        [TestMethod]
        public void ListadoInstanciado()
        {
            Estacionamiento estacionamientoDos = new Estacionamiento();
            Assert.IsNotNull(estacionamientoDos.misVehiculos);
        }

    }

}
