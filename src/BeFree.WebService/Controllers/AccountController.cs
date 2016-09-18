using BeFree.WebService.Application;
using BeFree.WebService.Domain;
using BeFree.WebService.Infra;
using BeFree.WebService.Request;
using BeFree.WebService.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BeFree.WebService.Controllers
{
    public class AccountController : ApiController
    {
        // GET: api/Account
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Account/5
        public UserResponse Get(int id)
        {
			var novoUser = new User { PrimeiroNome = "Cesar" };
			var accountService = new AccountService();
			var resposta = new User();
			try
			{
				resposta = accountService.GetUser(id);
            }
			catch (Exception ex)
			{
				throw;
			}

			return new UserResponse { Nome = resposta.NomeCompleto()};
        }

		public UserResponse Get(string nome)
		{
			return new UserResponse();
		}

		// POST: api/Account
		public void Post([FromBody]UserRequest user)
        {
		}

        // PUT: api/Account/5
        public void Put(int id, [FromBody]UserRequest value)
        {
        }

        // DELETE: api/Account/5
        public void Delete(int id)
        {
        }
    }
}
