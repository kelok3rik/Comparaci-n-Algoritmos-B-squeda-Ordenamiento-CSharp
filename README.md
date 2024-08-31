# Algoritmos de Búsqueda y Ordenamiento en Paralelo

Este proyecto consiste en una aplicación desarrollada en **C#** utilizando **Windows Forms** que implementa y compara diferentes algoritmos de búsqueda y ordenamiento. La aplicación ejecuta estos algoritmos en paralelo sobre un mismo conjunto de datos y calcula el tiempo de ejecución para determinar cuál algoritmo completa su tarea más rápidamente.

## Descripción

La actividad se centra en la **implementación y comparación de algoritmos de búsqueda y ordenamiento** en un entorno paralelo. Se exploran diversas técnicas algorítmicas paralelas, como la división y conquista, la programación dinámica y el enfoque basado en flujos de datos, adaptándolas para aprovechar al máximo la capacidad de procesamiento paralelo.

Se implementan los siguientes algoritmos:

- **Algoritmos de Búsqueda**:
  - **Búsqueda Secuencial**: Recorre el arreglo secuencialmente para encontrar un elemento.
  - **Búsqueda Binaria**: Busca un elemento en un arreglo ordenado dividiendo el rango de búsqueda repetidamente.

- **Algoritmos de Ordenamiento**:
  - **Ordenamiento de la Burbuja**: Reordena los elementos comparando y intercambiando pares adyacentes.
  - **Quick Sort**: Ordena elementos dividiendo el arreglo en subarreglos menores.
  - **Método de Inserción**: Inserta elementos en la posición correcta dentro de un subarreglo ordenado.

El programa ejecuta los algoritmos en paralelo sobre un conjunto de datos generado aleatoriamente y compara los tiempos de ejecución para determinar los más rápidos en cada categoría. 

## Tecnologías Utilizadas

- **Lenguaje de Programación**: C#
- **Entorno de Desarrollo**: Windows Forms
- **Bibliotecas**: .NET Framework

## Requisitos Previos

- Tener instalado **Microsoft Visual Studio** o cualquier otro entorno compatible con **C#**.
- **.NET Framework**: Asegúrate de tener la versión necesaria de .NET Framework instalada en tu máquina.

## Ejemplo de resultados

 - Algoritmo de Búsqueda Secuencial: 0.012 segundos
 - Algoritmo de Búsqueda Binaria: 0.004 segundos
 - Algoritmo de Ordenamiento por Burbuja: 0.025 segundos
 - Algoritmo de Ordenamiento Rápido: 0.008 segundos



