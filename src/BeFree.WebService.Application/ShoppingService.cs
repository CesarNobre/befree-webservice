using BeFree.WebService.Domain;
using BeFree.WebService.Infra;
using System;
using System.Linq;

namespace BeFree.WebService.Application
{
	public class ShoppingService
	{
		private BeFreeContext beFreeContext;

		public ShoppingService()
		{
			this.beFreeContext = new BeFreeContext();
		}

		public Shopping GetShopping(int id)
		{
			return this.beFreeContext.Shopping.FirstOrDefault(shopping => shopping.Id == id);
		}

		public Shopping GetShopping(string nome)
		{
			return this.beFreeContext.Shopping.FirstOrDefault(shopping => shopping.Nome.Contains(nome));
		}

		public void AddShopping(Shopping shopping)
		{
			this.beFreeContext.Shopping.Add(shopping);
			this.beFreeContext.SaveChanges();
		}

		public void UpdateShopping(int id, Shopping shopping)
		{
			var shoppingToUpdate = this.GetShopping(id);

			if (shoppingToUpdate != null)
			{
				shoppingToUpdate = shopping;
				this.beFreeContext.Shopping.Attach(shoppingToUpdate);
			}
		}

		public void DeleteShopping(int id)
		{
			if (id == default(int)) { throw new ArgumentNullException(nameof(id)); }

			var shopping = this.GetShopping(id);
			if (shopping != null)
			{
				this.beFreeContext.Shopping.Remove(shopping);
				this.beFreeContext.SaveChanges();
			}
		}
	}
}
