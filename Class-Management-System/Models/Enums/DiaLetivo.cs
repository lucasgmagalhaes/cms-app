using System;

namespace Class_Management_System.Models.Enums
{
    /// <summary>
    /// Contém os dias letivos da semana 
    /// </summary>
    public enum DiaLetivo
    {
        SEGUNDA = 2,
        TERCA = 3,
        QUARTA = 4,
        QUINTA = 5,
        SEXTA = 6
    }

    /// <summary>
    /// Classe auxilar para busca dos valores do Enum 'DiaLetivo'
    /// </summary>
    public class DiaLetivoUtil
    {
        /// <summary>
        /// Informa um dia letivo de acordo com o valor do dia da semana passado por parâmetro
        /// </summary>
        /// <param name="dia_numero"></param>
        /// <returns></returns>
        public static DiaLetivo BuscarPorValor(int dia_numero)
        {
            if (dia_numero > 1 && dia_numero < 7)
            {
                switch (dia_numero)
                {
                    case 2: return DiaLetivo.SEGUNDA;
                    case 3: return DiaLetivo.TERCA;
                    case 4: return DiaLetivo.QUARTA;
                    case 5: return DiaLetivo.QUINTA;
                    case 6: return DiaLetivo.SEXTA;
                }
            }
            throw new Exception("Não existe DiaLetivo para o valor informado: " + dia_numero);
        }
    }
}