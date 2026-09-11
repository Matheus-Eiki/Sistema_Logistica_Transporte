
# 🚚 Sistema de Logística e Transporte

Projeto desenvolvido em **C#** com o objetivo de representar um sistema básico de gerenciamento de funcionários relacionados ao transporte e logística.

O projeto foi desenvolvido com foco nos principais conceitos de **Programação Orientada a Objetos (POO)**, utilizando classes, atributos, métodos, herança, encapsulamento e polimorfismo.

---

## 🎯 Objetivo

O sistema representa diferentes tipos de profissionais que atuam na área de transporte, permitindo cadastrar suas informações e apresentar detalhes específicos de acordo com sua função.

A estrutura foi desenvolvida de forma que diferentes tipos de funcionários possam compartilhar características comuns e, ao mesmo tempo, possuir comportamentos específicos.

---

## 🧱 Estrutura do Projeto

```text
Sistema_Logistica_Transporte/
│
├── Sistema_Logistica_Transporte/
│   ├── EntregadorMoto.cs
│   ├── FuncionarioTransporte.cs
│   ├── MotoristaCarreta.cs
│   ├── Program.cs
│   └── Sistema_Logistica_Transporte.csproj
│
├── .gitignore
└── Sistema_Logistica_Transporte.slnx
```

---

## 👥 Classes

### `FuncionarioTransporte`

É a classe base do sistema.

Ela possui informações comuns aos funcionários de transporte, como:

* Nome/função do funcionário
* Registro do colaborador

Também possui o método:

```csharp
MostrarDetalhes()
```

que pode ser sobrescrito pelas classes derivadas.

---

### `EntregadorMoto`

Representa um funcionário que trabalha como entregador de moto.

Além das informações herdadas de `FuncionarioTransporte`, possui:

* Placa da moto
* Categoria da CNH

A classe sobrescreve o método `MostrarDetalhes()` para apresentar informações específicas do entregador.

---

### `MotoristaCarreta`

Representa um motorista responsável pela condução de uma carreta.

A classe herda características de `FuncionarioTransporte` e adiciona informações específicas relacionadas à função.

---

## 🧠 Conceitos de POO utilizados

### 🔹 Encapsulamento

Os atributos das classes são mantidos privados e acessados através de propriedades públicas.

Exemplo:

```csharp
private string placa;

public string Placa
{
    get { return placa; }
    set { placa = value; }
}
```

---

### 🔹 Herança

As classes específicas de funcionários herdam características da classe `FuncionarioTransporte`.

Exemplo:

```csharp
class EntregadorMoto : FuncionarioTransporte
```

Isso permite reutilizar atributos e métodos da classe base.

---

### 🔹 Polimorfismo

O método `MostrarDetalhes()` é definido na classe base como `virtual` e pode ser sobrescrito pelas classes derivadas.

Exemplo:

```csharp
public virtual void MostrarDetalhes()
```

e:

```csharp
public override void MostrarDetalhes()
```

Dessa forma, cada tipo de funcionário pode apresentar suas informações específicas.

---

## 🛠️ Tecnologias utilizadas

* **C#**
* **.NET**
* **Programação Orientada a Objetos**
* **Git**
* **GitHub**

---

## 📚 Finalidade acadêmica

Este projeto foi desenvolvido para fins acadêmicos e tem como objetivo praticar conceitos fundamentais de **Programação Orientada a Objetos em C#**, especialmente:

* Classes e objetos
* Atributos e propriedades
* Métodos
* Construtores
* Encapsulamento
* Herança
* Polimorfismo
* Sobrescrita de métodos

---

## 👨‍💻 Autores

**Matheus Eiki** RM559483<br>
**Davis Junior** RM560723<br>
**Matheus Machado** RM560340

GitHub: [Matheus-Eiki](https://github.com/Matheus-Eiki)

---

## 📄 Licença

Este projeto foi desenvolvido para fins acadêmicos.
