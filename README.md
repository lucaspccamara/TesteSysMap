# TesteSysMap

Projeto para desenvolver uma API RESTful que realiza operações de soma e divisão, onde somar e dividir são tarefas complexas que demandam uma biblioteca específica.

## Documentação da API
https://documenter.getpostman.com/view/11811277/TVzUDwZo

## Usando a API

Faça o download do repositório do projeto;
Carregue o projeto no Visual Studio e inicie a aplicação;
Faça a requisicão passando os parâmetros esperados conforme mostrado nos recursos da API na seção abaixo, respeitando o endereço das rotas como o exemplo a seguir https://localhost:XXXXX/sum


Recursos disponíveis para acesso via API:
* [**Somar Vetor de Inteiros**](#reference/recursos/soma)
* [**Calcular Média Aritmética de um Vetor de Inteiros**](#reference/recursos/media)


# Somar Vetor de Inteiros [/sum] [POST]

+ Request (application/json)

    + Body

   		    {
                "entry":[2,2,4,4]
		    }


+ Response 200 (application/json)

    + Body

            {
                "sum": 12
            }


# Calcular Média Aritmética de um Vetor de Inteiros [/avarage] [POST]

+ Request (application/json)

    + Body

   		    {
                "entry":[2,2,4,4]
		    }


+ Response 200 (application/json)

    + Body

            {
                "avarage": 3
            }




## Rodando Testes Unitários

Dentro do Visual Studio com a solução 'Api_SysMap' aberta é possível localizar o projeto 'UnitTestApiSysMap', nele estão todos os métodos de teste para as classes Number e Numbers.

Para executar os teste basta precionar "Ctrl + R + A".

## Construído com

* Microsoft Visual Studio 2019
