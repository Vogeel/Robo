using System;

namespace Robo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxX;
            int maxY;
            string posicao;
            int posicaoX = 'b';
            int posicaoY = 'b';
            int posicaoX2 = 'a';
            int posicaoY2 = 'a';
            string Posicao = "b";
            char olhando = 'b';
            char olhando2 = 'a';
            string direcao;
            bool robo2 = false;
            

            
            volta:
            Console.WriteLine("Digite o tamanho da área para ser especulada em X e Y, (por exemplo 4 6, sendo 4 X e Y 6)");
            posicao = Console.ReadLine();

            try
            {
                maxX = int.Parse(posicao.Split(' ')[0]);
                maxY = int.Parse(posicao.Split(' ')[1]);

            }
            catch (Exception)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Deu algum erro, digite novamente");
                Console.ResetColor();
                goto volta;
            }
            Console.Clear();
            volta4:
            if (robo2 == true)
            {
            volta3:
                Console.WriteLine("Digite a posição que você quer que o segundo robo inicie (X e Y) com o lugar que ele está olhando (N S L O), separando com espaços (exemplo 0 0 N)");
                Posicao = Console.ReadLine();

                try
                {
                    posicaoX2 = int.Parse(Posicao.Split(' ')[0]);
                    posicaoY2 = int.Parse(Posicao.Split(' ')[1]);
                    olhando2 = char.Parse(Posicao.ToUpper().Split(' ')[2]);

                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Deu algum erro, digite novamente");
                    Console.ResetColor();
                    goto volta3;
                }
            }
            else
            {


            volta1:
                Console.WriteLine("Digite a posição que você quer que o robo inicie (X e Y) com o lugar que ele está olhando (N S L O), separando com espaços (exemplo 0 0 N)");
                Posicao = Console.ReadLine();

                try
                {
                    posicaoX = int.Parse(Posicao.Split(' ')[0]);
                    posicaoY = int.Parse(Posicao.Split(' ')[1]);
                    olhando = char.Parse(Posicao.ToUpper().Split(' ')[2]);

                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Deu algum erro, digite novamente");
                    Console.ResetColor();
                    goto volta1;
                }
            }
            Console.Clear();
            volta2:
            Console.WriteLine("Digite a letra E para virar 90 graus para esquerda\nDigite a letra D para virar 90 graus para direita" +
                "\nDigite M para seguir em frente a ultima direção");

            direcao = Console.ReadLine();

            char[] instrucao = direcao.ToUpper().ToCharArray();

            for (int i = 0; i < instrucao.Length; i++)
            {
                if (instrucao[i] != 'E' && instrucao[i] != 'D' && instrucao[i] != 'M')
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Deu algum erro, digite novamente");
                    Console.ResetColor();
                    goto volta2;
                }
                
            }
            
            for (int i = 0; i < instrucao.Length; i++)
            {
                if (robo2 == true)
                {
                    if (instrucao[i] == 'E')
                    {
                        switch (olhando2)
                        {
                            case 'N':
                                olhando2 = 'O';
                                break;

                            case 'O':
                                olhando2 = 'S';
                                break;

                            case 'S':
                                olhando2 = 'L';
                                break;

                            case 'L':
                                olhando2 = 'N';
                                break;
                        }
                    }
                    else if (instrucao[i] == 'D')
                    {
                        switch (olhando2)
                        {
                            case 'N':
                                olhando2 = 'L';
                                break;

                            case 'L':
                                olhando2 = 'S';
                                break;

                            case 'S':
                                olhando2 = 'O';
                                break;

                            case 'O':
                                olhando2 = 'N';
                                break;
                        }

                    }
                    else if (instrucao[i] == 'M')
                    {
                        switch (olhando2)
                        {
                            case 'N':
                                if (posicaoY2 < maxY)
                                {
                                    posicaoY2 = posicaoY2 + 1;
                                }
                                break;

                            case 'L':
                                if (posicaoX2 < maxX)
                                {
                                    posicaoX2 = posicaoX2 + 1;
                                }
                                break;

                            case 'S':
                                if (posicaoY2 > 0)
                                {
                                    posicaoY2 = posicaoY2 - 1;
                                }
                                break;

                            case 'O':
                                if (posicaoX2 > 0)
                                {
                                    posicaoX2 = posicaoX2 - 1;
                                }
                                break;
                        }

                    }

                }
                else
                {
                    if (instrucao[i] == 'E')
                    {
                        switch (olhando)
                        {
                            case 'N':
                                olhando = 'O';
                                break;

                            case 'O':
                                olhando = 'S';
                                break;

                            case 'S':
                                olhando = 'L';
                                break;

                            case 'L':
                                olhando = 'N';
                                break;
                        }
                    }
                    else if (instrucao[i] == 'D')
                    {
                        switch (olhando)
                        {
                            case 'N':
                                olhando = 'L';
                                break;

                            case 'L':
                                olhando = 'S';
                                break;

                            case 'S':
                                olhando = 'O';
                                break;

                            case 'O':
                                olhando = 'N';
                                break;
                        }

                    }
                    else if (instrucao[i] == 'M')
                    {
                        switch (olhando)
                        {
                            case 'N':
                                if (posicaoY < maxY)
                                {
                                    posicaoY = posicaoY + 1;
                                }
                                break;

                            case 'L':
                                if (posicaoX < maxX)
                                {
                                    posicaoX = posicaoX + 1;
                                }
                                break;

                            case 'S':
                                if (posicaoY > 0)
                                {
                                    posicaoY = posicaoY - 1;
                                }
                                break;

                            case 'O':
                                if (posicaoX > 0)
                                {
                                    posicaoX = posicaoX - 1;
                                }
                                break;
                        }

                    }

                }


            }
            if (robo2 == false)
            {
                robo2 = true;
                Console.WriteLine($"A posição final do primeiro robo é X: {posicaoX} Y: {posicaoY} e sua direção: {olhando}");
                Console.ReadKey();
                Console.Clear();
                goto volta4;
            }
            
            if(robo2 == true)
            
            Console.WriteLine($"A posição final do segundo robo é X: {posicaoX2} Y: {posicaoY2} e sua direção: {olhando2}");
            Console.WriteLine($"A posição final do primeiro robo é X: {posicaoX} Y: {posicaoY} e sua direção: {olhando}");

            Console.ReadKey();





        }
    }
}
