# Factory Method em C#

Projeto de estudo que demonstra o padrão de criação **Factory Method** usando diferentes tipos de tela como exemplo.

## Sobre o padrão

Factory Method define um método de criação na classe base criadora e deixa que subclasses decidam qual produto concreto instanciar. Assim, o código que usa o produto pode trabalhar com uma abstração (`Tela`), sem depender diretamente do tipo concreto criado.

Neste projeto, as telas são os produtos e os criadores concretos determinam qual delas será instanciada:

| Papel no padrão | Implementação neste projeto |
| --- | --- |
| Produto abstrato | `Tela` |
| Produtos concretos | `TelaWeb`, `TelaSmartphone`, `TelaSmartwatch` e `TelaSmarttv` |
| Criador abstrato | `TelaCreator`, que declara `CriaTela()` |
| Criadores concretos | `ConcreteTelaWebCreator`, `ConcreteTelaSmartphoneCreator`, `ConcreteTelaSmartwhatchCreator` e `ConcreteTelaSmarttvCreator` |
| Código cliente | `Program.cs`, que escolhe os criadores e utiliza o resultado como `Tela` |

Cada criador concreto sobrescreve `CriaTela()` e retorna uma implementação específica de `Tela`. O cliente recebe o produto pelo tipo abstrato e chama `GetMessageText()`, sem precisar conhecer a implementação interna da tela.

### Fluxo do exemplo

1. `Program.cs` instancia um criador concreto para cada tipo de tela.
2. Cada criador executa `CriaTela()` e instancia seu produto correspondente.
3. O programa guarda os resultados em variáveis do tipo `Tela`.
4. O método `GetMessageText()` fornece a mensagem de cada produto, que é exibida no console.

> Neste exemplo, a escolha do criador ainda é feita diretamente pelo código cliente. O Factory Method delega a criação do produto às subclasses, mas não escolhe automaticamente qual criador usar.

## Executar

Requisitos: [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0).

Na raiz do repositório, execute:

```bash
dotnet run --project FactoryMethod/FactoryMethod.csproj
```

O programa imprime as mensagens das quatro telas no console.

## Estrutura do projeto

```text
FactoryMethod/
├── Creator/
│   ├── TelaCreator.cs
│   └── ConcreteTela*Creator.cs
├── Product/
│   ├── Tela.cs
│   └── Tela*.cs
└── Program.cs
```

As telas concretas também recebem uma cor de fundo no construtor, armazenada pela classe base `Tela`. No estado atual do exemplo, essa propriedade não é exibida nem utilizada pelo programa; a saída demonstra as mensagens de cada tela.
