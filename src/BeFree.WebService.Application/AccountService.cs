using BeFree.WebService.Domain;
using BeFree.WebService.Infra;
using System.Linq;

namespace BeFree.WebService.Application
{
	public class AccountService
	{
		private BeFreeContext beFreeContext;

		public AccountService()
		{
			this.beFreeContext = new BeFreeContext();
		}
		public User GetUser(int id)
		{
			return this.beFreeContext.User.FirstOrDefault(user => user.Id == id);
		}

		public User GetUser(string nome)
		{
			return this.beFreeContext.User.FirstOrDefault(user => user.NomeCompleto().Contains(nome));
		}
	}
}
