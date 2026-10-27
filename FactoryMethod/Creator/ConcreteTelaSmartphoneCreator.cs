using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    internal class ConcreteTelaSmartphoneCreator : TelaCreator
    {
        public override Tela CriaTela()
        {
            return new TelaSmartphone();
        }
    }
}
