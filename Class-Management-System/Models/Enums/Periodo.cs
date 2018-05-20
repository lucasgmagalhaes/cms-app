using System;

namespace Class_Management_System.Models.Enums
{
    /// <summary>
    /// Valores que representam os períodos da faculdade
    /// </summary>
    public enum Periodo
    {
        PRIMEIRO = 1,
        SEGUNDO = 2,
        TERCEIRO = 3,
        QUARTO = 4,
        QUINTO = 5,
        SEXTO = 6,
        SETIMO = 7,
        OITAVO = 8
    }

    /// <summary>
    /// Classe auxiliar para busca do periodo
    /// </summary>
    public class PeriodoUtil
    {
        /// <summary>
        /// Retorna o Enum 'Periodo' de acordo com o valor do mesmo.
        /// Gera uma exceção caso não exista um período com o valor especificado.
        /// </summary>
        /// <param name="valor_periodo">valor entre 1 e 8</param>
        /// <returns></returns>
        public static Periodo BuscarPorValor(int valor_periodo)
        {
            if (valor_periodo > 0 && valor_periodo < 9)
            {
                switch (valor_periodo)
                {
                    case 1: return Periodo.PRIMEIRO;
                    case 2: return Periodo.SEGUNDO;
                    case 3: return Periodo.TERCEIRO;
                    case 4: return Periodo.QUARTO;
                    case 5: return Periodo.QUINTO;
                    case 6: return Periodo.SEXTO;
                    case 7: return Periodo.SETIMO;
                    case 8: return Periodo.OITAVO;
                }
            }
            throw new Exception("Não existe período para o valor informado: " + valor_periodo);
        }
    }
}