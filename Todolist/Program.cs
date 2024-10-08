using System.Runtime.CompilerServices;

List<string> lista = new List<string>();
bool deveSair = false;

while (!deveSair)
{
    Console.WriteLine();
    Console.WriteLine("O que você quer fazer ?");
    Console.WriteLine("Ver toda a lista (1)");
    Console.WriteLine("Adicionar um item à lista (2)");
    Console.WriteLine("Remover um item da lista (3)");
    Console.WriteLine("Sair (4)");

    string escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
            {
                ListarItens();
            }
            break;

        case "2":
            {
                AddItem();
            }
            break;

        case "3":
            {
                RemoverItem();
            }
            break;

        case "4":
            {
                Environment.Exit(0);
            }
            break;


        default:
            Console.WriteLine("Entrada inválida!");
            break;
    }
}
while (true) ;

void ListarItens()
{
    if (lista.Count == 0)
    {
        ExibirMensagemListaVazia();
        return;
    }

    for (int i = 0; i < lista.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {lista[i]}");
    }
}

void AddItem()
{
    string item;

    do
    {
        Console.WriteLine("\n Insira seu item: ");
        item = Console.ReadLine();
    }
    while (!IsItemValido(item));

    lista.Add(item);
}

bool IsItemValido(string item)
{
    if (item == "")
    {
        Console.WriteLine("O item não pode estar vazio!");
        return false;
    }

    else if (lista.Contains(item))
    {
        Console.WriteLine("O item já existe na lista!");
        return false;
    }
    return true;
}

void RemoverItem()
{
    Console.WriteLine("Itens da lista: ");
    ListarItens();

    if (lista.Count == 0)
    {
        ExibirMensagemListaVazia();
        return;
    }

    int i;
    do
    {
        Console.WriteLine("Insira o índice do item que deseja remover: ");
        ListarItens();
    } while (!VerificarIndice(out i));

    RemoverItemNoIndice(i - 1);
}

bool VerificarIndice(out int i)
{
    var item = Console.ReadLine();

    if (item == "")
    {
        i = 0;
        Console.WriteLine("Índice inválido! ");
        return false;
    }

    if (int.TryParse(item, out i) && i >= 1 && i <= lista.Count)
    {
        return true;
    }

    Console.WriteLine("O índice passado não é válido!");
    return false;
}

void ExibirMensagemListaVazia()
{
    Console.WriteLine("A lista está vazia!");
}

void RemoverItemNoIndice(int i)
{
    var itemaSerRemovido = lista[i];
    lista.RemoveAt(i);
    Console.WriteLine("Item removido: " + itemaSerRemovido);
}

Console.ReadKey();