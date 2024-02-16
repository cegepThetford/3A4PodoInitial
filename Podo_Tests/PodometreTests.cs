using Microsoft.VisualStudio.TestTools.UnitTesting;
using Podo_Affaires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podo_Tests
{
    [TestClass()]
    public class PodometreTests
    {
        private Podometre _podo;

        [TestInitialize]
        public void initialisation()
        {
            _podo = new Podometre();
        }

        [TestMethod()]
        public void creationPodometreTests()
        {
            Assert.AreEqual(0, _podo.Valeur);
        }
        [TestMethod()]
        public void operationsTests()
        {
            _podo.incrementer();
            Assert.AreEqual(1, _podo.Valeur);
            _podo.incrementer();
            _podo.incrementer();
            Assert.AreEqual(3, _podo.Valeur);
            _podo.raz();
            Assert.AreEqual(0, _podo.Valeur);
            _podo.Valeur = 15;
            Assert.AreEqual(15, _podo.Valeur);
            _podo.decrementer();
            Assert.AreEqual(14, _podo.Valeur);
        }
        [TestMethod]
        public void negatifTests()
        {
            _podo.decrementer();
            Assert.AreEqual(-1, _podo.Valeur);
            _podo.decrementer();
            _podo.decrementer();
            Assert.AreEqual(-3, _podo.Valeur);
            _podo.incrementer();
            Assert.AreEqual(-2, _podo.Valeur);
            _podo.raz();
            Assert.AreEqual(0, _podo.Valeur);
        }
    }
}