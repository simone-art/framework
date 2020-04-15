using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Framework
{
    public class Carro
    {
        // O key sinaliza que o id é primary key e autoincremente en la base de dados//
        [Key()]
        public int Id { get; set; }

        [ForeignKey("Modelo")]
        public int ModeloId { get; set; }

        public string Nome { get; set;}

        public int AnoDoCarro { get; set; }

    }
}
