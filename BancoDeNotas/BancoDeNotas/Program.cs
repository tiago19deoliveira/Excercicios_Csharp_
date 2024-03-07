using System;
using System.Collections.Generic;


namespace BancoDeNotas;
    class Program
    {
    static void Main()
    {
        Dictionary<string, int> NotasDoTiago = new Dictionary<string, int>();

        NotasDoTiago ["Bando De dados"] = 6;
        NotasDoTiago["Inovação e Gestão"] = 8;
        NotasDoTiago["Programação Web"] = 6;

        NotasDoTiago["Inovaçao e empreendedorismo"] = 6;
        NotasDoTiago["Rede de computadores"] = 6;

        int media = NotasDoTiago.Count;

        Console.WriteLine(media);

            // Aguarda a entrada do usuário antes de encerrar
            Console.ReadLine();
        }
    }

