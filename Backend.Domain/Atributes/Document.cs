using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain.Atributes
{
    [System.AttributeUsage(System.AttributeTargets.Class |
        System.AttributeTargets.Struct)]
    public class Document : System.Attribute
    {

        public string Value { get; set; }

        public Document(string value)
        {
            this.Value = value;
        }

        public Document() { }

    }
}
