namespace Estatistica.Dominio
{
    public class Estatistica
    {
        public static double Media(double[] valores, double minimo, double maximo)
        {
            double soma = 0.0, media = 0.0;
            int i = 0, validas = 0;

            while((i < 100) && (valores[i] != -999))
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