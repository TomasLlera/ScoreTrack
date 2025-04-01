# Proyecto de Estadísticas de Jugadores de Fútbol - ScoreTrack

Este es mi proyecto de consola en C# llamado **ScoreTrack**. El objetivo de la aplicación es gestionar y mostrar estadísticas de jugadores de fútbol, permitiendo interactuar con la base de datos de jugadores mediante un menú de opciones.
Ahora mismo el programa al no estar conectado a una base de datos tiene datos pre-cargados para que sea mas facil su utilizacion.

## Descripción

**ScoreTrack** permite realizar las siguientes acciones sobre un conjunto de jugadores de fútbol:

- Mostrar jugadores por equipo.
- Agregar nuevos jugadores.
- Mostrar estadísticas de los jugadores (edad, goles, asistencias, partidos jugados).
- Ordenar jugadores por diferentes criterios (nombre, apellido, goles, edad, etc.).
- Eliminar jugadores de la lista y moverlos a una lista de eliminados.
- Buscar jugadores por nombre o apellido.
- Mostrar jugadores eliminados.

Este proyecto fue diseñado para ser presentado al final de año, aunque algunas funcionalidades pueden tener errores o no estar completamente optimizadas.

## Características

- **Estructura de datos**: Se utiliza una estructura `struct` para almacenar los datos de los jugadores.
- **Interacción de consola**: El usuario interactúa con la aplicación a través de un menú basado en texto.
- **Persistencia temporal**: Los datos de los jugadores se mantienen durante la ejecución del programa, pero no se guardan de manera persistente entre sesiones.
- **Búsqueda y eliminación**: Permite buscar jugadores por nombre o apellido, y eliminar jugadores de la lista.

## Requisitos

- **.NET SDK** (C#) para compilar y ejecutar el proyecto.
- **Conocimientos básicos de C#**: El proyecto utiliza estructuras de datos como listas, estructuras y operaciones básicas de consola.

## Mejoras Realizadas Version 2.0

- **Optimización de la carga de datos**: La carga inicial de jugadores y equipos ahora se realiza automáticamente al iniciar la aplicación, haciendo que la experiencia de usuario sea más fluida.
- **Mejoras en la interfaz de usuario**: Se han realizado cambios en la forma de mostrar las estadísticas para que sean más fáciles de leer, con una mejor organización de los datos en tablas.
- **Funcionalidad de búsqueda de jugadores**: Implementación de un sistema de búsqueda que permite encontrar jugadores por nombre o apellido, mostrando su equipo.
- **Ordenación de jugadores**: Se implementó la capacidad de ordenar a los jugadores por nombre, goles o edad, para facilitar su análisis.
- **Manejo de errores y validación de datos**: Se han añadido validaciones para asegurar que los datos ingresados sean correctos y evitar errores en la entrada.

## Instalación

1. Clona este repositorio en tu máquina local:
   ```bash
   git clone https://github.com/tu_usuario/ScoreTrack.git
