[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/zYKD3KOQ)
# Práctica en Clase 07: Implementación de Web con Razor Pages para Productos

## Información General
- **Curso:** Desarrollo de Aplicaciones Web
- **Práctica:** #7
- **Rubro:** Caso práctico 2
- **Valor:** 6%
- **Semana:** 10
- **Duración:** 1 hora

---

## 📋 Objetivo
Crear la aplicación web con Razor Pages para el **API de Productos** desarrollado en la Práctica en Clase 04, replicando la misma estructura implementada en la **PP3** (videos Semana 06 de Vehículos).

## Objetivos de Aprendizaje
Al finalizar esta práctica, el estudiante será capaz de:
- Crear un proyecto ASP.NET Core con Razor Pages
- Consumir una API REST desde una aplicación web
- Implementar páginas CRUD con Razor Pages
- Configurar la URL base del API en `appsettings.json`
- Manejar la navegación entre páginas

---

## Requisitos Previos
- Tener completada la Práctica en Clase 04 (API de Productos con reglas y servicios)
- Tener el API de Productos ejecutándose localmente

---

## 🏗️ Estructura del Proyecto

Crear la siguiente estructura (equivalente a `Vehiculos.WEB` de la semana 06):

```
Producto.WEB/
├── Abstracciones/
│   └── Modelos/
│       └── Producto.cs
├── Reglas/
│   └── ProductoReglas.cs
├── Web/
│   ├── appsettings.json
│   ├── Program.cs
│   └── Pages/
│       └── Productos/
│           ├── Index.cshtml
│           ├── Index.cshtml.cs
│           ├── Detalle.cshtml
│           ├── Detalle.cshtml.cs
│           ├── Agregar.cshtml
│           ├── Agregar.cshtml.cs
│           ├── Editar.cshtml
│           ├── Editar.cshtml.cs
│           ├── Eliminar.cshtml
│           └── Eliminar.cshtml.cs
└── Producto.WEB.sln
```

---

## 📝 Instrucciones

- Copiar el `.gitignore` del proyecto anterior
- Copiar el código fuente de la Práctica en Clase 04 como punto de partida
- Crear el nuevo proyecto Web siguiendo la misma estructura que `Vehiculos.WEB` (Semana 06)
- Implementar las 5 páginas Razor para Productos:
  - **Index**: Listado de productos
  - **Detalle**: Ver detalle de un producto
  - **Agregar**: Formulario para crear un nuevo producto
  - **Editar**: Formulario para modificar un producto existente
  - **Eliminar**: Confirmación y eliminación de un producto
- Configurar la URL del API en `appsettings.json`
- Ejecutar ambos proyectos (API y Web) simultáneamente y verificar el CRUD completo
- Subir el código al repositorio