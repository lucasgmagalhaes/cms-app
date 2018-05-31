namespace Class_Management_System.Entities
{
    /// <summary>
    /// Mapeado da tabela PESSOA
    /// </summary>
   public class Pessoa
    {
        /// <summary>
        /// NOME_PESSOA
        /// </summary>
        private string sNome;
        /// <summary>
        /// EMAIL
        /// </summary>
        private string sEmail;
        /// <summary>
        /// COD_CPF
        /// </summary>
        private string sCPF;
        /// <summary>
        /// COD_PESSOA
        /// </summary>
        private int pkPessoa;

        public string SNome { get => sNome; set => sNome = value; }
        public string SEmail { get => sEmail; set => sEmail = value; }
        public string SCPF { get => sCPF; set => sCPF = value; }
        public int PkPessoa { get => pkPessoa; set => pkPessoa = value; }

        public Pessoa()
        {
            this.SNome = "";
            this.SEmail = "";
            this.SCPF = "";
            this.PkPessoa = 0;
        }
        public Pessoa(string sNome, string sEmail, string sCPF, int pkPessoa)
        {
            this.SNome = sNome;
            this.SEmail = sEmail;
            this.SCPF = sCPF;
            this.PkPessoa = pkPessoa;
        }

        public Pessoa(string sNome, string sEmail, string sCPF )
        {
            this.SNome = sNome;
            this.SEmail = sEmail;
            this.SCPF = sCPF; 
        } 
    }
}
