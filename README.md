# 🚀 TaskFlow API

O **TaskFlow** é uma API robusta de gerenciamento de tarefas desenvolvida em **.NET 8**. O projeto foi concebido para demonstrar a aplicação de padrões de **Clean Architecture**, validações resilientes com **FluentValidation** e um sistema inteligente de tratamento de exceções customizadas.

---

## 🏗️ Arquitetura do Sistema

O projeto segue os princípios da arquitetura em camadas, garantindo baixo acoplamento e alta testabilidade:

* **TaskFlow.API**: Camada de interface (Controllers) e configuração de injeção de dependência.
* **TaskFlow.Application**: Camada de lógica de negócio (Use Cases) e regras de validação.
* **TaskFlow.Domain**: O núcleo da aplicação. Contém as entidades de negócio e enums.
* **TaskFlow.Communication**: Contratos de entrada e saída (Requests/Responses).



---

## 🛠️ Principais Recursos e Diferenciais

### 🛡️ Fail-Fast Validation
Utilizamos o **FluentValidation** para validar os dados antes mesmo de chegarem à regra de negócio.
* **Regras Encadeadas**: Validações de obrigatoriedade, tamanho e tipos.
* **Cascade Mode**: Configuração `.Cascade(CascadeMode.Stop)` para otimizar a performance, interrompendo a validação no primeiro erro encontrado por campo.

### 🚦 Tratamento Global de Erros
Implementamos uma estrutura de exceções customizadas que padroniza as respostas da API:
* **TaskFlowException**: Classe base abstrata para todos os erros de negócio.
* **ErrorOnValidationException (400)**: Captura e retorna uma lista de erros de validação.
* **NotFoundException (404)**: Retorna uma mensagem clara quando um recurso (ID) não existe.

### 🌐 Roteamento Inteligente
Endpoints configurados com parâmetros de rota explícitos para garantir que a identificação dos recursos seja precisa e segura.

---

## 🚀 Funcionalidades (CRUD)

- [x] **Create**: Cadastro de tarefas com prioridade e status.
- [x] **Read (All)**: Listagem simplificada de todas as tarefas.
- [x] **Read (ID)**: Detalhamento de uma tarefa específica por GUID.
- [x] **Update**: Atualização completa de dados com validação de existência.
- [x] **Delete**: Remoção de tarefas do sistema.

---

## 💻 Como Rodar o Projeto

1.  **Clone o repositório**:
    ```bash
    git clone [https://github.com/seu-usuario/taskflow-api.git](https://github.com/seu-usuario/taskflow-api.git)
    ```
2.  **Restaure as dependências**:
    ```bash
    dotnet restore
    ```
3.  **Execute a aplicação**:
    ```bash
    dotnet run --project TaskFlow.API
    ```
4.  **Acesse o Swagger**:
    Abra `http://localhost:5000/swagger` (ou a porta indicada no console) para testar os endpoints.

---

*Desenvolvido como parte dos estudos em .NET.*
