﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarro.Servicos
{
    public class ConfiguracoesEmail
    {
        public string Endereco { get; set; }

        public int Porta { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Destinatario { get; set; }
    }
}
