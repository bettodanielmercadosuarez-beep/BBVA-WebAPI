# 🏦 BBVA-WebAPI: API REST para Gestión Bancaria

![.NET 8](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet)

## 🚀 Descripción del Proyecto

Este proyecto es una **API REST moderna y escalable** diseñada para simular las operaciones básicas de un sistema bancario. Permite la gestión de cuentas, transacciones y autenticación de usuarios.

Desarrollada bajo la arquitectura de servicios web, esta API demuestra mi capacidad para construir soluciones robustas utilizando tecnologías de Microsoft en un entorno profesional.

---

## 🛠️ Tecnologías Utilizadas (Hard Skills)

Este proyecto fue construido utilizando un *stack* de tecnologías moderno y de alto rendimiento, ideal para aplicaciones de sistemas empresariales.

| Categoría | Tecnología | Versión | Propósito / Habilidad Demostrada |
| :--- | :--- | :--- | :--- |
| **Framework** | **.NET** | 8.0 | Core del desarrollo *backend*. |
| **Lenguaje** | **C#** | - | Lenguaje principal de programación orientada a objetos (POO). |
| **Base de Datos** | **SQL Server** | - | Motor de base de datos relacional para persistencia de datos. |
| **ORM** | **Entity Framework Core (EF Core)** | 9.0.6 | Mapeo Objeto-Relacional para la interacción con la base de datos. |
| **Documentación** | **Swashbuckle / Swagger** | 6.6.2 | Generación automática de documentación de la API para facilitar pruebas e integración. |

---

## ✨ Características y Funcionalidades Clave

Las principales funcionalidades desarrolladas en esta API incluyen:

* **Gestión de Cuentas (CRUD):** Creación, lectura, actualización y eliminación de cuentas bancarias.
* **Autenticación y Autorización:** Implementación de un sistema de *login* seguro para usuarios de la API.
* **Transacciones:** Endpoints para simular depósitos, retiros y transferencias entre cuentas.
* **Consultas:** Rutas para consultar saldos y el historial de movimientos de una cuenta.

---

## 🛡️ Buenas Prácticas y Calidad de Código

Para asegurar la calidad, la seguridad y la modernidad del código, se implementaron las siguientes prácticas:

1.   **Seguridad en Desarrollo:** Configuración de **HTTPS** como protocolo de *debugging* activo.
2.  **Manejo de Secretos:** Uso de **User Secrets** para almacenar información sensible (como cadenas de conexión) fuera del repositorio de código público.
3.  **Código Limpio:** Configuración del proyecto con `<Nullable>enable</Nullable>` para evitar referencias nulas inesperadas y fomentar un código más seguro en C#.
4.  **API Documentada:** Uso de Swagger para proveer una interfaz gráfica que permite a cualquier usuario probar los *endpoints* de la API sin necesidad de herramientas externas.

---

## ⚙️ Instalación y Configuración

Para clonar y ejecutar este proyecto localmente, sigue los siguientes pasos:

1.  **Clonar el Repositorio:**
    ```bash
    git clone [https://github.com/bettodanielmercadosuarez-beep/BBVA-WebAPI.git](https://github.com/bettodanielmercadosuarez-beep/BBVA-WebAPI.git)
    cd BBVA-WebAPI
    ```
2.  **Restaurar Paquetes:** Abre la solución en Visual Studio o utiliza el comando de .NET:
    ```bash
    dotnet restore
    ```
3.  **Configurar Base de Datos:**
    * Asegúrate de tener una instancia de **SQL Server** disponible.
    * Aplica las migraciones de Entity Framework Core para crear la base de datos:
        ```bash
        dotnet ef database update
        ```
4.  **Ejecutar la API:**
    ```bash
    dotnet run
    ```

La API estará disponible en la URL configurada y la documentación de Swagger será accesible a través de `/swagger`.
