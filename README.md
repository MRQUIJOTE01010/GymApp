# GymApp - Sistema de Gestión de Gimnasio

## Descripción

**GymApp** es una aplicación de consola desarrollada en **C# (.NET )** que permite gestionar los miembros de un gimnasio.
El sistema implementa una **arquitectura por capas** y utiliza **Entity Framework Core** como ORM para el acceso a datos, eliminando completamente el uso de ADO.NET y consultas SQL manuales.

---

## Funcionalidades De La App

* Registrar nuevos miembros
* Listar todos los miembros
* Buscar miembro por cédula
* Actualizar teléfono
* Eliminar miembro

---

## Arquitectura del Proyecto

El proyecto sigue una arquitectura en capas para mejorar la organización y mantenibilidad.


## Tecnologías Utilizadas

* **C# (.NET 8)**
* **Entity Framework Core**
* **SQLite**
* **LINQ**
* **Spectre.Console**

---

##Paquetes Instalados

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Spectre.Console
```

---

### Ejecutar el proyecto

```bash
dotnet run
```

---

## Uso de Entity Framework

El proyecto utiliza **Entity Framework Core** para manejar la base de datos mediante objetos.
---

