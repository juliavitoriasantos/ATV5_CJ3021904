using System.ComponentModel.Design;
using System.Runtime.Serialization;

namespace ATV5_CJ3021904
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====MENU=====");
            Console.WriteLine("Digite 0 para o exemplo= ");
            Console.WriteLine("Digite 1 para o exercício 1= ");
            Console.WriteLine("Digite 2 para o exercício 2= ");
            Console.WriteLine("Digite 3 para o exercício 3= ");
            Console.WriteLine("Digite 4 para o exercício 4= ");
            Console.WriteLine("Digite 5 para o exercício 5= ");
            Console.WriteLine("Digite 6 para o exercício 6= ");
            Console.WriteLine("Digite 7 para o exercício 7= ");

            int escolha = int.Parse(Console.ReadLine());
            switch (escolha) {

                case 0:

                    Console.WriteLine("Sistema do Marquesito");

                    int a, temp;
            int soma = 0;


            for (a = 0; a < 3; a++)
            {
                Console.WriteLine("Digite um valor");

                temp = int.Parse(Console.ReadLine());
                if (temp < 0)
                    break;

                soma = soma + temp;

                       
            }
            Console.WriteLine("A média é {0}", soma / 3);

                    break;

            //Exercício 1

                    case 1:

            int n, i;

            Console.WriteLine("Digite um valor");
            i = int.Parse(Console.ReadLine());

            for (n = 1; n <= i; n++)
            {

                Console.WriteLine(n);
            }
                    break; 

            //Exercício 2

                    case 2:

            int n1, i1;

            Console.WriteLine("Digite um valor");
            i1 = int.Parse(Console.ReadLine());

                    for (n1 = 0; n1 <= i1; n1++)
                    {

                        if (n1 % 2 == 0) { 

                        Console.WriteLine(n1);
                    }
            }
                    break;

                    case 3:

                    int c, d;

                    Console.WriteLine("Digite um valor");
                    c = int.Parse(Console.ReadLine());

                    for (d = c; d < 1000; d++)
                    {

                        if (d % 2 == 0)
                        {

                            Console.WriteLine(d);
                        }
                    }

                    break; 
                
                
                case 4:

                    int k, h;
                    int s = 200;

                        Console.WriteLine("Digite um valor");

                        k = int.Parse(Console.ReadLine());
                       for (h = 1; h < s; h++)
                    {
                        if (h < 0)
                        {
                            Console.WriteLine( "Número inválido");
                        }
                        else { Console.WriteLine(h); }
                    }
                           
                            break;
                
                             case 5:

                            int div, a1;

                            Console.WriteLine("Digite um número inteiro: ");
                            div = int.Parse(Console.ReadLine());    

                            for (a1 = 0; a1 <= div; a1++)
                            {
                                if (div % a1 == 0)
                                {
                                    Console.WriteLine(a1);
                                }
                            }


                break; 
                        
                        
                        case 6:
                      

                            int j, v;

                            for (j = 0; j < 11; j++)
                            {
                                Console.WriteLine("Digite um valor");
                                v = int.Parse(Console.ReadLine());

                                if (v < v)
                                {
                                    Console.WriteLine("Número maior= {0}", v);
                                }
                                if (v > v)
                                {
                                    Console.WriteLine("Número menor= {0}", v);
                                }

                                
                            }

                                break;
                            case 7:

                            int u, l;
                            int si = 0;
                            int sp = 0;


                    for (u = 0; u < 10; u++)
                    {
                        Console.WriteLine("Digite um valor");

                        l = int.Parse(Console.ReadLine());
                        if (l <= 0)
                            break;

                        if (u % 2 != 0)
                        {
                            si = si + u;
                        }
                        if (u % 2 = 0)
                        {
                            sp = sp + u;
                        }

                        Console.WriteLine("Soma dos números Ímpares= {0}, ", si, "Soma dos números Pares= {1} ", sp);
                    }



                                break;




                        }
        }
    }
}
