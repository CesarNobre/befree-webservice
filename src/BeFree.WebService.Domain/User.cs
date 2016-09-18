using System;
using System.ComponentModel.DataAnnotations;

namespace BeFree.WebService.Domain
{
	public class User
	{
		[Key]
		public int Id { get; set; }

		public string PrimeiroNome { get; set; }

		public string UltimoNome { get; set; }

		public DateTime DataDeNascimento { get; set; }

		public string NomeCompleto()
		{
			return this.PrimeiroNome + this.UltimoNome;
		}
	}
}
