using System;

namespace Class_Management_System.Interfaces
{
    /// <summary>
    /// Define uma estrutura que é usada por um Grafo
    /// </summary>
    public interface IDado : IEquatable<IDado>, IComparable<IDado>, ICloneable
    {
        /// <summary>
        /// Verificar se um IDado é igual à outro
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        new bool Equals(IDado other);

        /// <summary>
        /// Compara dois IDados. Retornando -1 se o que foi passado por parâmetro
        /// for "menor" que o IDado local contém; 0 Se eles forem iguais e 1 se o IDado local 
        /// for maior que aquele passado por parâmetro
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        new int CompareTo(IDado other);

        /// <summary>
        /// Retorna o conteúdo do dado
        /// </summary>
        /// <returns></returns>
        object GetValor();
    }
}
