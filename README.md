# Práctica - Estructuras de Datos

Este proyecto es una aplicación web interactiva desarrollada en ASP.NET Core MVC que sirve como demostración visual para diversos ejercicios basados en estructuras de datos como Listas, Pilas y Colas. La aplicación está diseñada para ser una herramienta educativa que permite a los usuarios ver el comportamiento de los algoritmos en tiempo real.

## Integrantes del Equipo

*   Juan Manuel Duarte Tah
*   Jose Octavio Hernandez Tec
*   Flor Maribel Ku May
*   Yeng Lee Salas Jimenez

**Grupo:** 4E - DSM (Desarrollo de Software Multiplataforma)

---

## Tecnologías Utilizadas

*   **Backend:** C# con ASP.NET Core MVC
*   **Frontend:** HTML5, CSS3, JavaScript (ES6+)
*   **Framework de Estilos:** Bootstrap 5
*   **Entorno de Desarrollo:** Visual Studio / Visual Studio Code

---

## Estructura del Proyecto

El proyecto sigue la arquitectura estándar de ASP.NET Core MVC:

*   `/Controllers`: Contiene los controladores C# que gestionan la lógica de negocio y las peticiones del usuario. Cada estructura de datos principal (Listas, Pilas, Colas) tiene su propio controlador.
*   `/Views`: Almacena los archivos Razor (`.cshtml`) que componen la interfaz de usuario. Cada ejercicio tiene su propia vista dedicada.
*   `/wwwroot`: Contiene todos los activos estáticos del lado del cliente, como hojas de estilo (`custom.css`), scripts de JavaScript e imágenes.
*   `/Models`: (No presente en el contexto, pero es donde se definirían las clases de modelo como `Producto.cs`).

---

## Ejercicios Implementados

A continuación se detalla cada uno de los ejercicios desarrollados, agrupados por la estructura de datos que utilizan.

### Listas (Lists)

#### Ejercicio 1: Productos Disponibles y Retirados
*   **Objetivo:** Simular la gestión de inventario de un supermercado, separando los productos en dos listas: "Disponibles" y "Retirados".
*   **Funcionalidad:**
    *   Permite agregar nuevos productos al almacén con un solo clic.
    *   El nombre (`Producto 1`, `Producto 2`, etc.), la cantidad y el precio se generan de forma aleatoria.
    *   Cada producto en la lista de "Disponibles" tiene un botón "Retirar" que lo mueve a la lista de "Retirados".
    *   Muestra un contador actualizado del número de productos en cada lista.
*   **Archivo:** `Views/Listas/ProductosDisponiblesRetirados.cshtml`

#### Ejercicio 2: Pares e Impares
*   **Objetivo:** Clasificar una serie de números ingresados por el usuario en dos listas separadas: una para números pares y otra para impares.
*   **Archivo:** `Views/Listas/ParesImpares.cshtml`

#### Ejercicio 3: Aprobados y Reprobados
*   **Objetivo:** Gestionar una lista de estudiantes y sus calificaciones, clasificándolos en una lista de "Aprobados" o "Reprobados" según un umbral de calificación.
*   **Archivo:** `Views/Listas/AprobadosReprobados.cshtml`

#### Ejercicio 4: Ordenar Productos
*   **Objetivo:** Administrar una lista de productos que permite agregarlos y eliminarlos, manteniendo la lista siempre ordenada alfabéticamente por nombre.
*   **Funcionalidad:**
    *   Formulario para agregar productos con clave, nombre y precio.
    *   Validación para no permitir claves duplicadas.
    *   Formulario para eliminar un producto especificando su clave.
    *   La tabla de productos se reordena automáticamente por nombre después de cada operación.
    *   Muestra un resumen con el costo total de todos los productos en la lista.
*   **Archivo:** `Views/Listas/EliminarOrdenarProductos.cshtml`

#### Ejercicio 5: Listar Palabras por Letra
*   **Objetivo:** Clasificar un conjunto de palabras en múltiples listas, donde cada lista agrupa palabras que comienzan con la misma letra.
*   **Funcionalidad:**
    *   Permite al usuario ingresar múltiples palabras separadas por espacios, comas o saltos de línea.
    *   Las palabras se validan, se capitalizan y se organizan en tarjetas, una por cada letra inicial.
    *   Tanto las tarjetas de letras como las palabras dentro de cada tarjeta se muestran en orden alfabético.
    *   Un panel de estadísticas muestra el total de palabras únicas y el número de listas creadas.
