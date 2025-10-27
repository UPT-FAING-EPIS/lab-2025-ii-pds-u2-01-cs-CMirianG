# Configuración de GitHub Actions para Bank.Domain

Esta guía describe cómo configurar y usar los workflows de GitHub Actions para el proyecto Bank.Domain.

## 📋 Workflows Incluidos

### 1. `publish_docs.yml` - Documentación con DocFX

**Descripción**: Genera documentación automáticamente y la publica en GitHub Pages.

**Cuándo se ejecuta**:
- Push a la rama `main`
- Pull requests a `main`

**Configuración requerida**:
1. Ve a **Settings** > **Pages** en tu repositorio de GitHub
2. Selecciona **GitHub Actions** como fuente

### 2. `package_nuget.yml` - Tests, Análisis y Publicación NuGet

**Descripción**: Ejecuta pruebas unitarias, realiza análisis con SonarCloud y publica paquetes NuGet.

**Cuándo se ejecuta**:
- Push a las ramas `main` o `develop`
- Pull requests a `main`

**Configuración requerida**:

#### SonarCloud (Opcional pero recomendado)

1. Ve a [SonarCloud](https://sonarcloud.io) y crea una cuenta
2. Crea un nuevo proyecto
3. Copia tu **Organization Key** y **Project Key**
4. Genera un **SONAR_TOKEN**:
   - SonarCloud → Mi cuenta → Security → Generate Token
5. Agrega el token como secret en GitHub:
   - Settings → Secrets and variables → Actions → New repository secret
   - Nombre: `SONAR_TOKEN`
   - Valor: [Tu token de SonarCloud]
6. Actualiza el archivo `.github/workflows/package_nuget.yml`:
   - Reemplaza `SONAR_ORGANIZATION: # Agregar tu organización de SonarCloud aquí` con tu Organization Key

#### GitHub Packages

No se requiere configuración adicional. Los paquetes se publicarán automáticamente en GitHub Packages.

### 3. `release_version.yml` - Releases de GitHub

**Descripción**: Crea releases automáticos con paquetes NuGet, documentación y resultados de pruebas.

**Cuándo se ejecuta**:
- Creación de tags: `v*.*.*` (ej: `v1.0.0`)
- Manualmente desde la pestaña Actions

**Cómo crear un release**:

```bash
# Crear un tag
git tag v1.0.0

# Subir el tag
git push origin v1.0.0
```

El workflow se ejecutará automáticamente y creará un release con:
- Paquete NuGet (.nupkg)
- Documentación completa (ZIP)
- Resultados de pruebas (ZIP)

## 🚀 Uso Rápido

### Para generar documentación localmente:

```bash
cd Bank
dotnet tool install -g docfx
docfx metadata docfx.json
docfx build docfx.json
```

### Para ejecutar pruebas localmente:

```bash
cd Bank
dotnet test Bank.Domain.Tests/Bank.Domain.Tests.csproj --configuration Release
```

### Para empaquetar localmente:

```bash
cd Bank/Bank.Domain
dotnet pack --configuration Release --output ./nupkg
```

## 📦 Instalación del Paquete NuGet

Una vez que el paquete se haya publicado en GitHub Packages, puedes instalarlo:

```bash
dotnet add package Bank.Domain
```

**Nota**: Si el paquete es privado, necesitarás configurar el feed de NuGet en tu máquina:

```bash
dotnet nuget add source https://nuget.pkg.github.com/[TU_USUARIO]/index.json -n github -u [TU_USUARIO] -p [TOKEN] --store-password-in-clear-text
```

## 🛠️ Solución de Problemas

### Error: "DocFX 404 Not Found"
✅ **Resuelto**: Los workflows usan `dotnet tool install -g docfx` en lugar de descargar el ZIP.

### Error: "SonarCloud authentication failed"
- Verifica que el secret `SONAR_TOKEN` esté configurado correctamente
- Asegúrate de que la organización de SonarCloud coincida en el workflow

### Error: "GitHub Pages not updating"
- Verifica que GitHub Pages esté habilitado en Settings → Pages
- Asegúrate de que el workflow se ejecute completamente sin errores

## 📊 Verificación de Workflows

Para verificar que los workflows funcionan correctamente:

1. Ve a la pestaña **Actions** en GitHub
2. Deberías ver los workflows ejecutándose
3. Haz clic en cada workflow para ver los detalles
4. Los logs te mostrarán cualquier error o advertencia

## 🔄 Actualización de Versiones

Para actualizar las versiones de .NET, NUnit, etc., edita los workflows y cambia las versiones en las secciones correspondientes.

```yaml
env:
  DOTNET_VERSION: '9.0.x'  # Cambia aquí
```

Luego haz commit y push. Los workflows se actualizarán automáticamente.

## 📝 Notas Importantes

1. **Secrets**: Nunca expongas tus tokens o credenciales en los archivos de workflow
2. **Branch Protection**: Considera proteger la rama `main` para requerir aprobación de PRs
3. **Rate Limits**: GitHub Actions tiene límites de tiempo de ejecución. Verifica tu plan
4. **Costos**: GitHub Actions consume minutos de ejecución según tu plan de GitHub

## 🎉 ¡Listo!

Los workflows están configurados y listos para usar. Cada vez que hagas push, los workflows se ejecutarán automáticamente.
