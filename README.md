# AppMath

Una biblioteca de clases sencilla en C# (Class Library) que proporciona funcionalidades matemáticas utilitarias básicas. Actualmente implementa la división de números decimales previniendo errores de división por cero de manera controlada.

## Pila Tecnológica (Tech Stack)

* **Lenguaje:** C#
* **Framework:** .NET Framework 4.5
* **Tipo de Proyecto:** Biblioteca de Clases (Class Library)
* **Herramientas de Compilación:** MSBuild (Visual Studio)

## Requisitos Previos e Instalación Local

Para trabajar con este proyecto, necesitarás:

* Windows OS con [.NET Framework 4.5 instalado](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net45).
* [Visual Studio](https://visualstudio.microsoft.com/) o [MSBuild Tools](https://visualstudio.microsoft.com/downloads/#build-tools-for-visual-studio-2022) instalados en tu sistema.
* Un cliente de Git para clonar el repositorio.

### Instrucciones de Instalación

1. Clona el repositorio en tu máquina local:
   ```bash
   git clone <url-del-repositorio>
   cd <nombre-del-repositorio>
   ```

2. Compilar usando MSBuild (o directamente abriendo la solución `AppMath.sln` en Visual Studio y construyendo el proyecto):
   ```cmd
   msbuild AppMath.sln /p:Configuration=Release
   ```
   *Nota: Si estás utilizando la CLI moderna de .NET, el archivo del proyecto actual puede no ser directamente compatible con `dotnet build` ya que utiliza el formato antiguo de .NET Framework (.csproj estilo no SDK).*

3. El archivo resultante `.dll` se encontrará en el directorio de compilación, por defecto `AppMath/bin/Release/AppMath.dll` o `AppMath/bin/Debug/AppMath.dll`.

## Estructura del Proyecto

La estructura principal del repositorio se compone de:

* `AppMath/`: Carpeta del proyecto principal.
  * `AppMath.csproj`: Archivo del proyecto de Visual Studio / MSBuild.
  * `AppMath.cs`: Contiene la lógica de código fuente de la clase utilitaria `AppMath`.
  * `Properties/`: Carpeta que contiene información de los ensamblados (`AssemblyInfo.cs`).
* `AppMath.sln`: Solución principal de Visual Studio que contiene las referencias al proyecto.

## Guía de Uso y Ejemplos

Este proyecto es una biblioteca de clases. Para utilizarla en otro proyecto, añade una referencia a `AppMath.dll`.

Ejemplo de uso en C#:

```csharp
using System;
using AppMath; // Referenciar el namespace

namespace MathDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar la clase
            var mathUtils = new AppMath.AppMath();

            // Realizar una división segura
            decimal result = mathUtils.Dividir(10.5m, 2.0m);
            Console.WriteLine($"10.5 / 2.0 = {result}");

            // Prueba con división por cero
            decimal errorResult = mathUtils.Dividir(5.0m, 0m);
            Console.WriteLine($"5.0 / 0 = {errorResult}"); // Retornará 0 según la lógica actual
        }
    }
}
```
