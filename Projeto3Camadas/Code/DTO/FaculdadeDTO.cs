using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.DTO
{
    class FaculdadeDTO
    {
        private int _id;
        private string _nome;
        private string _nota;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Nota { get => _nota; set => _nota = value; }
    }
}
