using System;
using System.Collections.Generic;
using System.Text;
using Mimica.Model;


namespace Mimica.Armazenamento
{
    public class Armazenamento
    {
        public static Jogo Jogo { get; set; }
        public static short RodadaAtual { get; set; }

        public static string[][] Palavras =
        {
            // Fácil
            new string[] {"Frio", "Bebê","Mímico","Escova de dentes", "Lápis", "Livro","Astronauta","Amor", "Ódio"," Cego","Cadeira","Sacola","Professor","Médico","Calculadora","Artista","Vitória","Pescador","Internet"," Basquete"
},

           // Media
           new string[] {"Frio-2",  "Bebê-2", "Mímico-2", "Escova de dentes-2", " Lápis-2",  "Livro-2" , "Astronauta-2", "Amor-2" , "Ódio-2", " Cego-2", " Cadeira-2",  "Sacola-2", "Professor-2",  "Médico-2", " Calculadora-2", "Artista-2", "Vitória-2"," Pescador-2", "Internet-2"," Basquete-2"
},

           // Difícil
           new string[] {"Frio-3",  "Bebê-3", "Mímico-3", "Escova de dentes-3", " Lápis-3",  "Livro-3" , "Astronauta-3", "Amor-3" , "Ódio-3", " Cego-3", " Cadeira-3",  "Sacola-3", "Professor-3",  "Médico-3", " Calculadora-3", "Artista-3", "Vitória-3"," Pescador-3", "Internet-3"," Basquete-3"
}
        };


    }
}
