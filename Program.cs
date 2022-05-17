using static System.Console;
class Aula2
{
    static void Demo2()
    {
        var nomes = new string[] { "Drigo", "Xico", "Trigo", "Docinho", "Digo" };
        ExibirNomes(nomes);
        WriteLine(@"Digite o nome a ser substituido:");
        var nome = ReadLine();
        WriteLine(@"Digite o novo nome:");
        var novoNome = ReadLine();

        AlterarNome(nomes, nome, novoNome);
        ExibirNomes(nomes);
    }
    static void Demo1()
    {
        int a = 5;
        Adicionar20(ref a);
        WriteLine($"O valor de A é {a}");
        //Quando usa o ref antes da vaeriável de tipo value, no lugar de fazer uma cópia da variavel, ele faz uma referencia, podendo alterar valores mesmo estando fora da stack. 
    }
    static void Adicionar20(ref int a)
    {
        a += 20;
    }

    static void AlterarNome(string[] nomes, string nome, string nomeNovo)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nome)
            {
                nomes[i] = nomeNovo;
            }
        }

    }
    static void ExibirNomes(string[] nomes)
    {
        foreach (var item in nomes)
        {
            Write($@"{item},
");
        }
    }
    static ref string LocalizarNome(string[] nomes, string nome)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nome)
            {
                return ref nomes[i];
            }
        }
        throw new Exception("Nome não encontrado");
    }
    static void Main()
    {
        var nomes = new string[] { "Drigo", "Xico", "Trigo", "Docinho", "Digo" };
        ExibirNomes(nomes);
        WriteLine(@"Digite o nome a ser substituido:");
        var nome = ReadLine();
        WriteLine(@"Digite o novo nome:");
        var novoNome = ReadLine();

        ref var nomeAchado = ref LocalizarNome(nomes, nome);
        if (!string.IsNullOrWhiteSpace(nomeAchado))
        {
            nomeAchado = novoNome;
            ExibirNomes(nomes);
        }
        else
        {
            WriteLine("Nome não encontrado");
        }
    }
}

