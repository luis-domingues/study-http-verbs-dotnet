## `HTTP Verbs in .NET` (:brazil:)

> 🚀 Explorando os verbos HTTP e suas funcionalidades no desenvolvimento de APIs em .NET. Os verbos HTTP são fundamentais para a comunicação com o servidor, e cada um tem uma função específica dentro do ciclo CRUD.

### 📚 O que aprendi

Você pode encontrar os exemplos de código e implementação dos verbos HTTP na pasta [`src`](src/).

- [x] Verbos HTTP
    - O que são?
    - Como funcionam no contexto de APIs?
    - Relação com o CRUD.
- [x] POST - Criar dados (CREATE)
    - Enviar novas informações para a API.
- [x] GET - Ler dados (READ)
    - Retornar informações existentes.
- [x] PUT - Atualizar dados (UPDATE)
    - Substituir todas as informações de um recurso.
- [x] PATCH - Modificar dados (MODIFY)
    - Atualizar apenas campos específicos de um recurso.
- [x] DELETE - Remover dados (DELETE)
    - Excluir um recurso existente do banco de dados.
- [x] Tratamento de erros e códigos de status HTTP.
    - Como lidar com respostas como 200 (OK), 404 (Not Found), 409 (Conflict), entre outros.

### 🌐 Detalhes dos verbos HTTP

| HTTP Verb | CRUD    | Descrição                                                                                  |
|-----------|---------|--------------------------------------------------------------------------------------------|
| POST      | CREATE  | Envia novas informações para a API.                                                         |
| GET       | READ    | Retorna uma informação existente.                                                           |
| PUT       | UPDATE  | Substitui todas as informações de um recurso.                                               |
| PATCH     | MODIFY  | Atualiza partes de um recurso sem necessidade de enviar todas as informações.               |
| DELETE    | DELETE  | Remove uma informação existente do banco de dados.                                          |

### Retornos de status HTTP comuns

| HTTP Verb | Status | Descrição                                                                                       |
|-----------|--------|-------------------------------------------------------------------------------------------------|
| POST      | 404    | Recurso não encontrado.                                                                          |
| POST      | 409    | Conflito, se o recurso já existe.                                                                |
| GET       | 200    | Sucesso, recurso encontrado.                                                                     |
| GET       | 404    | Recurso não encontrado ou ID inválido.                                                           |
| PUT       | 200    | Sucesso na atualização completa.                                                                 |
| PUT       | 204    | Sem conteúdo, quando o recurso é atualizado, mas sem retorno de dados.                           |
| PUT       | 404    | Recurso não encontrado ou ID inválido.                                                           |
| PATCH     | 200    | Sucesso na atualização parcial.                                                                  |
| PATCH     | 204    | Sem conteúdo, quando o recurso é atualizado, mas sem retorno de dados.                           |
| DELETE    | 200    | Sucesso ao remover o recurso.                                                                    |
| DELETE    | 404    | Recurso não encontrado ou ID inválido.                                                           |

### ⬇ Como rodar o projeto

1. Clone o repositório.
2. Abra o projeto em sua IDE preferida.
3. Execute a API e teste os verbos HTTP utilizando ferramentas como Postman ou curl.

```bash
# Clonando o repositório
git clone https://github.com/luis-domingues/study-http-verbs-dotnet.git
```

### 🔗 Recursos
Lista de conteúdos que consumi para aprender sobre verbos HTTP e APIs em .NET:

* [Microsoft Docs - Create web APIs with ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-5.0)
* [MDN Web Docs - Códigos de status de respostas HTTP](https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status)

## 📝 Licença
Este projeto está sob licença MIT - Veja a [LICENÇA](https://github.com/luis-domingues/study-http-verbs-dotnet/blob/main/LICENSE) para mais informações.