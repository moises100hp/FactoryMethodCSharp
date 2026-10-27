using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creator
{
    internal class ConcreteTelaSmarttvCreator : TelaCreator
    {
        public override Tela CriaTela()
        {
            return new TelaSmarttv();
        }
    }
}
