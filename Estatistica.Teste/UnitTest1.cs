using NUnit.Framework;
using Estatistica.Dominio;

namespace Estatistica.Teste
{
    public class TestaCalculoDaMedia
    {
        [Test]
        public void Media_Teste_Caso_1()
        {
            // Arranjo
            double[] valores = { 10, 5, 15, -999 };
            double minimo = 0.0, maximo = 50.0;
            double retornado, esperado = 10.0;

            // Ação
            retornado = Dominio.Estatistica.Media(valores, minimo, maximo);

            // Asserção
            Assert.AreEqual(esperado, retornado);

        }

        [Test]
        public void Media_Teste_Caso_2()
        {
            // Arranjo
            double[] valores = { 10, 15, 15, 15, 15, 10, 20, 15, 15, 10,
                                 10, 15, 15, 15, 15, 10, 20, 15, 15, 10,
                                 10, 15, 15, 15, 15, 10, 20, 15, 15, 10,
                                 10, 15, 15, 15, 15, 10, 20, 15, 15, 10,
                                 10, 15, 15, 15, 15, 10, 20, 15, 15, 10,
                                 10, 15, 15, 15, 15, 10, 20, 15, 15, 10,
                                 10, 15, 15, 15, 15, 10, 20, 15, 15, 10,
                                 10, 15, 15, 15, 15, 10, 20, 15, 15, 10,
                                 10, 15, 15, 15, 15, 10, 20, 15, 15, 10,
                                 10, 15, 15, 15, 15, 10, 20, 15, 15, 10};

            double minimo = 0, maximo = 5;
            double retornado, esperado = 0.0;

            // Ação
            retornado = Dominio.Estatistica.Media(valores, minimo, maximo);

            // Asserção
            Assert.AreEqual(esperado, retornado);
        }

        [Test]
        public void Media_Teste_Caso_3()
        {
            // Arranjo
            double[] valores = { -999 };

            double minimo = 0, maximo = 50;
            double retornado, esperado = 0.0;

            // Ação
            retornado = Dominio.Estatistica.Media(valores, minimo, maximo);

            // Asserção
            Assert.AreEqual(esperado, retornado);
        }

        [Test]
        public void Media_Teste_Caso_4()
        {
            // Arranjo
            double[] valores = { 5, 10, 20, -999 };

            double minimo = 10, maximo = 20;
            double retornado, esperado = 15.0;

            // Ação
            retornado = Dominio.Estatistica.Media(valores, minimo, maximo);

            // Asserção
            Assert.AreEqual(esperado, retornado);
        }

        [Test]
        public void Media_Teste_Caso_5()
        {
            // Arranjo
            double[] valores = { 10, 40, 100, -999 };

            double minimo = 10, maximo = 50;
            double retornado, esperado = 25.0;

            // Ação
            retornado = Dominio.Estatistica.Media(valores, minimo, maximo);

            // Asserção
            Assert.AreEqual(esperado, retornado);
        }

        public void Media_Teste_Caso_6()
        {
            // Arranjo
            double[] valores = { 10, 15, 15, 15, 15, 10, 20, 15, 15, 10,
                                 10, 15, 15, 15, 15, 10, 20, 15, 15, 10,
                                 10, 15, 15, 15, 15, 10, 20, 15, 15, 10,
                                 10, 15, 15, 15, 15, 10, 20, 15, 15, 10,
                                 10, 15, 15, 15, 15, 10, 20, 15, 15, 10,
                                 10, 15, 15, 15, 15, 10, 20, 15, 15, 10,
                                 10, 15, 15, 15, 15, 10, 20, 15, 15, 10,
                                 10, 15, 15, 15, 15, 10, 20, 15, 15, 10,
                                 10, 15, 15, 15, 15, 10, 20, 15, 15, 10,
                                 10, 15, 15, 15, 15, 10, 20, 15, 15, 10};

            double minimo = 0, maximo = 80;
            double retornado, esperado = 10.0;

            // Ação
            retornado = Dominio.Estatistica.Media(valores, minimo, maximo);

            // Asserção
            Assert.AreEqual(esperado, retornado);
        }

    }
}