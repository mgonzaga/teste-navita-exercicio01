using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Exercicio01
    {
        public int ObterMaiorNumeroFamiliaN(int valorEntrada)
        {
            var numeros = valorEntrada.ToString().ToList();
            int retorno = -1;
            List<string> numerosGerados = new List<string>();
            List<int> numerosIrmaos = new List<int>();

            if (valorEntrada > 99)
            {
                for (int i = 0; i < numeros.Count; i++)
                {
                    var novaCombinacao = new List<char>();
                    novaCombinacao.AddRange(numeros);
                    novaCombinacao.RemoveAt(i);
                    var indexDigitoAtual = novaCombinacao.Count - 1;
                    for (int digitoAtual = 0; digitoAtual <= novaCombinacao.Count - 1; digitoAtual++)
                    {

                        var ultimoDigito = novaCombinacao[indexDigitoAtual];
                        var penultimoDigito = novaCombinacao[indexDigitoAtual - 1];

                        novaCombinacao[indexDigitoAtual] = penultimoDigito;
                        novaCombinacao[indexDigitoAtual - 1] = ultimoDigito;

                        string s = numeros[i].ToString() + string.Join(string.Empty, novaCombinacao);
                        numerosGerados.Add(s);
                        indexDigitoAtual = (indexDigitoAtual - 1 == 0 ? novaCombinacao.Count - 1 : indexDigitoAtual - 1);
                    }
                    numerosGerados = numerosGerados.Distinct().ToList();
                }

            }
            else if (valorEntrada > 10)
            {
                numerosGerados.Add(valorEntrada.ToString());
                numerosGerados.Add(string.Join(string.Empty, valorEntrada.ToString().Reverse()));
            }

            try
            {
                foreach (var n in numerosGerados)
                {
                    numerosIrmaos.Add(int.Parse(n));
                }
            }
            catch (OverflowException)
            {

                numerosIrmaos = new List<int>();
            }
            
            if (numerosIrmaos.Count > 0) retorno = numerosIrmaos.Max();
            return (retorno > 100000000 ? -1 : retorno);

        }
    }
}
