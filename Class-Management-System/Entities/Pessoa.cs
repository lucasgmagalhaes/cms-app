using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class_Management_System.ServicesImpl;

namespace Class_Management_System.Entities
{
   public class Pessoa
    { 
        protected string sNome;
        protected string sEmail;
        protected string sCPF;
        protected int pkPessoa;

        public Pessoa( )
        {
            this.sNome = "";
            this.sEmail = "";
            this.sCPF = "";
            this.pkPessoa = 0;
        }
        public Pessoa(string sNome, string sEmail, string sCPF, int pkPessoa)
        {
            this.sNome = sNome;
            this.sEmail = sEmail;
            this.sCPF = sCPF;
            this.pkPessoa = pkPessoa;
        }

        public Pessoa(string sNome, string sEmail, string sCPF )
        {
            this.sNome = sNome;
            this.sEmail = sEmail;
            this.sCPF = sCPF; 
        } 
    }
}
