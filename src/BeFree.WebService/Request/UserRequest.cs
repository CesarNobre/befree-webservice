using System;

namespace BeFree.WebService.Request
{
	public class UserRequest
	{
		public string PrimeiroNome { get; set; }

		public string UltimoNome { get; set; }

		public DateTime DataDeNascimento { get; set; }
	}
}