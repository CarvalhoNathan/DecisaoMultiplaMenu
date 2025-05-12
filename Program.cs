Console.Clear();

ExibeMenu();

Console.Write("\nSelecione uma opção do menu: ");
string entrada = Console
    .ReadLine()! // ReadLine é para let o que o usuário digitou.
    .Substring(0,1) // Substring é para pegar o primeiro caractere que o usuário digitar.
    .ToUpper(); // ToUpper para deixar tudo em maiusculo.

switch(entrada){
    case "N": // Case "N" serve para caso o usuário tenha digitado "N" e irá aparecer "Novo Arquivo" logo a seguir. 
        Console.WriteLine("Novo arquivo");
        break; // Break serve para encerrar o programa.
    case "A":
        Console.WriteLine("Abrir arquivo");
        break;
    case "H":
        Console.WriteLine("Ajuda");
        break;
    case "X":
        Console.WriteLine("Sair");
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}

void ExibeMenu() // Deixar o "void" no final do código deixa ele mais organizado e melhor na hora de compilar.
{
    Console.WriteLine(
    @"
    Menu de opções 
    ------------------

    N. Novo arquivo
    A. Abrir arquivo
    H. Ajuda
    X. Sair");
// Esse "@" é para poder escrever em mais de uma linha só com apenas uma string.
}