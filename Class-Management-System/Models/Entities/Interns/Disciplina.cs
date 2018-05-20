namespace Class_Management_System.Models.Entities.Interns
{
    public class Disciplina
    {
        private string nome;

        public Disciplina(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }
    }
}