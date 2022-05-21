using NUnit.Framework;
using Estatistica.Dominio;

namespace Estatistica.TesteDeUnidade
{
    public class Tests
    {
        [Test]
        public void Media_Testa_Caso_1()
        {
            // Arranjo
            double[] valores = { 10.0, 5.0, 15.0, -999.0 };
            double min = 0.0, Max = 50.0;
            double esperado = (valores[0] + valores[1] + valores[2]) / 2;
            double tolerancia = 0.01;

            // Ação
            double retornado = Dominio.Estatistica.Media(valores, min, Max);
            
            // Asserção
            Assert.AreEqual(esperado, retornado, tolerancia);
        }
    }
}