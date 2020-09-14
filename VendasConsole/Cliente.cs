using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole
{
    class Cliente
    {
        //Construtor
        public Cliente()
        {
            //Aqui é informado a data e hora do sistema que o objeto foi criado
            CriadoEm = DateTime.Now;
        }

        //Pode ser chamado de atributo, propriedades ou características
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            //"base" é a classe PAI, por isso deve ser alterada 
            return $"Nome: {Nome} | CPF: {Cpf} | Criado em: {CriadoEm}";
        }
    }
}
