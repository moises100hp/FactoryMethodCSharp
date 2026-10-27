using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    internal class ConcreteTelaSmartwhatchCreator : TelaCreator
    {
        public override Tela CriaTela()
        {
            return new TelaSmartwatch();
        }
    }
}
