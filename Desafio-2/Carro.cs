using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_gft_dotnet.Desafio_2
{
    public class Carro : Veiculo
    {
        public int portas { get; set; }

        public Carro(string marca, string modelo, int ano, int portas)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
            this.portas = portas;
        }

        public new void ExibirInfo()
        {
            Console.WriteLine($"Carro: {this.marca} {this.modelo}, {this.ano}, {this.portas} portas");
        }

    }
}