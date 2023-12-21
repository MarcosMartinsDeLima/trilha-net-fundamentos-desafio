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
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar, sem traços:");
            var veiculo = Console.ReadLine();

            //validação se possui 7 caracteres
            if(veiculo.Length != 7){
                throw new Exception("A placa deve conter Sete caracteres");
            }

            veiculos.Add(veiculo);
            // exibindo menssagem de sucesso
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Veiculo cadastrado com sucesso!");
            Console.ResetColor();
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = 0;
                decimal valorTotal = 0;
                var _horas = int.TryParse(Console.ReadLine(), out int result);
                //validação se veio horas em numeros
                if(_horas == false){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("As horas devem ser numeros inteiros!");
                    Console.ResetColor();
                    RemoverVeiculo();
                }
                horas = result;

                valorTotal = precoInicial + precoPorHora + horas;

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

                veiculos.Remove(placa);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                Console.ResetColor();
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach(var veiculo in veiculos){
                    Console.WriteLine(veiculo);
                }
            }
            else
            {   
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
