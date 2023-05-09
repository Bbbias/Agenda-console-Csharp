List<Contato> listaDeContatos = new List<Contato>();
var escolha = "0";

while(escolha != "3"){

        Console.WriteLine("\nBem vindo a agenda! \nEscolha uma das opções: \n1 - Cadastrar \n2 - Listar \n3 - Sair");
        escolha = Console.ReadLine();

            if(escolha == "1"){
                Console.WriteLine("Digite o nome do contato");
                var nomeAdicionar = Console.ReadLine();
                Console.WriteLine("Digite o numero do contato");
                var telefoneAdicionar = Console.ReadLine();

                Contato contatoAdicionar = new Contato();
                contatoAdicionar.Nome = nomeAdicionar;
                contatoAdicionar.Telefone = telefoneAdicionar;

                listaDeContatos.Add(contatoAdicionar);

            }

            if(escolha == "2"){

                Console.WriteLine("\nLista de contatos:");
                
                foreach(Contato contato in listaDeContatos){
                Console.WriteLine(contato.Nome);
                Console.WriteLine(contato.Telefone);
                }
             
             }   
             if(escolha != "1" && escolha != "2" && escolha != "3"){
                Console.WriteLine("Opção inválida!");
            } 
   
}

    public class Contato
    {
        public string Nome { get; set; } 
        public string Telefone { get; set; } 
        public Contato()
        { }

        public Contato( string nome,string telefone)
        {
           Nome = nome;
           Telefone = telefone;
        }
    }









    

