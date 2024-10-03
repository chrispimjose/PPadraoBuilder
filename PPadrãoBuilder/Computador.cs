using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPadrãoBuilder
{
	internal class Computador
	{
		// Produto final
		public string CPU { get; set; }
		public string GPU { get; set; }
		public int RAM { get; set; }
		public int Armazenamento { get; set; }
		public string SistemaOperacional { get; set; }

		// Método para exibir as especificações
		public void MostrarEspecificacoes()
		{
			Console.WriteLine($"CPU: {CPU}");
			Console.WriteLine($"GPU: {GPU}");
			Console.WriteLine($"RAM: {RAM} GB");
			Console.WriteLine($"Armazenamento: {Armazenamento} GB");
			Console.WriteLine($"Sistema Operacional: {SistemaOperacional}");
		}

	}
}
