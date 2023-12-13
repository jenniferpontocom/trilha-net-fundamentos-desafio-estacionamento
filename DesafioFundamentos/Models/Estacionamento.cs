namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementada funcionalidade que solicita ao usuario a placa do veiculo e salva esse dado em nossa lista;
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Implementada funcionalidade que solicita ao usuario a placa do veiculo para posteriormente remove-la;
            
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Implementada funcionalidade que solicita ao usuario a quantidade de horas que o carro ficou estacionado;

                decimal horasEstacionadas = Convert.ToDecimal(Console.ReadLine());

                // Implementado calculo de gastos do estacionamento;  

                int horas = 0;
                decimal valorTotal = (horasEstacionadas * precoPorHora) + precoInicial;



                // Implementada funcionalidade que remove a placa de nossa lista;
                veiculos.Remove(placa);
                

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Implemento laço que exibe todas as placas cadastradas em nosso sistema;
                
                foreach(string listaPlacas in veiculos)
                {
                    Console.WriteLine(listaPlacas);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}