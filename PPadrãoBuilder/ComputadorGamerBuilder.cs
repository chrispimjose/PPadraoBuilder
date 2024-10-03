using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPadrãoBuilder
{
	internal class ComputadorGamerBuilder : IComputadorBuilder
	{
		private Computador computador = new Computador();

		public void ConfigurarCPU()
		{
			computador.CPU = "Intel Core i9";
		}

		public void ConfigurarGPU()
		{
			computador.GPU = "NVIDIA RTX 3080";
		}

		public void ConfigurarRAM()
		{
			computador.RAM = 32;
		}

		public void ConfigurarArmazenamento()
		{
			computador.Armazenamento = 2000;
		}

		public void InstalarSO()
		{
			computador.SistemaOperacional = "Windows 11";
		}

		public Computador ObterComputador()
		{
			return computador;
		}
	}
}
