using System.Diagnostics;

Console.Write("Qual operação irá utilizar? ");
char operacao = char.Parse(Console.ReadLine());

Console.Write("Digite o primeiro número: ");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o segundo número: ");
double n2 = Convert.ToDouble(Console.ReadLine());

double resultado;

switch (operacao)
{
    case '+':
        resultado = n1 + n2;
        Console.WriteLine("O resultado de {0} {1} {2}  = {3}", n1, operacao, n2, resultado);
        break;
    case '-':
        resultado = n1 - n2;
        Console.WriteLine("O resultado de {0} {1} {2}  = {3}", n1, operacao, n2, resultado);
        break;
    case '*':
        resultado = n1 * n2;
        Console.WriteLine("O resultado de {0} {1} {2}  = {3}", n1, operacao, n2, resultado);
        break;
    case '/':
        if (n1 != 0 && n2 != 0)
        {
            resultado = n1 / n2;
            Console.WriteLine("O resultado de {0} {1} {2}  = {3}", n1, operacao, n2, resultado);
        }
        else
        {
            Console.WriteLine("Não utilizar 0 na divisão");
        }
        break;
}
