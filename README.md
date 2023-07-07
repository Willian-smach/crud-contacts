<h1>Crud de contatos .NET Core 6</h1>

## Sobre o projeto

Esse projeto tem como foco o estudo do .Net core na versão 6 e o consumo de apis utilizando o mesmo.

## **Simulação de API**

Foi utilizado o Json-Server para simular a API que é consumida nesse projeto.

### Instalação do Json-Server:

```
npm install -g json-server
```

### Criação da base

Após instalar, crie o arquivo db.json em qualquer lugar da máquina. Em seguida pode colar o código abaixo que é utilizado no projeto e já contém 1 contato salvo.

```
{
  "contacts": [
​    {
​      "id": 1,
​      "name": "Willian Silva",
​      "email": "willian.silva@teste.com.br",
​      "phone": "51 0000-0000"
​    },
​	]
}
```

<h3>Rodando o arquivo</h3>

Entre na pasta onde você salvou o arquivo db.json e rode o seguinte comando no terminal:

```
json-server --watch db.json
```

Por padrão o Json-Server roda na porta 3000, você pode adicionar a flag --port para alterar a porta em que ele vai rodar. 

```
json-server --watch db.json --port 3001
```