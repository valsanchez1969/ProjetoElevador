using System;
using ProjetoElevador.Model;


namespace ProjetoElevador
{
    public class Program
    {
        static void Main(string[] args)
        {
            int andarAtual = 0;
            int nrPesAtual = 0;
            int andarAlvo = 1;

            Console.WriteLine("Informe quantos andares tem o prédio, excluindo o térreo: ");
            int totalAndares = int.Parse(Console.ReadLine());

            Console.WriteLine("Capacidade de pessoas no elevador: ");
            int nrPessoas = int.Parse(Console.ReadLine());

            //Console.WriteLine(totalAndares);
            //Console.WriteLine(nrPessoas);

            Elevador elevador = new Elevador();


            while (andarAlvo != 0)
            {
                Console.WriteLine("Digite o andar que você vai: ");
                andarAlvo = int.Parse(Console.ReadLine());
                //Console.WriteLine("Quantas pessoas ficaram no elevador? ");
                //nrPesAtual = int.Parse(Console.ReadLine());

                if (andarAlvo > andarAtual)
                {
                    nrPesAtual = elevador.Entrar(nrPessoas, nrPesAtual);
                    andarAtual = elevador.Subir(andarAlvo, totalAndares, andarAtual);
                }
                if (andarAlvo < andarAtual)
                {
                    nrPesAtual = elevador.Entrar(nrPessoas, nrPesAtual);
                    andarAtual = elevador.Descer(andarAtual, andarAlvo);
                }
                if (andarAlvo == andarAtual)
                {
                    nrPesAtual = elevador.Sair(nrPesAtual);
                }
            }

        }
    }
}
