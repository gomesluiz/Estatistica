namespace Estatistica.Dominio
{
    public class Estatistica
    {
        /// <summary>
        /// O método <c>Media</c> calcula a média de 100 números ou menos,
        /// situados entre os valores mínimo e máximo. Baseado no livro de
        /// Engenharia de Software do autor Roger Pressman.
        /// </summary>
        /// <param name="valores">Array de números</param>
        /// <param name="minino">Limite inferior para o cálculo da média</param>
        /// <param name="maximo">Límite superior para o cálculo da média</param>
        /// <returns>Media</returns>
        public static double Media(double[] valores,
                                   double minimo,
                                   double maximo)
        {
            double soma = 0.0, media = 0.0;
            int i = 0, validas = 0;

            while ((i < 100) && (valores[i] != -999))
            {
                if ((valores[i] >= minimo) && (valores[i] <= maximo))
                {
                    soma += valores[i];
                    validas++;
                }
                i++;
            }
            if (validas > 0)
                media = soma / validas;

            return media;
        }
    }
}