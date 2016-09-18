using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BeFree.WebService.Domain
{
	public class Mesa
	{
		[Key]
		public int Id { get; set; }

		public virtual List<Cadeira> Cadeiras { get; set; }

		public bool TemCadeirasDisponiveis()
		{
			return this.Cadeiras.Any(cadeira => cadeira.Disponivel);
		}
	}
}
