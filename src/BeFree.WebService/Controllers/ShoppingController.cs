using BeFree.WebService.Application;
using BeFree.WebService.Domain;
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
    public class ShoppingController : ApiController
    {
		private ShoppingService shoppingService;

		public ShoppingController()
		{
			this.shoppingService = new ShoppingService();
		}

        // GET: api/Shopping/5
        public ShoppingResponse Get(int id)
        {
			try
			{
				var shopping = this.shoppingService.GetShopping(id);
				var shoppingResponse = AutoMapper.Mapper.Map<ShoppingResponse>(shopping);

				return shoppingResponse;
			}
			catch (Exception ex)
			{
				throw ex;
			}
        }

		public ShoppingResponse Get(string name)
		{
			try
			{
				var shopping = this.shoppingService.GetShopping(name);
				var shoppingResponse = AutoMapper.Mapper.Map<ShoppingResponse>(shopping);
				return shoppingResponse;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// POST: api/Shopping
		public HttpStatusCode Post(ShoppingRequest shopping)
        {
			try
			{
				
				var newShopping = new Shopping { CNPJ = shopping.CNPJ, Endereco = shopping.Endereco, Mesas = shopping.Mesas, Nome = shopping.Nome};
				this.shoppingService.AddShopping(newShopping);

				return HttpStatusCode.OK;
			}
			catch (Exception ex)
			{
				return HttpStatusCode.InternalServerError;
			}
		}

        // PUT: api/Shopping/5
        public HttpStatusCode Put(int id, ShoppingRequest shopping)
        {
			try
			{
				var shoppingToUpdate = AutoMapper.Mapper.Map<Shopping>(shopping);
				this.shoppingService.UpdateShopping(id, shoppingToUpdate);

				return HttpStatusCode.OK;
			}
			catch (Exception)
			{
				return HttpStatusCode.InternalServerError;
			}
		}

		// DELETE: api/Shopping/5
		public HttpStatusCode Delete(int id)
        {
			try
			{
				this.shoppingService.DeleteShopping(id);

				return HttpStatusCode.OK;
			}
			catch (Exception)
			{
				return HttpStatusCode.InternalServerError;
			}
		}
	}
}
