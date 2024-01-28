# DIO - Trilha .NET - Programação orientada a objetos (POO)
O desafio consiste em utilizar os conceitos de Programação orientada a objetos (POO) para modelar um sistema que trabalha com celulares, de forma a disponibilizar diferentes maneiras de marcas e modelos terem seu próprio comportamento.

Este projeto foi desenvolvido como avaliação parcial do Bootcamp Decola Tech Avanade 2024, em parceria com a DIO, com o objetivo de praticar os conteúdos ensinados no Bootcamp.

### 🖥️ Tecnologias Utilizadas

- C#
- .NET

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução

A partir do código base fornecido implementou-se a classe abstrata Smartphone, suas propriedades Modelo, IMEI e Memoria foram definidas como private (garantindo o encapsulamento), além de adicionar estas mesmas propriedades como parâmetros no construtor da classe. Implementou-se também as classes filhas Nokia e Iphone que herdam da classe base Smartphone.

O método InstalarAplicativo foi sobrescrito, utilizando os conceitos de polimorfismo, para garantir o comportamento único de cada marca (representada por Nokia e Iphone nesse código), na aplicação principal Program.cs foram instanciados objetos tanto da classe Iphone como da classe Nokia para verificar os diferentes comportamentos do método InstalarAplicativo. Os métodos Ligar e ReceberLigacao têm o mesmo comportamento em ambas as classes, pois são herdados diretamente de Smartphone.

## Instruções de Uso

1. Clonar o repositório atual para sua máquina local

   `git clone https://github.com/matheushardman/trilha-net-poo-desafio.git`

2. Caso não tenha o .NET 6.0 ou superior instalado, certifique-se em instalar, você pode encontrá-lo em:

   `https://dotnet.microsoft.com/pt-br/download/dotnet/6.0`

3. Abra o terminal no seu projeto clonado utilizando sua IDE ou editor de código-fonte de preferência

4. Execute o projeto com o seguinte comando

   `dotnet run`