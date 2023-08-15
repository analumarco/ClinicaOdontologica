using ClinicaOdontologica.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Entidades
{
    internal class Cadastro
    {
        public string Nome { get; set; }    
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Unidade { get; set; }

        public Cadastro()
        {

        }

        public Cadastro(string nome, string email, string telefone, string estado, string cidade, string unidade)
        {
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            this.Estado = estado;
            this.Cidade = cidade;
            this.Unidade = unidade;
        }
    }
}
