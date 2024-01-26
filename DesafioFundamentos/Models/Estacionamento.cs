namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private int valorPadraoPlaca = 7;
        private List<string> veiculos = new List<string>(); 

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public List<string> pegarListaVeiculo()
        {
            return veiculos;
        }

        public void AdicionarVeiculo(string placa) {

            if (VerificarCaracteres(placa)) {

                if (VerificarPlacasRepetidas(placa)) {
                    
                    Console.WriteLine($"O veículo de placa {placa.ToUpper()} já consta em nosso sistema.");

                } else {

                    veiculos.Add(placa);
                    Console.WriteLine($"O veículo de placa {placa.ToUpper()} foi estacionado com sucesso!");
                    
                }
            } else {
                Console.WriteLine("Placa digitada inválida, tente novamente.");
            }

        }

        public bool VerificarPlacasRepetidas(string placa)
        {
            foreach (string itemListaVeiculos in veiculos)
            {
                if (placa == itemListaVeiculos)
                    return true;
            }
            return false;
        }

        public bool VerificarCaracteres(string placa)
        {
            return placa.Length == valorPadraoPlaca ? true : false;
        }


         public void RemoverVeiculo(string placa, decimal horasEstacionadas)
        {
            
            if (veiculos.Any(veiculoPlaca => veiculoPlaca.ToUpper() == placa.ToUpper())) {

                decimal valorTotal = (horasEstacionadas * precoPorHora) + precoInicial;
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal}");

            }
            else {

                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");

            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any()) {

                Console.WriteLine("Os veículos estacionados são:");
                
                foreach(string veiculoPlaca in veiculos) {

                    Console.WriteLine(veiculoPlaca.ToUpper());
                }

            } else {

                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}