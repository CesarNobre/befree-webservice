using System.ComponentModel.DataAnnotations;

namespace BeFree.WebService.Domain
{
	public class Endereco
	{
		[Key]
		public int Id { get; set; }

		public string Nome { get; set; }

		public string Cidade { get; set; }

		public string Estado { get; set; }

		public int Cep { get; set; }

		public int Numero { get; set; }
	}
}
