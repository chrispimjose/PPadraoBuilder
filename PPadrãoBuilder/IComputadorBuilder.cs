using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPadrãoBuilder
{
	internal interface IComputadorBuilder
	{
		// Interface Builder
		void ConfigurarCPU();
		void ConfigurarGPU();
		void ConfigurarRAM();
		void ConfigurarArmazenamento();
		void InstalarSO();
		Computador ObterComputador();

	}
}
