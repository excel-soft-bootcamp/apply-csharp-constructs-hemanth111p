using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tatacar
{
    class Tatacar
    {
       
             Iengine _engine;
        public Tatacar(Iengine engine)
        {
            this._engine = engine;
        }
        public void Drive()
        {

            _engine.start();
        }

        public void Halt()
        {

            _engine.stop();
        }
    }
}

