using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MCD
{
    public class TDD_MCD
    {
        public static int MaximoComunDivisor(int nro1, int nro2)
        {
            while (nro2 != 0)
            {
                int temp = nro2;
                nro2 = nro1 % nro2;
                nro1 = temp;
            }
            return nro1;
        }
    }
}
