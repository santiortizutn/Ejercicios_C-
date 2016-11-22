using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public interface IAfip
    {
        float Impuesto
        {
            set;
            get;
        }
        

        float RetornarImpuesto();


        
    }
}
