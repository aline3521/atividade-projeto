

using System;
class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();
        Console.Write("Digite o nome: ");
        pessoa.Nome = Console.ReadLine();
        Console.Write("Digite a idade: "); int.TryParse(Console.ReadLine(), out int idade);
        pessoa.Idade = idade;
        Console.Write("Digite o telefone: "); pessoa.Telefone = Console.ReadLine();
        Console.Write("Digite o endereço: ");
        pessoa.Endereco = Console.ReadLine();
        Console.Write("Digite o e-mail: "); pessoa.Email = Console.ReadLine();
        pessoa.ExibirInformacoes();
    }
}

class Pessoa
{
    private string nome; private int idade;
    private string telefone; private string endereco;
    private string email;
    public string Nome
    {
        get { return nome; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nome = value;
            else
                Console.WriteLine("Nome inválido!");
        }
    }
    public int Idade
    {
        get { return idade; }
        set
        {
            if (value >= 0)
                idade = value;
            else
                Console.WriteLine("Idade inválida!");
        }
    }
    public string Telefone
    {
        get { return telefone; }
        set { telefone = value; }
    }
    public string Endereco
    {
        get { return endereco; }
        set { endereco = value; }
    }

    public string Email
    {
        get { return email; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                email = value;
            else
                Console.WriteLine("E-mail inválido!");
        }
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine("\nInformações:"); Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Telefone: {Telefone}"); Console.WriteLine($"Endereço: {Endereco}");
        Console.WriteLine($"E-mail: {Email}");
    }
}