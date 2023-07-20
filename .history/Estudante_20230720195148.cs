using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Programa
{
    public class Estudande
    {

        public string Nome{get; set;}
        public string Email{get; set;}

        public Estudante(string nome, string email){
            Nome = nome;
            Email = email;  
        }
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}