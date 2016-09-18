using BeFree.WebService.Domain;
using BeFree.WebService.Infra;
using System;
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

		public void AddUser(User user)
		{
			this.beFreeContext.User.Add(user);
			this.beFreeContext.SaveChanges();
		}

		public void UpdateUser(int id, User user)
		{
			var userToUpdate = this.GetUser(id);

			if (userToUpdate != null)
			{
				userToUpdate = user;
				this.beFreeContext.User.Attach(userToUpdate);
			}
		}

		public void DeleteUser(int id)
		{
			if (id == default(int)) { throw new ArgumentNullException(nameof(id)); }

			var user = this.GetUser(id);
			if (user != null)
			{
				this.beFreeContext.User.Remove(user);
				this.beFreeContext.SaveChanges();
			}
		}
	}
}
