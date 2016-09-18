using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeFree.WebService.Domain
{
	public class Shopping
	{
		[Key]
		public int Id { get; set; }

		public string Name { get; set; }

		public string CNPJ { get; set; }

		public virtual Endereco Endereco { get; set; }

		public virtual List<Mesa> Mesas { get; set; }
	}
}
