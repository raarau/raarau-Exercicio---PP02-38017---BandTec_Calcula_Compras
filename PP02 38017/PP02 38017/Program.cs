using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP02_38017
{
    class Program
    {
        static void Main(string[] args)
        {
            float parcela;
            float valor;
            float quantia;

            Console.WriteLine("Digite o valor do produto: ");
            valor = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a unidade de produtos que deseja comprar: ");
            quantia = float.Parse(Console.ReadLine());
            float calculaQta = quantia * valor;
            float total;
            int op;

            if (calculaQta <= 500.00)
            {

                total = calculaQta * 0.8f;
                Console.WriteLine("\nO pagamento devera ser feito à vista, o valor de sua compra é: {0:C}", calculaQta);
                Console.WriteLine("E recebeu um desconto de 20% total a pagar é: {0:C}", total);
            }
            else
            {

                Console.WriteLine("Escolha o modo de pagamento:");
                Console.WriteLine("1 - A vista");
                Console.WriteLine("2 - Parcelado em x2");
                Console.WriteLine("3 - Parcelado em x3");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {

                    case 1:

                        total = calculaQta * 0.8f;
                        Console.WriteLine("\nO valor de sua compra é: {0:C}", calculaQta);
                        Console.WriteLine("E recebeu um desconto de 20% valor total a pagar: {0:C}", total);

                        break;

                    case 2:

                        total = calculaQta * 0.85f;
                        parcela = total / 2;
                        Console.WriteLine("\nO valor de sua compra é: {0:C}", calculaQta);
                        Console.WriteLine("E recebeu um desconto de 15% valor total a pagar: {0:C}", total);
                        Console.WriteLine("\nVocê devera pagar 2x parcelas de: {0:C}", parcela);
                        break;

                    case 3:

                        total = calculaQta * 0.88f;
                        parcela = total / 3;
                        Console.WriteLine("\nO valor de sua compra é: {0:C}", calculaQta);
                        Console.WriteLine("E recebeu um desconto de 12% valor total a pagar: {0:C}", total);
                        Console.WriteLine("Você devera pagar 2x parcelas de: {0:C}", parcela);
                        break;

                    default:
                        Console.WriteLine("Numero inválido.");
                        break;
                }

            }
            Console.ReadKey();



        }
    }
}
