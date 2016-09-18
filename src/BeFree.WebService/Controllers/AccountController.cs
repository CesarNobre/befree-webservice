using BeFree.WebService.Application;
using BeFree.WebService.Domain;
using BeFree.WebService.Request;
using BeFree.WebService.Response;
using System;
using System.Net;
using System.Web.Http;

namespace BeFree.WebService.Controllers
{
	public class AccountController : ApiController
    {
		private AccountService accountService;

		public AccountController()
		{
			this.accountService = new AccountService();
		}

        public UserResponse Get(int id)
        {
			var userResponse = new UserResponse();

			try
			{
				var user = this.accountService.GetUser(id);
				userResponse = AutoMapper.Mapper.Map<UserResponse>(user);
			}
			catch (Exception ex)
			{
				throw ex;
			}

			return userResponse;
        }

		public UserResponse Get(string nome)
		{
			return new UserResponse();
		}

		public HttpStatusCode Post(UserRequest user)
        {
			if (user == null) { return HttpStatusCode.BadRequest; }

			var newUser = AutoMapper.Mapper.Map<User>(user);

			try
			{
				this.accountService.AddUser(newUser);
			}
			catch (Exception)
			{
				return HttpStatusCode.InternalServerError;
			}

			return HttpStatusCode.OK;
		}

        public HttpStatusCode Put(int id, UserRequest user)
        {
			if (user == null) { return HttpStatusCode.BadRequest; }

			var newUser = AutoMapper.Mapper.Map<User>(user);

			try
			{
				this.accountService.AddUser(newUser);
			}
			catch (Exception)
			{
				return HttpStatusCode.InternalServerError;
			}

			return HttpStatusCode.OK;
		}

        public HttpStatusCode Delete(int id)
        {
			if (id == default(int)) { return HttpStatusCode.BadRequest; }

			try
			{
				this.accountService.DeleteUser(id);
			}
			catch (Exception)
			{
				return HttpStatusCode.InternalServerError;
			}

			return HttpStatusCode.OK;
        }
    }
}
