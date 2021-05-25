using System;
using System.Linq;

namespace TesteEstagio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[9];
            int sum =0;

            float media;

            Console.WriteLine("Insira amostras de nota(max 10)");

            for (int i = 0; i < notas.Length; i++) {
                int Index = i + 1;
                Console.Write("Nota "+ Index + ": ");
                notas[i]= Convert.ToInt32(Console.ReadLine());
                sum += notas[i];
            }

            media =  sum / notas.Length;
            
            Console.WriteLine("Média da amostragem: " + media);

            int[] newArrNota = new int[5];
           
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] > media)
                {
                    newArrNota[i] = notas[i];
                }
            }

            int item = 0;

            newArrNota = newArrNota.Where(e => e != item).ToArray();
            Console.WriteLine("Notas Consideradas");
            Console.WriteLine(String.Join(",", newArrNota));
            
            double notaConsi = Convert.ToDouble(newArrNota.Length) / notas.Length;

            double percentual = notaConsi * 100;

            Console.WriteLine("Percentual:" + percentual + "%");

        }
    }
}
