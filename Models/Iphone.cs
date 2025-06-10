using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone // Iphone herda de Smartphone
    {
        // Construtor da classe Iphone
        // Ele chama o construtor da classe base (Smartphone) usando 'base()'
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Não há propriedades específicas para Iphone além das do Smartphone neste exemplo,
            // mas você poderia adicionar se necessário.
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        // A palavra-chave 'override' é usada para fornecer a implementação específica
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no iPhone modelo {Modelo}...");
        }
    }
}
