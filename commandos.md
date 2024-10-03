# Fundamentos C#

## Comandos do Terminal

`cd <nome-da-pasta>`

Entrar ou sair de uma pasta

`ls`

Listar os arquivos e pastas de uma pasta

`mkdir <nome-da-pasta>`

Criar uma pasta

`echo <nome-do-arquivo>`

Criar um arquivo

## Comandos Dotnet

> dotnet new

Para criar um projeto

> dotnet clean

Para limpar os arquivos compilados de um projeto

> dotnet run

Para compilar e executar um projeto

> dotnet build

Para compilar um projeto

> dotnet new gitignore

Para filtrar os arquivos

> Console.Write()

Mostra o texto no output. Escreve continuamente na mesma linha 

>Console.WriteLine()

Faz as quebras de linhas no código.

>Console.readline

 Retorna o valor da linha inteira digitado no console(Buffer)

>Buffer

Buffer é uma área de armazenamento temporário de dados,

>> using(var file = new StreamWriter(path)) {file.Write(text);} 

Para salvar um arquivo de texto
