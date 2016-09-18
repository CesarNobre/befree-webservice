using BeFree.WebService.Domain;
using System.Collections.Generic;

namespace BeFree.WebService.Response
{
	public class ShoppingResponse
	{
		public string Nome { get; set; }

		public string CNPJ { get; set; }

		public virtual Endereco Endereco { get; set; }

		public virtual List<MesaResponse> Mesas { get; set; }
	}
}