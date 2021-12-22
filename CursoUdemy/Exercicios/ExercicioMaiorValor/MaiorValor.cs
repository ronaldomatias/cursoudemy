namespace CursoUdemy
{
    public class MaiorValor
    {
        int maior;
        int contadorJogadas = 1;

        public int MaiorValorr(int valor)
        {
            if (contadorJogadas == 1)
            {
                maior = valor;
                contadorJogadas++;
            }

            if (valor > maior)
            {
                maior = valor;
            }

            return maior;
        }    


    }
}