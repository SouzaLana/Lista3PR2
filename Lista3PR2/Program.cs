using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("=====MENU=====");
            Console.WriteLine("1- Exercício 1");
            Console.WriteLine("2- Exercício 2");
            Console.WriteLine("3- Exercício 3");
            Console.WriteLine("4- Exercício 4");
            Console.WriteLine("5- Exercício 5");
            Console.WriteLine("6- Exercício 6");
            Console.WriteLine("Digite a opção desejada: ");

            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    int sem;

                    Console.WriteLine("=====MENU=====");
                    Console.WriteLine("1- Domingo");
                    Console.WriteLine("2- Segunda-Feira");
                    Console.WriteLine("3- Terça-Feira");
                    Console.WriteLine("5- Quarta-Feira");
                    Console.WriteLine("6- Quinta-Feira");
                    Console.WriteLine("7- Sexta-Feira");
                    Console.WriteLine("7- Sábado");
                    Console.WriteLine("Digite uma opção: ");
                    sem = int.Parse(Console.ReadLine());

                    switch (sem)
                    {
                        case 1:
                            Console.WriteLine("Domingo");
                            break;
                        case 2:
                            Console.WriteLine("Segunda-Feira");
                            break;
                        case 3:
                            Console.WriteLine("Terça-Feira");
                            break;
                        case 4:
                            Console.WriteLine("Quarta-Feira");
                            break;
                        case 5:
                            Console.WriteLine("Quinta-Feira");
                            break;
                        case 6:
                            Console.WriteLine("Sexta-Feira");
                            break;
                        case 7:
                            Console.WriteLine("Sábado");
                            break;
                        default:
                            Console.WriteLine("Valor inválido");
                            break;
                    }
                    Console.ReadKey();
                    break;


                case 2:
                    float val, valT, n;

                    Console.WriteLine("===Menu===");
                    Console.WriteLine("1- à vista");
                    Console.WriteLine("2- PIX");
                    Console.WriteLine("3- Débito");
                    Console.WriteLine("4- Cartão de Crédito");
                    Console.WriteLine("Digite o valor de compra: ");
                    Console.WriteLine("Digite a opção desejada: ");

                    val = float.Parse(Console.ReadLine());
                    n = int.Parse(Console.ReadLine());

                    switch (n)
                    {
                        case 1:
                            valT = ((15 / 100) * val) - val;
                            Console.WriteLine("O valor total é de R$" + valT);
                            break;
                        case 2:
                            valT = ((10 / 10) * val) - val;
                            Console.WriteLine("O valor total é de R$" + valT);
                            break;
                        case 3:
                            valT = ((5 / 100) * val) + val;
                            Console.WriteLine("O valor total é de R$" + valT);
                            break;
                        case 4:
                            valT = ((10 / 100) * val) + val;
                            Console.WriteLine("O valor total é de R$" + valT);
                            break;
                        default:
                            Console.WriteLine("Valor inválido");
                            break;
                    }
                    Console.ReadKey();
                    break;


                case 3:
                    int ano, mes;

                    Console.WriteLine("Digite o ano: ");
                    ano = int.Parse(Console.ReadLine());

                    Console.WriteLine("===Menu===");
                    Console.WriteLine("1- Janeiro");
                    Console.WriteLine("2- Fevereiro");
                    Console.WriteLine("3- Março");
                    Console.WriteLine("4- Abril");
                    Console.WriteLine("5- Maio");
                    Console.WriteLine("6- Junho");
                    Console.WriteLine("7- Julho");
                    Console.WriteLine("8- Agosto");
                    Console.WriteLine("9- Setembro");
                    Console.WriteLine("10- Outubro");
                    Console.WriteLine("11- Novembro");
                    Console.WriteLine("12- Dezembro");
                    Console.WriteLine("Digite o mês: ");

                    mes = int.Parse(Console.ReadLine());

                    switch (mes)
                    {
                        case 1:
                            Console.WriteLine("Janeiro possui 31 dias.");
                            break;
                        case 2:
                            if (ano % 4 == 0)
                            {
                                Console.WriteLine("Fevereiro possui 29 dias.");
                            }
                            else
                            {
                                Console.WriteLine("Fevereiro possui 28 dias.");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Março possui 31 dias.");
                            break;
                        case 4:
                            Console.WriteLine("Abril possui 30 dias.");
                            break;
                        case 5:
                            Console.WriteLine("Maio possui 31 dias.");
                            break;
                        case 6:
                            Console.WriteLine("Junho possui 30 dias.");
                            break;
                        case 7:
                            Console.WriteLine("Julho possui 31 dias.");
                            break;
                        case 8:
                            Console.WriteLine("Agosto possui 31 dias.");
                            break;
                        case 9:
                            Console.WriteLine("Setembro possui 30 dias.");
                            break;
                        case 10:
                            Console.WriteLine("Outubro possui 31 dias.");
                            break;
                        case 11:
                            Console.WriteLine("Novembro possui 30 dias.");
                            break;
                        case 12:
                            Console.WriteLine("Dezembro possui 31 dias.");
                            break;
                        default:
                            Console.WriteLine("Valor inválido");
                            break;
                    }
                    Console.ReadKey();
                    break;

                case 4:
                    int n1, n2, op, resul;
                    double r;

                    Console.WriteLine("Digite o valor do primeiro número: ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor do segundo número: ");
                    n2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("===MENU===");
                    Console.WriteLine("1- +");
                    Console.WriteLine("2- -");
                    Console.WriteLine("3- *");
                    Console.WriteLine("4- /");
                    Console.WriteLine("5- ^");
                    Console.WriteLine("Escolha uma opção: ");

                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            resul = n1 + n2;
                            Console.WriteLine("O resultado é " + resul);
                            break;
                        case 2:
                            resul = n1 - n2;
                            Console.WriteLine("O resultado é " + resul);
                            break;
                        case 3:
                            resul = n1 * n2;
                            Console.WriteLine("O resultado é " + resul);
                            break;
                        case 4:
                            resul = n1 / n2;
                            Console.WriteLine("O resultado é " + resul);
                            break;
                        case 5:
                            r = Math.Pow(n1, n2);
                            Console.WriteLine("O resultado é " + r);
                            break;
                        default:
                            Console.WriteLine("Valor inválido");
                            break;
                    }
                    Console.ReadKey();
                    break;

                case 5:
                    float salA, salN, dif, cargo;

                    Console.WriteLine("=====MENU=====");
                    Console.WriteLine("1- Professor");
                    Console.WriteLine("2- Secretário");
                    Console.WriteLine("3- Publicitário");
                    Console.WriteLine("4- Jornalista");
                    Console.WriteLine("5- Mecânico");
                    Console.WriteLine("6- Estagiário");
                    Console.WriteLine("7- Técnico de TI");
                    Console.WriteLine("8- Digite o cargo: ");
                    cargo = float.Parse(Console.ReadLine());
                    Console.WriteLine("9- Digite o valor do salário: ");
                    salA = float.Parse(Console.ReadLine());

                    switch (cargo)
                    {
                        case 1:
                            salN = (salA * (7.5f / 100)) + salA;
                            dif = salN - salA;
                            Console.WriteLine("O salário passou de R$" + salA + " para R$" + salN + ". A diferença é de R$" + dif);
                            break;
                        case 2:
                            salN = (salA * (9.7f / 100)) + salA;
                            dif = salN - salA;
                            Console.WriteLine("O salário passou de R$" + salA + " para R$" + salN + ". A diferença é de R$" + dif);
                            break;
                        case 3:
                            salN = (salA * (11.7f / 100)) + salA;
                            dif = salN - salA;
                            Console.WriteLine("O salário passou de R$" + salA + " para R$" + salN + ". A diferença é de R$" + dif);
                            break;
                        case 4:
                            salN = (salA * (8.9f / 100)) + salA;
                            dif = salN - salA;
                            Console.WriteLine("O salário passou de R$" + salA + " para R$" + salN + ". A diferença é de R$" + dif);
                            break;
                        case 5:
                            salN = (salA * (13.24f / 100)) + salA;
                            dif = salN - salA;
                            Console.WriteLine("O salário passou de R$" + salA + " para R$" + salN + ". A diferença é de R$" + dif);
                            break;
                        case 6:
                            salN = (salA * (10.4f / 100)) + salA;
                            dif = salN - salA;
                            Console.WriteLine("O salário passou de R$" + salA + " para R$" + salN + ". A diferença é de R$" + dif);
                            break;
                        case 7:
                            salN = (salA * (14.6f / 100)) + salA;
                            dif = salN - salA;
                            Console.WriteLine("O salário passou de R$" + salA + " para R$" + salN + ". A diferença é de R$" + dif);
                            break;
                        default:
                            salN = (salA * (43.5f / 100)) + salA;
                            dif = salN - salA;
                            Console.WriteLine("O salário passou de R$" + salA + " para R$" + salN + ". A diferença é de R$" + dif);
                            break;
                    }
                    Console.ReadKey();
                    break;

                case 6:
                    float sA, rec, sN;

                    Console.WriteLine("Digite o salário mensal: ");
                    sA = float.Parse(Console.ReadLine());

                    if (sA <= 1903.98f)
                    {
                        Console.WriteLine("Insento de imposto de renda");
                    }
                    else if (sA > 1903.98f && sA <= 2826.65f)
                    {
                        rec = sA * (7.5f / 100);
                        sN = sA - rec;
                        Console.WriteLine("Deverá ser recolhido R$" + rec + " do salário mensal. Ficando com R$" + sN);
                    }
                    else if (sA > 2826.65f && sA <= 3751.05f)
                    {
                        rec = sA * (15.0f / 100);
                        sN = sA - rec;
                        Console.WriteLine("Deverá ser recolhido R$" + rec + " do salário mensal. Ficando com R$" + sN);
                    }
                    else if (sA > 3751.05f && sA <= 4664.68f)
                    {
                        rec = sA * (22.5f / 100);
                        sN = sA - rec;
                        Console.WriteLine("Deverá ser recolhido R$" + rec + " do salário mensal. Ficando com R$" + sN);
                    }
                    else if (sA > 4664.68f)
                    {
                        rec = sA * (27.5f / 100);
                        sN = sA - rec;
                        Console.WriteLine("Deverá ser recolhido R$" + rec + " do salário mensal. Ficando com R$" + sN);
                    }
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Valor inválido");
                    break;
            }
            Console.ReadKey();

        }
    }
}