*   **Archivo:** `Views/Listas/ListarPalabrasPorLetra.cshtml`

### Pilas (Stacks)

#### Ejercicio 1: Invertir Palabra
*   **Objetivo:** Demostrar el uso de una pila para invertir el orden de los caracteres de una palabra.
*   **Archivo:** `Views/Pilas/InvertirPalabra.cshtml`

#### Ejercicio 2: Palíndromo
*   **Objetivo:** Verificar si una palabra es un palíndromo (se lee igual al derecho y al revés) utilizando una pila.
*   **Funcionalidad:**
    *   Animación paso a paso que muestra cómo los caracteres de la primera mitad de la palabra se apilan (PUSH).
    *   Posteriormente, se desapilan (POP) y se comparan con los caracteres de la segunda mitad de la palabra.
    *   La interfaz resalta visualmente las coincidencias (verde) o diferencias (rojo).
*   **Archivo:** `Views/Pilas/Palindromo.cshtml`

#### Ejercicio 3: Suma de Números Grandes
*   **Objetivo:** Realizar la suma de dos números que son demasiado grandes para ser manejados por los tipos de datos numéricos estándar, utilizando dos pilas.
*   **Funcionalidad:**
    *   Cada dígito de los números se inserta en una pila.
    *   La animación muestra el proceso de desapilar los dígitos, sumarlos junto con el acarreo, y construir el resultado final.
    *   Incluye controles para pausar, reanudar y ajustar la velocidad de la animación.
*   **Archivo:** `Views/Pilas/SumaNumerosGrandes.cshtml`

#### Ejercicio 4: Reemplazar Valor
*   **Objetivo:** Reemplazar todas las ocurrencias de un número por otro dentro de una pila, utilizando una pila auxiliar.
*   **Archivo:** `Views/Pilas/ReemplazarValor.cshtml`

### Colas (Queues)

#### Ejercicio 1: Ventanilla de un Banco
*   **Objetivo:** Simular la gestión de una cola de clientes en la ventanilla de un banco, siguiendo el principio FIFO (First-In, First-Out).
*   **Funcionalidad:**
    *   Permite registrar la llegada de clientes con su nombre y tipo de movimiento.
    *   Los clientes se añaden al final de la cola visual.
    *   El botón "Atender Cliente" elimina al primer cliente de la cola, calcula su tiempo de espera y muestra un comprobante.
    *   Muestra los punteros de "Frente" y "Final" de la cola.
*   **Archivo:** `Views/Colas/VentanillaBanco.cshtml`

#### Ejercicio 2: Juego de Pintar Coches
*   **Objetivo:** Un juego interactivo donde el jugador debe pintar coches que llegan en una cola antes de que la fila se llene.
*   **Funcionalidad:**
    *   Los coches llegan a intervalos de tiempo que se van acortando a medida que el jugador avanza.
    *   El jugador debe seleccionar el color correcto de una de las tres paletas para pintar el primer coche de la fila.
    *   El juego termina si la cola de coches alcanza su capacidad máxima (5 coches).
    *   Al final, se muestra la puntuación (coches pintados) y el tiempo total de juego.
*   **Archivo:** `Views/Colas/PintarCoches.cshtml`

#### Ejercicio 3: Estacionamiento
*   **Objetivo:** Simular la entrada y salida de coches en un estacionamiento con capacidad limitada, utilizando una cola.
*   **Funcionalidad:**
    *   Permite registrar la entrada de coches con su placa y nombre del propietario.
    *   Valida que no se exceda la capacidad del estacionamiento.
    *   Al retirar un coche, se calcula el costo de la estancia basado en el tiempo transcurrido.
*   **Archivo:** `Views/Colas/Estacionamiento.cshtml`

---

## Cómo Ejecutar el Proyecto

1.  Clonar o descargar el repositorio.
2.  Abrir la solución (`.sln`) en Visual Studio.
3.  Asegurarse de tener instalado el SDK de .NET correspondiente.
4.  Presionar `F5` o el botón de "Iniciar" para compilar y ejecutar el proyecto.
5.  El navegador se abrirá automáticamente en la página de inicio, mostrando el menú de ejercicios.