# 📘 Proyecto ASP.NET MVC - Sistema de Gestión de Pólizas

Este proyecto es una aplicación web desarrollada con el patrón **MVC (Model-View-Controller)** utilizando **ASP.NET Core** y **Entity Framework Core** para el manejo de base de datos. Permite gestionar clientes, pólizas y otros datos relacionados con seguros.

---

## 🛠️ Tecnologías Utilizadas

- ASP.NET Core MVC 7.0
- Entity Framework Core
- SQL Server (LocalDB o SQL Server Express)
- Bootstrap (opcional)
- Visual Studio 2022 o superior

---

## 🚀 Instrucciones para Ejecutar el Proyecto

### 🔧 Requisitos

- Visual Studio 2022 o superior
- .NET 7 SDK
- SQL Server (Express o LocalDB)

---

### 1️⃣ Clona o descomprime el proyecto

1. Abre Visual Studio.
2. Selecciona **"Abrir un proyecto o una solución"** y elige el archivo `.sln`.

---

### 2️⃣ Configura la Base de Datos

1. Abre el archivo `appsettings.json`.
2. Verifica o ajusta la cadena de conexión según tu instalación de SQL Server:

```json
"ConnectionStrings": {
  "Conexion": "Server=(localdb)\\MSSQLLocalDB;Database=ProyectoMVC_DB;Trusted_Connection=True;"
}
