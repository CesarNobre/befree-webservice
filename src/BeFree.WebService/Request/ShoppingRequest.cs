using BeFree.WebService.Domain;
using System.Collections.Generic;

namespace BeFree.WebService.Request
{
	public class ShoppingRequest
	{
		public string Nome { get; set; }

		public string CNPJ { get; set; }

		public virtual Endereco Endereco { get; set; }

		public virtual List<Mesa> Mesas { get; set; }
	}
}