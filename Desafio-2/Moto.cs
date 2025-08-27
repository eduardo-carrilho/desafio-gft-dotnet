using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_gft_dotnet.Desafio_2
{
    public class Moto : Veiculo
    {
        public int cilindradas { get; set; }

        public Moto(string marca, string modelo, int ano, int cilindradas)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
            this.cilindradas = cilindradas;
        }

        public new void ExibirInfo()
        {
            Console.WriteLine($"Carro: {this.marca} {this.modelo}, {this.ano}, {this.cilindradas} cc");
        }      
    }
}