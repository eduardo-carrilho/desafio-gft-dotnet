using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_gft_dotnet.Desafio_2
{
    public class Veiculo
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }


        public void ExibirInfo()
        {
            Console.WriteLine($"Veiculo: {this.marca} {this.modelo}, {this.ano}");
        }
        
    }
}