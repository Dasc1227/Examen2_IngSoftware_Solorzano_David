using Examen2_Solorzano_David.Modelos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Pruebas_Unitarias
{
    [TestClass]
    public class PruebaModelo
    {
        [TestMethod]
        public void ValidarEntradasVacias()
        {
            ValidacionModel modelo = new ValidacionModel();
            bool resultado = modelo.validarEntrada("");
            Assert.IsFalse(resultado, "Fallo en el test de Validar entradas vacias");
        }

        [TestMethod]
        public void ValidarEntradasLlenas()
        {
            ValidacionModel modelo = new ValidacionModel();
            bool resultado = modelo.validarEntrada("Jamon,Peperoni");
            Assert.IsTrue(resultado, "Fallo en el test de Validar entradas llenas");
        }

        [TestMethod]
        public void ValidarPrecioMasaOriginal()
        {
            PizzaModel modelo = new PizzaModel();
            int resultado = modelo.getMasaPrice("original");
            Assert.AreEqual(resultado, 1000);
        }
        [TestMethod]
        public void ValidarPrecioMasaCrunchy()
        {
            PizzaModel modelo = new PizzaModel();
            int resultado = modelo.getMasaPrice("crunchy");
            Assert.AreEqual(resultado, 1500);
        }
        [TestMethod]
        public void ValidarPrecioMasaQueso()
        {
            PizzaModel modelo = new PizzaModel();
            int resultado = modelo.getMasaPrice("queso");
            Assert.AreEqual(resultado, 2000);
        }
        [TestMethod]
        public void ValidarPrecioTamanioPequeno()
        {
            PizzaModel modelo = new PizzaModel();
            int resultado = modelo.getTamanoPrice("pequena");
            Assert.AreEqual(resultado, 4000);
        }
        [TestMethod]
        public void ValidarPrecioTamanioMediana()
        {
            PizzaModel modelo = new PizzaModel();
            int resultado = modelo.getTamanoPrice("mediana");
            Assert.AreEqual(resultado, 4500);
        }
        [TestMethod]
        public void ValidarPrecioTamanioGrande()
        {
            PizzaModel modelo = new PizzaModel();
            int resultado = modelo.getTamanoPrice("grande");
            Assert.AreEqual(resultado, 5000);
        }
        [TestMethod]
        public void ValidarPrecioTamanioExtraGrande()
        {
            PizzaModel modelo = new PizzaModel();
            int resultado = modelo.getTamanoPrice("extra");
            Assert.AreEqual(resultado, 6000);
        }

        [TestMethod]
        public void ValidarPrecioIngre()
        {
            PizzaModel modelo = new PizzaModel();
            string ingre = "Jamon,Peperoni,Pina,Pimiento";
            List<string> ingredientes = ingre.Split(",").ToList();
            int resultado = modelo.getIngrePrice(ingredientes);
            Assert.AreEqual(resultado, 2000);
        }
        [TestMethod]
        public void ValidarPrecioTotalOriginalPequena()
        {
            PizzaModel modelo = new PizzaModel();
            string ingre = "Jamon,Peperoni,Pina,Pimiento";
            List<string> ingredientes = ingre.Split(",").ToList();
            int resultado = modelo.getPrice("original","pequena",ingredientes);
            Assert.AreEqual(resultado, 8000);
        }
        [TestMethod]
        public void ValidarPrecioTotalOriginalMediana()
        {
            PizzaModel modelo = new PizzaModel();
            string ingre = "Jamon,Peperoni,Pina,Pimiento";
            List<string> ingredientes = ingre.Split(",").ToList();
            int resultado = modelo.getPrice("original", "mediana", ingredientes);
            Assert.AreEqual(resultado, 8500);
        }
        [TestMethod]
        public void ValidarPrecioTotalOriginalGrande()
        {
            PizzaModel modelo = new PizzaModel();
            string ingre = "Jamon,Peperoni,Pina,Pimiento";
            List<string> ingredientes = ingre.Split(",").ToList();
            int resultado = modelo.getPrice("original", "grande", ingredientes);
            Assert.AreEqual(resultado, 9000);
        }
        [TestMethod]
        public void ValidarPrecioTotalQuesoGrande()
        {
            PizzaModel modelo = new PizzaModel();
            string ingre = "Jamon,Peperoni,Pina,Pimiento";
            List<string> ingredientes = ingre.Split(",").ToList();
            int resultado = modelo.getPrice("queso", "grande", ingredientes);
            Assert.AreEqual(resultado, 10000);
        }
        [TestMethod]
        public void ValidarPrecioTotalQuesoExtraGrande()
        {
            PizzaModel modelo = new PizzaModel();
            string ingre = "Jamon,Peperoni,Pina,Pimiento";
            List<string> ingredientes = ingre.Split(",").ToList();
            int resultado = modelo.getPrice("queso", "extra", ingredientes);
            Assert.AreEqual(resultado, 11000);
        }
        [TestMethod]
        public void ValidarPrecioTotalQuesoMediana()
        {
            PizzaModel modelo = new PizzaModel();
            string ingre = "Jamon,Peperoni,Pina,Pimiento";
            List<string> ingredientes = ingre.Split(",").ToList();
            int resultado = modelo.getPrice("queso", "mediana", ingredientes);
            Assert.AreEqual(resultado, 9500);
        }
        [TestMethod]
        public void ValidarPrecioTotalQuesoPequena()
        {
            PizzaModel modelo = new PizzaModel();
            string ingre = "Jamon,Peperoni,Pina,Pimiento";
            List<string> ingredientes = ingre.Split(",").ToList();
            int resultado = modelo.getPrice("queso", "pequena", ingredientes);
            Assert.AreEqual(resultado, 9000);
        }
        [TestMethod]
        public void ValidarPrecioCrunchyGrande()
        {
            PizzaModel modelo = new PizzaModel();
            string ingre = "Jamon,Peperoni,Pina,Pimiento";
            List<string> ingredientes = ingre.Split(",").ToList();
            int resultado = modelo.getPrice("crunchy", "grande", ingredientes);
            Assert.AreEqual(resultado, 9500);
        }
        [TestMethod]
        public void ValidarPrecioTotalCrunchyExtraGrande()
        {
            PizzaModel modelo = new PizzaModel();
            string ingre = "Jamon,Peperoni,Pina,Pimiento";
            List<string> ingredientes = ingre.Split(",").ToList();
            int resultado = modelo.getPrice("crunchy", "extra", ingredientes);
            Assert.AreEqual(resultado, 10500);
        }
        [TestMethod]
        public void ValidarPrecioTotalCrunchyMediana()
        {
            PizzaModel modelo = new PizzaModel();
            string ingre = "Jamon,Peperoni,Pina,Pimiento";
            List<string> ingredientes = ingre.Split(",").ToList();
            int resultado = modelo.getPrice("crunchy", "mediana", ingredientes);
            Assert.AreEqual(resultado, 9000);
        }
        [TestMethod]
        public void ValidarPrecioTotalCrunchyPequena()
        {
            PizzaModel modelo = new PizzaModel();
            string ingre = "Jamon,Peperoni,Pina,Pimiento";
            List<string> ingredientes = ingre.Split(",").ToList();
            int resultado = modelo.getPrice("crunchy", "pequena", ingredientes);
            Assert.AreEqual(resultado, 8500);
        }
    }
}
