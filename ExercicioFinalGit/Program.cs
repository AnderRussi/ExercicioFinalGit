
// See https://aka.ms/new-console-template for more information
//declaração das variáveis
int idade, sexo;

//comandos de entrada e leitura de dados
Console.WriteLine("Verificação para possivel alistamento militar: ");
Console.WriteLine("Informe a idade da pessoa: ");
idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nInforme o sexo da pessoa, sendo 1- Masculino 2-Feminino: ");
sexo = Convert.ToInt32(Console.ReadLine());

//Estrutura de seleção
//Se a idade for maior ou igual a 18
if (idade >= 18)
{
    //Bloco verdade
    //Verifica o sexo, se for igual 1
    if (sexo == 1)
    {
        //Bloco verdade
        Console.WriteLine("Você deve se alistar no exército!");
    }
    else // se não
    {
        //Bloco Falso
        Console.WriteLine("Você não se enquadra para alistamento militar");
    }
}
else //se não
{
    //Bloco falso
    Console.WriteLine("Você não tem idade suficiente para alistamento militar!");
}
