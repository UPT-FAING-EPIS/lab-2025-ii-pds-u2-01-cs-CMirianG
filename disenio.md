# Diseño del Sistema Bank.Domain

## Patrones de Diseño Implementados

Este proyecto implementa el patrón **Factory Method** para la creación de diferentes tipos de tarjetas de crédito.

## Diagramas

Los diagramas del diseño están disponibles en el archivo: [mermaid.md](mermaid.md)

## Arquitectura

El sistema utiliza los siguientes componentes:

### Factory Method Pattern

El patrón Factory Method permite crear objetos de diferentes tipos de tarjetas sin especificar la clase exacta del objeto que se creará.

### Componentes

1. **ICreditCard**: Interfaz que define el contrato para las tarjetas
2. **CreditCardFactory**: Factory simple que crea tarjetas basándose en un string
3. **CreditCardFactoryMethod**: Clase abstracta que implementa el Factory Method pattern
4. **MoneyBack, Titanium, Platinum**: Implementaciones concretas de tarjetas
5. **MoneyBackFactoryMethod, TitaniumFactoryMethod, PlatinumFactoryMethod**: Factories concretas

## Ventajas

- Facilita la extensión con nuevos tipos de tarjetas
- Permite la creación flexible de objetos
- Separa la lógica de creación del uso de los objetos
