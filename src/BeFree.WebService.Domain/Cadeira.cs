using System.ComponentModel.DataAnnotations.Schema;

namespace BeFree.WebService.Domain
{
	public class Cadeira
	{
		public int Id { get; set; }

		public bool Disponivel { get; set; }

		[ForeignKey("Mesa")]
		public int MesaId { get; set; }

		public virtual Mesa Mesa { get; set; }
	}
}
