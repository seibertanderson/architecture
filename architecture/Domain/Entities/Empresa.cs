using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Empresa
    {
        public long emp_id { get; set; }
        public string emp_endereco { get; set; }
        public string emp_telefone { get; set; }
        public string emp_email { get; set; }
        public string emp_senha { get; set; }

        //ONE-TO-MANY RELASHIONSHIP
        //public virtual ICollection<Produto> produtos { get; set; }
    }
}
