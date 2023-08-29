# InvestmentCalculator
Este projeto consiste em uma aplicação web que permite calcular o valor bruto e líquido de um investimento com base nas informações fornecidas pelo usuário.

## Funcionalidades

- Insira o valor monetário inicial e o prazo em meses.
- Calcule o valor bruto e líquido do investimento com base nas taxas fornecidas.
- Visualize os resultados de forma clara e organizada.

## Tecnologias Utilizadas
### Backend:
  - .NET6
  - Microsoft Visual Studio Community 2022 (64-bit) - Current
  - Version 17.7.0
### Frontend: 
 - Angular CLI: 16.2.0
 - Node: 18.17.1
 - Package Manager: npm 8.19.3

## Como Executar

 **Clone o Repositório:**
   ```bash
   git clone https://github.com/caioragazzini/InvestmentCalculator.git
   ```

#### 🎲 Rodando o BackEnd 
 - O servidor do BackEnd tem que estar configurado o Localhost - acesse <https://localhost:7217/>
 - O BackEnd pode ser testado através do Swagger acessando https://localhost:7217/swagger/index.html
  ```bash
   $ cd seu-repositorio 
   - Certifique-se de ter o .NET 6 SDK instalado.
   - Navegue até a pasta InvestmentCalculatorBackend:  
   $ cd InvestmentCalculatorBackend
   - Inicie o servidor:
   $ dotnet run
  ```
#### 🎲 Rodando o FrontEnd (Angular):
 ```bash
- Certifique-se de ter o Angular CLI instalado: 
$ npm install -g @angular/cli
- Navegue até a pasta InvestmentCalculatorFrontend:
$ cd InvestmentCalculatorFrontend
- Instale as dependências:
$ npm install
- Inicie o servidor:
$ ng serve
 ```
- Acesse a aplicação no navegador: http://localhost:4200

Autor
Caio Ragazzini
(15) 99149-7506


