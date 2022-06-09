using Microsoft.VisualStudio.TestTools.UnitTesting;
using P07InterfejsyKalkulator;
using System;

namespace P09Intrefesy.Test
{
    [TestClass]
    public class ModulDodawaniaTest
    {
        [TestMethod]
        public void Scenariusz1()
        {
            int a = 4;
            int b = 5;

            int oczekiwanyWynik = 9;

            ModulDodawania m = new ModulDodawania();
            int wynikSystemu = m.Policz(a, b);

            Assert.AreEqual(oczekiwanyWynik, wynikSystemu);
        }

        [TestMethod]
        public void Scenariusz2()
        {
            int a = -4;
            int b = -5;

            int oczekiwanyWynik = 9;

            ModulDodawania m = new ModulDodawania();
            int wynikSystemu = m.Policz(a, b);

            Assert.AreEqual(oczekiwanyWynik, wynikSystemu);
        }


        [TestMethod]
        public void Scenariusz3()
        {
            int a = 87876856;
            int b = -5;

            int oczekiwanyWynik = 9;

            ModulDodawania m = new ModulDodawania();
            int wynikSystemu = m.Policz(a, b);

            Assert.AreEqual(oczekiwanyWynik, wynikSystemu);
        }
    }
}
