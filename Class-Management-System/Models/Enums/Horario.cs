using System;

namespace Class_Management_System.Models.Enums
{
    /// <summary>
    /// Horários das aulas
    /// </summary>
    public enum Horario
    {
        PRIMEIRO = 1,
        SEGUNDO = 2
    }

    /// <summary>
    /// Classe auxiliar para busca dos horários
    /// </summary>
    public class HorarioUtil
    {
        /// <summary>
        /// Informa o horario de acordo com o valor passado por parâmetro
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static Horario BuscarPorValor(int valor)
        {
            if (valor > 0 && valor < 3)
            {
                switch (valor)
                {
                    case 1: return Horario.PRIMEIRO;
                    case 2: return Horario.SEGUNDO;
                }
            }
            throw new Exception("Não existe horário para o valor informado: " + valor);
        }
    }
}