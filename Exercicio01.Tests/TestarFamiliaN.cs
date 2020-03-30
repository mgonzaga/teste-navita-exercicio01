using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercicio01;
namespace Exercicio01.Tests
{
    [TestClass]
    public class TestarFamiliaN
    {
        private readonly Exercicio01 exercicio;
        public TestarFamiliaN()
        {
            exercicio = new Exercicio01();
        }
        [TestMethod]
        public void FamiliaN_CoNumeroNegativo_DeveRetormarMenosUm()
        {
            var retorno = exercicio.ObterMaiorNumeroFamiliaN(-1234567890);
            Assert.AreEqual(retorno, -1);
        }
        [TestMethod]
        public void FamiliaN_MaiorQueCemMilhoes_DeveRetormarMenosUm()
        {
            var retorno = exercicio.ObterMaiorNumeroFamiliaN(1234567890);
            Assert.AreEqual(retorno, -1);
        }
        [TestMethod]
        public void FamiliaN_ValorIgual213_DeveRetornar321()
        {
            var retorno = exercicio.ObterMaiorNumeroFamiliaN(213);
            Assert.AreEqual(retorno, 321);
        }
        [TestMethod]
        public void FamiliaN_ValorIgual553_DeveRetornar553()
        {
            var retorno = exercicio.ObterMaiorNumeroFamiliaN(553);
            Assert.AreEqual(retorno, 553);
        }
        [TestMethod]
        public void FamiliaN_MaiorQueZeroEMenorQue10_DeveRetormarMenosUm()
        {
            var retorno = exercicio.ObterMaiorNumeroFamiliaN(9);
            Assert.AreEqual(retorno, -1);
        }
    }
}
