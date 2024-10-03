using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPadrãoBuilder
{
	internal class ComputadorBasicoBuilder : IComputadorBuilder
	{
		private Computador computador = new Computador();

		public void ConfigurarCPU()
		{
			computador.CPU = "Intel Core i3";
		}

		public void ConfigurarGPU()
		{
			computador.GPU = "Gráficos Integrados";
		}

		public void ConfigurarRAM()
		{
			computador.RAM = 8;
		}

		public void ConfigurarArmazenamento()
		{
			computador.Armazenamento = 500;
		}

		public void InstalarSO()
		{
			computador.SistemaOperacional = "Linux Ubuntu";
		}

		public Computador ObterComputador()
		{
			return computador;
		}

	}
}
