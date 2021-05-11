using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace view.Models
{
    public class Message
    {
        public string Emetteur { get; set; }
        public string Contenu { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{Emetteur} : {Contenu} \n {Date}";
        }
    }
}
