using System.Collections.Generic;

namespace Class_Management_System.Entities
{
    public class Professor
    {
        private string nome;
        public Professor(string nome)
        {
            this.nome = nome;
            this.TratarNomeProfessor();
        }

        public string GetNome()
        {
            return this.nome;
        }

        /// <summary>
        /// Para o nome do professor, torna o primeiro caracter maiúsculo
        /// </summary>
        private void TratarNomeProfessor()
        {
            if (this.nome != null)
            {
                this.nome[0].ToString().ToUpper();
            }
        }
    }
}