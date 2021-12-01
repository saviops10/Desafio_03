using System;

namespace Desafio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var alunos = 0;
            decimal maior = 0;
            string posicao = "";

            Console.WriteLine("Quantos alunos deseja cadastrar? ");
            alunos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sua lista contém: " + alunos +" alunos.");
            Console.WriteLine("\n");

            string[] StrAlunos = new string[alunos];
            decimal[] notas = new decimal[alunos];

            for (int i = 0; i < alunos; i++)
            {
                Console.WriteLine("Escreva os nome do aluno: " +i);
                StrAlunos[i] = Console.ReadLine();
                Console.WriteLine(StrAlunos[i] + " Foi cadastrado!");
                Console.WriteLine("\n");
                Console.WriteLine("Por favor, informe a nota deste aluno: "+ StrAlunos[i]);
                notas [i] = decimal.Parse(Console.ReadLine());
                Console.WriteLine(" A nota " + notas[i] + " foi atribuida ao aluno " + StrAlunos[i]);
                Console.WriteLine("\n");

            }

            for (int i = 0; i < alunos; i++)
            {
                if (notas[i] > maior) 
                {
                    maior = notas[i];
                    posicao = StrAlunos[i];
                }
            }
            Console.WriteLine("O aluno: " + posicao + " recebeu a maior nota: " + maior);
            Console.WriteLine("da lista de " +StrAlunos.Length+ " alunos.");
            

        }
    }
}