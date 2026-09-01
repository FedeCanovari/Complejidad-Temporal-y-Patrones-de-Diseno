using System;
using System.Collections.Generic;
using System.Text;

namespace Practica01.Interfaces


{
    public interface Comparable
    {
        bool sosIgual(Comparable comparable);
        bool sosMenor(Comparable comparable);
        bool sosMayor(Comparable comparable);
    }
}
