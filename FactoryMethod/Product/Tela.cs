using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    public abstract class Tela
    {
        protected string BackgroundColor { get; }
        private readonly string MessageText;

        protected Tela(string backgroundColor, string messageText)
        {
            BackgroundColor = backgroundColor;
            MessageText = messageText;
        }

        public string GetMessageText()
        {
            return MessageText;
        }
    }
}
