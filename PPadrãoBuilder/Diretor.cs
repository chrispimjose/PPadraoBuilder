using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPadrãoBuilder
{
	internal class Diretor
	{
		// Diretor
		public void ConstruirComputador(IComputadorBuilder builder)
		{
			builder.ConfigurarCPU();
			builder.ConfigurarGPU();
			builder.ConfigurarRAM();
			builder.ConfigurarArmazenamento();
			builder.InstalarSO();
		}

	}
}
