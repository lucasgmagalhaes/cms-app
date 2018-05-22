using System;

namespace Class_Management_System.Enums
{
    /// <summary>
    /// Valores de cores inicialmente usadas para coloração de Grafo
    /// </summary>
    public enum Cor
    {
        PRETO = 1,
        CINZA = 2,
        BRANCO = 3,
        AZUL = 4,
        AMARELO = 5,
        VERDE = 6,
        VERMELHO = 7,
        ROXO = 8
    }

    /// <summary>
    /// Classe utilitária para busca de cor
    /// </summary>
    public static class CorUtil
    {
        /// <summary>
        /// Retorna uma cor com base no valor dela. Caso não haja uma cor para o valor informado,
        /// é gerada uma exceção
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static Cor BuscarPorValor(int valor)
        {
            switch (valor)
            {
                case 1: return Cor.PRETO;
                case 2: return Cor.CINZA;
                case 3: return Cor.BRANCO;
                case 4: return Cor.AZUL;
                case 5: return Cor.AMARELO;
                case 6: return Cor.VERDE;
                case 7: return Cor.VERMELHO;
                case 8: return Cor.ROXO;
            }
            throw new Exception("Não existe Cor para o valor informado: " + valor);
        }
    }
}
