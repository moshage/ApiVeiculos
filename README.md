# 🚗 API de Veículos – .NET 8

API REST desenvolvida em **ASP.NET Core (.NET 8)** para gerenciamento de veículos, aplicando boas práticas de arquitetura, separação de responsabilidades e padrões modernos de desenvolvimento.

---

## ▶️ Como executar o projeto

### 🔧 Pré-requisitos
- .NET SDK 8.0
- Visual Studio 2022+ ou VS Code (opcional)

  ### ▶️ Executar via terminal

Na pasta do projeto **WebApi**, execute:

```bash
dotnet restore
dotnet run

A aplicação será iniciada em:

https://localhost:7142/

O Swagger está configurado para abrir diretamente na raiz da aplicação.

Endpoints disponíveis

* POST	/api/veiculos	Cadastrar veículo
* PUT	/api/veiculos	Atualizar veículo
* GET	/api/veiculos/{id}	Consultar veículo por Id
* GET	/api/veiculos	Listar veículos
* DELETE	/api/veiculos/{id}	Remover veículo

Exemplos de uso (JSON)
➕ Cadastrar veículo

POST /api/veiculos

{
  "descricao": "Carro popular",
  "marca": 1,
  "modelo": "Gol",
  "opcionais": "Ar condicionado, Direção hidráulica",
  "valor": 45000
}
---
✏️ Atualizar veículo

PUT /api/veiculos

{
  "id": "3c9e2c4e-8c3f-4d0e-a8c1-6a7c7b3d12aa",
  "descricao": "Carro atualizado",
  "marca": 1,
  "modelo": "Gol G6",
  "opcionais": "Ar condicionado, ABS",
  "valor": 48000
}
---
🔍Consultar veículo por Id

GET /api/veiculos/{id}

---

📋 Listar veículos

GET /api/veiculos

[
  {
    "id": "3c9e2c4e-8c3f-4d0e-a8c1-6a7c7b3d12aa",
    "descricao": "Carro popular",
    "marca": "Volkswagen",
    "modelo": "Gol",
    "valor": 45000
  }
]
---
❌ Remover veículo

DELETE /api/veiculos/{id}
