# AppMath

## Descripción
**AppMath** es una biblioteca de utilidades matemáticas escrita en C#. Actualmente incluye funciones básicas para realizar cálculos seguros y evitar errores comunes, como la división por cero. El proyecto está diseñado para ser integrado de manera sencilla en otras aplicaciones de .NET.

## Tech Stack
- **Lenguaje:** C#
- **Framework:** .NET Framework 4.5
- **IDE Recomendado:** Visual Studio 2013 o superior

## Instalación y Configuración

Sigue estos pasos para clonar, compilar y probar el proyecto en tu entorno local.

### 1. Clonar el repositorio
Abre una terminal o consola y ejecuta el siguiente comando:
```bash
git clone <URL-del-repositorio>
cd <nombre-del-repositorio>
```

### 2. Compilar el proyecto
Si estás en Windows y utilizas **Visual Studio**, puedes abrir el archivo `AppMath.sln` y presionar `F6` (Build Solution) o ir al menú `Build > Build Solution`.

Si deseas compilar desde la línea de comandos usando **MSBuild**:
Asegúrate de que MSBuild esté en tu variable de entorno PATH, abre el "Developer Command Prompt" y ejecuta:
```bash
msbuild AppMath.sln
```
Esto generará los archivos binarios compilados en la ruta `AppMath/bin/Debug/` o `AppMath/bin/Release/` dependiendo de la configuración.

## Estructura de Carpetas
- `/AppMath.sln`: El archivo de la solución de Visual Studio que agrupa el proyecto.
- `/AppMath/`: Carpeta que contiene el código fuente de la biblioteca de clases.
  - `AppMath.csproj`: Archivo de configuración del proyecto C#.
  - `AppMath.cs`: Contiene la lógica principal y los métodos de la clase `AppMath`.
  - `/Properties/`: Contiene el archivo `AssemblyInfo.cs` con metadatos del ensamblado.

## Guía de Uso

A continuación se muestra un ejemplo básico de cómo utilizar la clase `AppMath` en otra aplicación .NET. Primero, asegúrate de referenciar la biblioteca compilada (`AppMath.dll`) en tu proyecto destino.

```csharp
using System;
using AppMath; // Importar el espacio de nombres

namespace MiAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar la clase
            AppMath.AppMath mathUtils = new AppMath.AppMath();

            // Usar el método Dividir
            decimal resultado1 = mathUtils.Dividir(10m, 2m);
            Console.WriteLine($"10 / 2 = {resultado1}"); // Salida: 5

            // División por cero gestionada internamente (devuelve 0)
            decimal resultado2 = mathUtils.Dividir(10m, 0m);
            Console.WriteLine($"10 / 0 = {resultado2}"); // Salida: 0
        }
    }
}
```
