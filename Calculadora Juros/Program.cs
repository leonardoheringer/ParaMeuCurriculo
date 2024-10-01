using System;


        double escolha, juros, periodo, total, inicial, montante;
        bool calcular = true;

        while (calcular)
        {
            Console.WriteLine("BEM-VINDO À CALCULADORA DE JUROS");
            Console.WriteLine("Deseja calcular:");
            Console.WriteLine("1 - Juros Simples");
            Console.WriteLine("2 - Juros Compostos");
            Console.Write("Escolha uma opção: ");

            if (!double.TryParse(Console.ReadLine(), out escolha))
            {
                Console.WriteLine("Valor Inválido! Insira um Número.");
                continue; // Retorna ao início do loop
            }

            switch (escolha)
            {
                case 1: // Juros Simples
                    Console.WriteLine("Qual o valor inicial?");
                    if (!double.TryParse(Console.ReadLine(), out inicial))
                    {
                        Console.WriteLine("Valor Inválido! Insira um Número.");
                        continue; // Retorna ao início do loop
                    }

                    Console.WriteLine("Taxa de juros (% ao ano):");
                    if (!double.TryParse(Console.ReadLine(), out juros))
                    {
                        Console.WriteLine("Valor Inválido! Insira um Número.");
                        continue; // Retorna ao início do loop
                    }

                    Console.WriteLine("Período (anos):");
                    if (!double.TryParse(Console.ReadLine(), out periodo))
                    {
                        Console.WriteLine("Valor Inválido! Insira um Número.");
                        continue; // Retorna ao início do loop
                    }

                    // Cálculo de juros simples
                    juros /= 100; // Converte a taxa de percentual para decimal
                    total = inicial * juros * periodo;
                    montante = inicial + total;

                    Console.WriteLine($"Total de juros será de R$ {total:F2}, o valor total será de R$ {montante:F2}");
                    break;

                case 2: // Juros Compostos
                    Console.WriteLine("Qual o valor inicial?");
                    if (!double.TryParse(Console.ReadLine(), out inicial))
                    {
                        Console.WriteLine("Valor Inválido! Insira um Número.");
                        continue; // Retorna ao início do loop
                    }

                    Console.WriteLine("Taxa de juros (% ao ano):");
                    if (!double.TryParse(Console.ReadLine(), out juros))
                    {
                        Console.WriteLine("Valor Inválido! Insira um Número.");
                        continue; // Retorna ao início do loop
                    }

                    Console.WriteLine("Período (anos):");
                    if (!double.TryParse(Console.ReadLine(), out periodo))
                    {
                        Console.WriteLine("Valor Inválido! Insira um Número.");
                        continue; // Retorna ao início do loop
                    }

                    // Cálculo de juros compostos
                    juros /= 100; // Converte a taxa de percentual para decimal
                    montante = inicial * Math.Pow((1 + juros), periodo);
                    total = montante - inicial; // Juros acumulados

                    Console.WriteLine($"Total de juros será de R$ {total:F2}, o valor total será de R$ {montante:F2}");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            // Pergunta se o usuário deseja continuar
            Console.WriteLine("Deseja fazer outro cálculo? (s/n)");
            var continuar = Console.ReadLine();
            if (continuar?.ToLower() != "s")
            {
                Console.WriteLine("Obrigado!");
                calcular = false;
            }
        }
    