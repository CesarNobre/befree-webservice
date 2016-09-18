using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeFree.WebService.Domain
{
	[Table("Shopping")]
	public class Shopping
	{
		[Key]
		public int Id { get; set; }

		public string Nome { get; set; }

		public string CNPJ { get; set; }

		public int EnderecoId { get; set; }

		[ForeignKey("EnderecoId")]
		public virtual Endereco Endereco { get; set; }

		public virtual List<Mesa> Mesas { get; set; }
	}
}
