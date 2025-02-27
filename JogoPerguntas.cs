using System;

public class JogoPerguntas
{
	public JogoPerguntas()
	{
		int pontuacao = 0;
		int nivel = 1;

		Console.WriteLine("Bem-vindo ao jogo de perguntas e respostas!");
        
		while (true)
		{
			Console.WriteLine($"\nNível {nivel}: ");

			if (nivel == 1)
			{
				Console.WriteLine("Qual a capital do Brasil?");
				string resposta = Console.ReadLine();

				if(resposta.ToLower() == "brasilia")
				{
					Console.WriteLine("Resposta correta!");
					pontuacao += 10;
				}
				else
				{
					Console.WriteLine("Resposta incorreta!");
				}
			}
			else if (nivel == 2)
			{
				Console.WriteLine("Quanto é 2 + 2?");
				int resposta = int.Parse(Console.ReadLine());

				if(resposta == 4)
				{
					Console.WriteLine("Resposta correta!");
					pontuacao += 20;
				}
				else
				{
					Console.WriteLine("Resposta incorreta!");
				}
			}
			Console.WriteLine($"Pontuação: {pontuacao}");

			if(pontuacao >= nivel * 30)
			{
				nivel++;
				Console.WriteLine($"Parabéns! Você passou para o nível {nivel}!");
			}
			Console.WriteLine("\n Deseja continuar? (s/n)");
			string continuar = Console.ReadLine();

			if(continuar.ToLower() != "s")
			{
				break;
			}
		}
		Console.WriteLine("\nObrigado por Jogar!");




    }
}
