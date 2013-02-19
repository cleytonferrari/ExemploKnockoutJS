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
        // GET api/listas
        public IEnumerable<string> Get()
        {
            var lista = new List<string>();
            lista.Add("CLEYTON FERRARI");
            lista.Add("MIELY CASARIN FERRARI");
            lista.Add("RENATA CASARIN FERRARI");
            return lista;
        }        
    }
}
