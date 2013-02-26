using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnockoutJSExemplo.Controllers
{
    public class ListasController : ApiController
    {

        public IEnumerable<string> Get()
        {
            var lista = new List<string>();
            lista.Add("CLEYTON FERRARI");
            lista.Add("MIELY CASARIN FERRARI");
            lista.Add("RENATA CASARIN FERRARI");
            return lista;
        }

        public Pessoa Post(Pessoa pessoa)
        {
            pessoa.Email = pessoa.Email + "(mudei no server)";
            pessoa.Nome = pessoa.Nome + "(mudei no server)";
            return pessoa;
        }
    }

    public class Pessoa
    {
        
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
