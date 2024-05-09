using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PROYECTO_MCD
namespace UnitTestProject1
{
    public class FileName
    {
        Calculadora calculadora = new Calculadora();
        int nro1 = 300;
        int nro2 = 33800;
        int esperado = 20;

        // Act
        int actual = calculadora.CalcularMCD(nro1, nro2);

        // Assert
        Assert.AreEqual(esperado, actual);
    }
}
