//3 - faça um programa que leia os 3 lados de um triangulo e informe o tipo dele (google)

float lado1 = 0, lado2 = 0, lado3 = 0;
int contador;

contador = 1;
while (contador <= 3)
{
    if (contador == 1)
    {
        while(lado1 <= 0)
        {
            Console.WriteLine($"Por favor, informe {contador}o lado do triângulo.");
            lado1 = float.Parse(Console.ReadLine());
        }
    } else if (contador == 2)
    {
        while (lado2 <= 0)
        {
            Console.WriteLine($"Por favor, informe {contador}o lado do triângulo.");
            lado2 = float.Parse(Console.ReadLine());
        }
    } else
    {
        while (lado3 <= 0)
        {
            Console.WriteLine($"Por favor, informe {contador}o lado do triângulo.");
            lado3 = float.Parse(Console.ReadLine());
        }
    }
    contador++;
}

Console.WriteLine($"Lados do triângulo: {lado1}, {lado2} e {lado3}");
if ((lado1 == lado2) && (lado2 == lado3))
{
    Console.WriteLine("O triângulo é Equilátero (Possui 3 lados iguais).");
} else if ((lado1 == lado2) || (lado2 == lado3) | (lado1 == lado3))
{
    Console.WriteLine("O triângulo é Isóceles (Possui dois lados iguais e um diferente).");
} else
{
    Console.WriteLine("O triângulo é Escaleno (Possui três lados diferentes).");
}

// equilatero = 3 lados iguais
// isoceles = dois lados iguais e um diferente
// escaleno = 3 lados diferentes

Console.ReadKey();
