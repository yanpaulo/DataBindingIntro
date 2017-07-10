using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingIntro.Models
{
    public class Livro
    {
        public int Codigo { get; set; } = 999;

        public string Nome { get; set; } = "Sem nome";



        public override string ToString() 
            => $"Cod.: {Codigo}, Livro: {Nome}";
    }
}
