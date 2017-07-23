using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cliente
    {
        public long cli_id { get; set; }
        public string cli_nome { get; set; }
        public string cli_endereco { get; set; }
        public string cli_telefone { get; set; }
        public string cli_email { get; set; }
        public string cli_senha { get; set; }
    }
}
