namespace DiamantedeLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Digite uma letra de A a Z: ");

            char escolha = Convert.ToChar(Console.ReadLine().ToUpper());

            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            char[] letra = alfabeto.ToCharArray();
            int indice = 1;

            for (int z = 0; z < letra.Length; z++)
            {
                if (escolha == letra[z])
                {
                    indice += Array.IndexOf(letra, escolha);

                    for (int i = 0; i < indice; i++)
                    {

                        for (int j = 0; j < indice - i; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int k = 0; k < 1; k++)
                        {
                            Console.Write(letra[i]);

                            for (int l = 0; l <= 2 * i - 2; l++)
                            {
                                Console.Write(" ");
                            }
                            if (i != k)
                            {
                                Console.Write(letra[i]);
                            }
                            Console.WriteLine();
                        }
                    }

                    for (int i = indice - 2; i >= 0; i--)
                    {

                        for (int j = 0; j < indice - i; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int k = 0; k < 1; k++)
                        {
                            Console.Write(letra[i]);

                            for (int l = 0; l <= 2 * i - 2; l++)
                            {
                                Console.Write(" ");
                            }
                            if (i != k)
                            {
                                Console.Write(letra[i]);
                            }
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.Write("Letra Inválida, tente novamente: ");
                    escolha = Convert.ToChar(Console.ReadLine().ToUpper());
                    continue;
                }
            }
        }
    }
}