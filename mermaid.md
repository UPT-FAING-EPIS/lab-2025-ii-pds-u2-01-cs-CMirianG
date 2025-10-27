# Diagramas de Diseño - Bank.Domain

## Diagrama de Clases - Factory Pattern

```mermaid
classDiagram
    class ICreditCard {
        <<interface>>
        +GetCardType() string
        +GetCreditLimit() int
        +GetAnnualCharge() int
    }
    
    class CreditCardFactory {
        +GetCreditCard(cardType: string) ICreditCard
    }
    
    class CreditCardFactoryMethod {
        <<abstract>>
        #MakeProduct()* ICreditCard
        +CreateProduct() ICreditCard
    }
    
    class MoneyBack {
        +GetCardType() string
        +GetCreditLimit() int
        +GetAnnualCharge() int
    }
    
    class Titanium {
        +GetCardType() string
        +GetCreditLimit() int
        +GetAnnualCharge() int
    }
    
    class Platinum {
        +GetCardType() string
        +GetCreditLimit() int
        +GetAnnualCharge() int
    }
    
    class MoneyBackFactoryMethod {
        #MakeProduct() ICreditCard
    }
    
    class TitaniumFactoryMethod {
        #MakeProduct() ICreditCard
    }
    
    class PlatinumFactoryMethod {
        #MakeProduct() ICreditCard
    }
    
    ICreditCard <|-- MoneyBack
    ICreditCard <|-- Titanium
    ICreditCard <|-- Platinum
    
    CreditCardFactoryMethod <|-- MoneyBackFactoryMethod
    CreditCardFactoryMethod <|-- TitaniumFactoryMethod
    CreditCardFactoryMethod <|-- PlatinumFactoryMethod
    
    MoneyBackFactoryMethod ..> MoneyBack : creates
    TitaniumFactoryMethod ..> Titanium : creates
    PlatinumFactoryMethod ..> Platinum : creates
    
    CreditCardFactory ..> MoneyBack : creates
    CreditCardFactory ..> Titanium : creates
    CreditCardFactory ..> Platinum : creates
```

## Diagrama de Secuencia - Factory Method

```mermaid
sequenceDiagram
    participant Client
    participant Factory as CreditCardFactory
    participant MoneyBack
    
    Client->>Factory: GetCreditCard("MoneyBack")
    Factory->>MoneyBack: new MoneyBack()
    MoneyBack-->>Factory: ICreditCard instance
    Factory-->>Client: ICreditCard instance
    Client->>MoneyBack: GetCardType()
    MoneyBack-->>Client: "MoneyBack"
    Client->>MoneyBack: GetCreditLimit()
    MoneyBack-->>Client: 15000
    Client->>MoneyBack: GetAnnualCharge()
    MoneyBack-->>Client: 500
```

## Diagrama de Secuencia - Factory Method Pattern

```mermaid
sequenceDiagram
    participant Client
    participant FactoryMethod as CreditCardFactoryMethod
    participant ConcreteFactory as MoneyBackFactoryMethod
    participant Product as MoneyBack
    
    Client->>ConcreteFactory: CreateProduct()
    ConcreteFactory->>Product: MakeProduct()
    Product->>ConcreteFactory: new MoneyBack()
    ConcreteFactory-->>Client: ICreditCard instance
    Client->>Product: GetCardType()
    Product-->>Client: "MoneyBack"
    Client->>Product: GetCreditLimit()
    Product-->>Client: 15000
    Client->>Product: GetAnnualCharge()
    Product-->>Client: 500
```

## Tabla de Comparación de Tarjetas

```mermaid
graph TD
    A[ICreditCard] --> B[MoneyBack]
    A --> C[Titanium]
    A --> D[Platinum]
    
    B -->|Límite: $15,000| E[Cargo Anual: $500]
    C -->|Límite: $25,000| F[Cargo Anual: $1,500]
    D -->|Límite: $35,000| G[Cargo Anual: $2,000]
    
    style B fill:#90EE90
    style C fill:#87CEEB
    style D fill:#FFD700
```

## Casos de Uso

### 1. Creación Simple con Factory

```mermaid
graph LR
    A[Cliente] -->|GetCreditCard| B[CreditCardFactory]
    B -->|new MoneyBack| C[MoneyBack]
    B -->|new Titanium| D[Titanium]
    B -->|new Platinum| E[Platinum]
```

### 2. Creación con Factory Method

```mermaid
graph LR
    A[Cliente] -->|CreateProduct| B[Factory Method]
    B -->|MoneyBackFactoryMethod| C[MoneyBack]
    B -->|TitaniumFactoryMethod| D[Titanium]
    B -->|PlatinumFactoryMethod| E[Platinum]
```
