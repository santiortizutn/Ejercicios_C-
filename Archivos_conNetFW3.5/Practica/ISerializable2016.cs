using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica
{
    public interface ISerializable2016
    {
        bool serializar();

        bool serializarGenerico(ISerializable2016 ise);
    }
}
