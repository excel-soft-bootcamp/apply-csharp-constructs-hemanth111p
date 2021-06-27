using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tatacar
{
    class Program
    {
        static void Main(string[] args)
        {
            DiCorEngine dicor = new DiCorEngine();
            Tatacar oldcar = new Tatacar(dicor);
            oldcar.Drive();
            oldcar.Halt();
            Tatacar _nexon = new Tatacar(new VeriCorEngine());
            _nexon.Drive();
            _nexon.Halt();
            Tatacar _hexa = new Tatacar(new MultiJetEngine());
            _hexa.Drive();
            _hexa.Halt();
            Tatacar _neon = new Tatacar(new RevorTron());
            _neon.Drive();
            _neon.Halt();
        }
    }
}
