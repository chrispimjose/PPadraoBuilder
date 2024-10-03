namespace PPadrãoBuilder
{
	internal class Program
	{
		// Uso
		static void Main(string[] args)
		{
			Diretor diretor = new Diretor();
			IComputadorBuilder builder;

			Console.Write("Qual tipo de computador deseja montar? (gamer/básico): ");
			string escolha = Console.ReadLine().ToLower();

			if (escolha == "gamer")
			{
				builder = new ComputadorGamerBuilder();
			}
			else if (escolha == "básico" || escolha == "basico")
			{
				builder = new ComputadorBasicoBuilder();
			}
			else
			{
				Console.WriteLine("Opção desconhecida.");
				return;
			}

			diretor.ConstruirComputador(builder);
			Computador computador = builder.ObterComputador();

			Console.WriteLine("\nEspecificações do Computador:");
			computador.MostrarEspecificacoes();
		}

	} // fim da classe Program
}

