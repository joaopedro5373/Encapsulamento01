using Testes;
public class Program
{
    static void Main()
    {
        Pessoa p = new Pessoa();

        p.SetNome();
        p.setIdade();
        p.SetTelefone();
        p.SetEmail();
        p.SetEndereco();

        Console.Clear();
        Console.WriteLine("---------- Cliente Cadastrado ----------");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Nome: " + p.getNome());
        Console.WriteLine("Idade: " + p.getIdade() + "anos");
        Console.WriteLine("Telefone: " + p.GetTelefone());
        Console.WriteLine("E-mail: " + p.GetEmail());
        Console.WriteLine("Endereço: " + p.GetEndereco());
        Console.WriteLine("----------------------------------------");
        Console.ReadLine();

    }
}