using ControleADM.Models;
using ControleADM.Negocio;
using System;
using System.Collections.Generic;

namespace ControleADM
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaDAO objPessoa = new PessoaDAO();
            Pessoa pessoa = new Pessoa();
            pessoa.id = 1;
            List<Pessoa> retorno = objPessoa.consulte(pessoa);
        }
    }
}
