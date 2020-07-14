using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject
{
    public class DTO
    {
        public string Text { get; set; }
        public string Number { get; set; }

        public DTO(string text, string number)
        {
            Text = text;
            Number = number;
        }
    }
}
