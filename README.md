# Bank.Domain

Biblioteca de dominio para el sistema de tarjetas de crédito del banco que implementa el patrón Factory Method.

## Características

- Implementación del patrón Factory Method para creación de tarjetas de crédito
- Tres tipos de tarjetas: MoneyBack, Titanium Edge y Platinum Plus
- Documentación completa generada con DocFX
- Pruebas unitarias con NUnit
- Análisis de código con SonarCloud
- Publicación automática de paquetes NuGet

## Instalación

```bash
dotnet add package Bank.Domain
```

## Uso

### Factory Simple

```csharp
using Bank.Domain;

// Crear una tarjeta MoneyBack
ICreditCard? card = CreditCardFactory.GetCreditCard("MoneyBack");
if (card != null)
{
    Console.WriteLine($"Tipo: {card.GetCardType()}");
    Console.WriteLine($"Límite: {card.GetCreditLimit()}");
    Console.WriteLine($"Cargo anual: {card.GetAnnualCharge()}");
}
```

### Factory Method Pattern

```csharp
using Bank.Domain;

// Crear una tarjeta usando Factory Method
CreditCardFactoryMethod factory = new MoneyBackFactoryMethod();
ICreditCard card = factory.CreateProduct();

Console.WriteLine($"Tipo: {card.GetCardType()}");
Console.WriteLine($"Límite: {card.GetCreditLimit()}");
Console.WriteLine($"Cargo anual: {card.GetAnnualCharge()}");
```

## Tipos de Tarjetas

| Tipo | Límite de Crédito | Cargo Anual |
|------|------------------|-------------|
| MoneyBack | $15,000 | $500 |
| Titanium Edge | $25,000 | $1,500 |
| Platinum Plus | $35,000 | $2,000 |

## Desarrollo

### Prerrequisitos

- .NET 9.0 SDK
- Visual Studio 2022 o VS Code

### Compilar

```bash
dotnet build Bank/Bank.sln
```

### Ejecutar pruebas

```bash
dotnet test Bank/Bank.Domain.Tests/Bank.Domain.Tests.csproj
```

### Generar documentación

```bash
cd Bank
docfx metadata docfx.json
docfx build docfx.json
```

## CI/CD

El proyecto incluye workflows de GitHub Actions para:

- **Documentación**: Generación automática con DocFX y publicación en GitHub Pages
- **Pruebas y Análisis**: Ejecución de pruebas unitarias, análisis con SonarCloud y publicación de paquetes NuGet
- **Releases**: Creación automática de releases con paquetes y documentación

## Licencia

MIT License