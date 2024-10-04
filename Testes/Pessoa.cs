using System.Security.Cryptography.X509Certificates;

namespace Testes
{
    public class Pessoa
    {
        private string nome;
        private int idade;
        private string telefone;
        private string email;
        private string endereco;

        public void SetNome()
        {
            Console.Clear();
            Console.WriteLine("Insira o nome do cliente: ");
            string entrada = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entrada))
            {
                this.nome = entrada;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Insira um nome válido.");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                SetNome();
            }
        }
        public string getNome()
        {
            return this.nome;
        }

        public void setIdade()
        {
            Console.Clear();
            Console.WriteLine("Insira a idade do cliente: ");
            string num = Console.ReadLine();
            if (int.TryParse(num, out int idade) && idade >= 0)
            {
                this.idade = idade;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Idade inválida, insira uma idade válida.");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                setIdade();
            }
        }

        public int getIdade()
        {
            return this.idade;
        }

        public void SetTelefone()
        {
            Console.Clear();
            Console.WriteLine("Insira o contato (telefone) do cliente: ");
            string entrada = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entrada))
            {
                this.telefone = entrada;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dados inválidos, insira um número de telefone!");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                SetTelefone();
            }
        }
        public string GetTelefone()
        {
            return this.telefone;
        }

        public void SetEmail()
        {
            Console.Clear();
            Console.WriteLine("Insira o e-mail do cliente: ");
            string entrada = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entrada))
            {
                this.email = entrada;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Entrada inválida, insira um e-mail!");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                SetEmail();
            }
        }
        public string GetEmail()
        {
            return this.email;
        }

        public void SetEndereco()
        {
            Console.Clear();
            Console.WriteLine("Insira o endereço do cliente: ");
            string entrada = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entrada))
            {
                this.endereco = entrada;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dados inválidos, insira um endereço!");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                SetEndereco();
            }
        }
        public string GetEndereco()
        {
            return this.endereco;
        }
    }
}