//3 - faça um programa que leia os 3 lados de um triangulo e informe o tipo dele (google)

double ladoA, ladoB, ladoC;
int contador;
Boolean invalido = true;
string sair;
ladoA = 0;
ladoB = 0;
ladoC = 0;
sair = "N";

while (sair != "S" && sair != "s"){
    while (invalido == true)
    {
        contador = 1;
        ladoA = 0;
        ladoB = 0;
        ladoC = 0;

        while (contador <= 3)
        {
            if (contador == 1)
            {
                while (ladoA <= 0)
                {
                    Console.WriteLine($"Por favor, informe {contador}o lado do triângulo.");
                    ladoA = double.Parse(Console.ReadLine());
                }
            }
            else if (contador == 2)
            {
                while (ladoB <= 0)
                {
                    Console.WriteLine($"Por favor, informe {contador}o lado do triângulo.");
                    ladoB = double.Parse(Console.ReadLine());
                }
            }
            else
            {
                while (ladoC <= 0)
                {
                    Console.WriteLine($"Por favor, informe {contador}o lado do triângulo.");
                    ladoC = double.Parse(Console.ReadLine());
                }
            }
            contador++;
        }
        // verifica se os lados condizem com a existencia do triangulo
        if ((ladoA < (ladoB + ladoC)) && (ladoB < (ladoA + ladoC)) && (ladoC < (ladoA + ladoB)))
        {
            invalido = false;
        }
        else
        {
            Console.WriteLine("Atenção: Você inseriu valores que não são válidos.");
            Console.WriteLine("Para três segmentos fecharem um triângulo, cada lado deve ser menor que a soma dos outros dois.");
            Console.WriteLine($"{ladoA} < {ladoA + ladoB} ({ladoB} + {ladoC}) ?");
            Console.WriteLine($"{ladoB} < {ladoA + ladoC} ({ladoA} + {ladoC}) ?");
            Console.WriteLine($"{ladoC} < {ladoB + ladoA} ({ladoB} + {ladoA}) ?");
            Console.WriteLine("Informe os valores novamente!");
            Console.WriteLine("-----------------------------------------------------------------------------");
            invalido = true;
        }
    }

    Console.WriteLine($"Lados do triângulo: {ladoA}, {ladoB} e {ladoC}");
    if ((ladoA == ladoB) && (ladoB == ladoC))
    {
        Console.WriteLine("O triângulo é Equilátero (Possui 3 lados iguais).");
    }
    else if ((ladoA == ladoB) || (ladoB == ladoC) || (ladoA == ladoC))
    {
        Console.WriteLine("O triângulo é Isóceles (Possui dois lados iguais e um diferente).");
    }
    else
    {
        Console.WriteLine("O triângulo é Escaleno (Possui três lados diferentes).");
    }

    // equilatero = 3 lados iguais
    // isoceles = dois lados iguais e um diferente
    // escaleno = 3 lados diferentes
    Console.WriteLine("Digite S para sair do programa ou aperte qualquer tecla para repetir.");
    sair = Console.ReadLine();
    if (sair != "S" && sair != "s")
    {
        contador = 1;
        ladoA = 0;
        ladoB = 0;
        ladoC = 0;
        invalido = true;
        Console.Clear();
    }
}
Console.ReadKey();
