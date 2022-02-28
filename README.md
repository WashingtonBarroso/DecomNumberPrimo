# DecomNumberPrimo
Esse projeto tem como objetivo criar uma solução que seja capaz de decompor um número em todos os seus divisores e informar os seus numéros primos.
A solução é composto por quatro projetos: 
- Class Library,
- Web API,
- Console application
- UniTest Project 

Os projetos de interação com usuário web api e console app chamam a função que calcula os divisores, que está contido lib (class library). O UniTest Project testa os métodos principais na Lib de decomposição de número. 

# Tecnologias utilizadas: 
- C#
- Asp Net Core 5.0 
- Fluent Validation 
- Swashbuckle Swagger 
- Docker

# Instruções para executar o projeto 
Para executar basta clonar o projeto ou baixar os arquivos, se for executar via Visual Studio (F5 ou CTRL + F5), ou se preferir executar no Visual Code via linha de comando:

```
dotnet restore
```
```
dotnet run
```
Visual Studio: https://localhost:44364/swagger/index.html
Visual Code: http://localhost:5000/swagger/index.html

Também é possível executar o projeto via Docker pelo Visual Studio. O projeto está configurado para executar no endereço http://localhost:54415/swagger/index.html ou https://localhost:54416/swagger/index.html 
