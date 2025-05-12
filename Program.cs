Console.Clear();

ExibeMenu();

Console.Write("\nSelecione uma opção do menu: ");
string entrada = Console
    .ReadLine()! // ReadLine é para let o que o usuário digitou.
    .Substring(0,1) // Substring é para pegar o primeiro caractere que o usuário digitar.
    .ToUpper(); // ToUpper para deixar tudo em maiusculo.

// -------------- Opção 1. --------------
string resultado = ProcessaEscolhaMenu(entrada);
Console.WriteLine(resultado);

// -------------- Opção 2. --------------
//Console.WriteLine(ProcessaEscolhaMenu(entrada));

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
// -------------- Primeiro método feito. --------------

// string ProcessaEscolhaMenu(string escolha)
// {
//     string resultado = "";
//     switch(escolha)
//     {
//         case "N": // Case "N" serve para caso o usuário tenha digitado "N" e irá aparecer "Novo Arquivo" logo a seguir. 
//             resultado = "Novo arquivo";
//             break; // Break serve para encerrar o programa.
//         case "A":
//             resultado = "Abrir arquivo";
//             break;
//         case "H":
//             resultado = "Ajuda";
//             break;
//         case "X":
//             resultado = "Sair";
//             break;
//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
    
//     return resultado;
// }

// -------------- Segundo método feito. --------------

// string ProcessaEscolhaMenu(string escolha)
// {
//     string resultado = "";
//     resultado = escolha switch
//     {
//         "N" or "n" => "Novo arquivo",
//         "A" or "a" => "Abrir arquivo",
//         "H" or "h" => "Ajuda",
//         "X" or "x" => "Sair",
//         _ => "Opção inválida",
//     };
//     return resultado;
// }

// -------------- Terceiro método ainda mais simplificado --------------

string ProcessaEscolhaMenu(string escolha) => escolha switch
{
    "N" or "n" => "Novo arquivo",
    "A" or "a" => "Abrir arquivo",
    "H" or "h" => "Ajuda",
    "X" or "x" => "Sair",
    _ => "Opção inválida",
};