using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    public class Elevador
    {
        public int Inicializar(int capacidade, int totalAndares)
        {
            int codmsg = 0;
            return codmsg;
        }

        public int Entrar(int capacidade, int nrPesAtual)
        {
            if (nrPesAtual < capacidade) nrPesAtual = nrPesAtual + 1;
            else Console.WriteLine("Elevador lotou ");
            return nrPesAtual;
        }

        public int Sair(int nrPesAtual)
        {
            if (nrPesAtual != 0) nrPesAtual = (nrPesAtual - 1);
            else
            {
                Console.WriteLine("Elevador vazio " + nrPesAtual.ToString());
            }
            return nrPesAtual;
        }

        public int Subir(int andarAlvo, int totalAndares, int andarAtual)
        {
            if (andarAlvo > totalAndares) Console.WriteLine("Você atingiu o topo " + andarAlvo.ToString());
            else
            {
                while (andarAtual != andarAlvo)
                {
                    andarAtual = andarAtual + 1;
                    Console.WriteLine("Subindo " + andarAtual.ToString());
                }
                Console.WriteLine("Chegou no andar " + andarAtual.ToString());
            }
            return andarAtual;
        }
        public int Descer(int andarAtual, int andarAlvo)
        {
            while (andarAtual != andarAlvo)
            {
                andarAtual = andarAtual - 1;
                Console.WriteLine("Descendo " + andarAtual.ToString());
            }
            Console.WriteLine("Chegou no andar " + andarAtual.ToString());
            return andarAtual;
        }

    }
}
