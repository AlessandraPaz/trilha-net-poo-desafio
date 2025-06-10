using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public abstract class Smartphone // Classe base abstrata
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Modelo { get; set; } // Propriedade para o modelo do smartphone
        public string IMEI { get; set; }   // Propriedade para o IMEI do smartphone
        public int Memoria { get; set; }   // Propriedade para a memória em GB

        // Construtor da classe Smartphone
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero; // Atribui o número de telefone
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo; // Atribui o modelo
            IMEI = imei;     // Atribui o IMEI
            Memoria = memoria; // Atribui a memória
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato que as classes filhas DEVERÃO implementar
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
