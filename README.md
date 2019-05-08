# Calculadora

Api com dois endpoints, um que recebe um valor inicial X e uma quantidade Y em meses e calcula o valor acumulado com juros de 1% ao mês
e o outro que informa o endereço onde se encontra o código do projeto no repositório git. Testes de integração e testes unitários também acompanham a solução, foi utilizado o docker e swagger
na construção da api. 

## Iniciando

Abra a solution "ApiCalculadoraSoftplan", nela se encontram 3 projetos:
* ApiCalculadoraSoftplan - é a api em si, ao rodar o Visual Studio com ela será aberto uma página com os endpoints CalculaJuros e showmethecode.
* TesteIntegracaoCalculadoraSoftplan - Neste projeto se encontram os testes de integração, você poderá ver e executar todos eles na aba TestExplorer do Visual Studio.
* TesteUnitarioCalculadoraSoftplan - Neste projeto se encontram os testes unitários você poderá ver e executar todos eles na aba TestExplorer do Visual Studio.

### Pré-Requisitos

Você deverá ter uma IDE, de preferência o Visual Studio e o software docker para poder abrir, rodar e debugar a api, os testes unitários e de integração.  

## Rodando a api

Abra a solution "ApiCalculadoraSoftplan" no Visual Studio, navegue até o projeto ApiCalculadoraSoftplan e aperte f5. Será aberto o navegador com a lista dos endpoints,
suas variáveis, tudo documentado com swagger.
### Os endpoints

* calculajuros
Faça uma chamada get ou use o browser com o seguinte endereço url:
(Endereço Do Site)/calculajuros?valorinicial=100&meses=5
onde valorinicial é o valor inicial e meses é a quantidade de meses a ser aplicado o juros, a api retornará o valor inicial acrescido dos
juros compostos baseado na quantidade de meses informada, nesse caso 5.

* showmethecode
Faça uma chamada get ou use o browser com o seguinte endereço url:
(Endereço Do Site)/showmethecode
Retornará o endereço do repositório onde o código se encontra.

## Rodando os testes unitários

Abra a solution "ApiCalculadoraSoftplan" no Visual Studio, navegue até o projeto TesteUnitarioCalculadoraSoftplan, vá até a pasta Testes, clique na classe do teste que
deseja executar, clique em qualquer parte do código com o botão direito do mouse depois em "Run Test(s)".

## Rodando os testes de integração

Abra a solution "ApiCalculadoraSoftplan" no Visual Studio, navegue até o projeto TesteIntegracaoCalculadoraSoftplan, vá até a pasta Testes, clique na classe do teste que
deseja executar, clique em qualquer parte do código com o botão direito do mouse depois em "Run Test(s)".

## Colaboradores
Jader Paiva Martins