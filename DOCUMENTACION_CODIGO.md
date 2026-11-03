# Documentación del código – Tarea 3.1: Pilas y Colas estáticas

**Alumno:** Rosembert Jared Ortiz Reyes | **Matrícula:** I25050406 | **Escuela:** TECNM
**Maestro:** Ruben Riojas | **Fecha:** 2 de noviembre de 2026

---

## 1. Descripción general

Aplicación de escritorio en C# (Windows Forms, .NET 8). Implementa tres estructuras lineales con memoria estática: Pila, Cola simple y Cola circular. Todas usan un arreglo de tamaño fijo y manejan sus propios punteros de índice. No se usan colecciones nativas.

## 2. Arquitectura

El proyecto separa la **lógica** (carpeta `Estructuras`) de la **interfaz** (carpeta `Interfaz`).

```
IEstructura  <|-- PilaEstatica
IEstructura  <|-- ColaSimple
IEstructura  <|-- ColaCircular

MainForm  contiene 3 x PanelEstructura  (uno por pestaña)
PanelEstructura  usa  IEstructura
```

La interfaz `IEstructura` permite que un solo panel gráfico controle cualquiera de las tres estructuras.

## 3. Archivos

| Archivo | Función |
|---|---|
| `Program.cs` | Punto de entrada; inicia `MainForm`. |
| `Estructuras/IEstructura.cs` | Contrato común de las estructuras. |
| `Estructuras/PilaEstatica.cs` | Pila LIFO con puntero `top`. |
| `Estructuras/ColaSimple.cs` | Cola FIFO con `front` y `rear`. |
| `Estructuras/ColaCircular.cs` | Cola FIFO circular con `front`, `rear` y `count`. |
| `Interfaz/MainForm.cs` y `.Designer.cs` | Ventana principal con 3 pestañas. |
| `Interfaz/PanelEstructura.cs` y `.Designer.cs` | Panel reutilizable con botones, arreglo visual y registro. |

## 4. Interfaz `IEstructura`

| Miembro | Descripción |
|---|---|
| `Nombre`, `Capacidad`, `Cantidad` | Propiedades de solo lectura. |
| `Insertar(string)` | Push / Enqueue. |
| `Extraer()` | Pop / Dequeue. |
| `Ver()` | Peek / Front (no retira el dato). |
| `EstaVacia()`, `EstaLlena()` | isEmpty / isFull. |
| `Reiniciar()` | Limpia el arreglo y reinicia los punteros. |
| `ObtenerArreglo()` | Copia del arreglo para mostrarlo en pantalla. |
| `DescribirPunteros()` | Texto con los valores de los punteros. |
| `EtiquetaIndice(int)` | Marca `<- top`, `<- front` o `<- rear` en una posición. |

Los errores (desbordamiento o subdesbordamiento) se reportan con `InvalidOperationException`.

## 5. Pila estática (`PilaEstatica`)

- Atributos: `string[] _datos` y `int _top` (inicia en `-1`).
- `Insertar` (Push): si `_top == capacidad - 1` lanza error; si no, `_top++` y `_datos[_top] = dato`.
- `Extraer` (Pop): si `_top == -1` lanza error; si no, toma `_datos[_top]`, lo limpia y hace `_top--`.
- `Ver` (Peek): devuelve `_datos[_top]` sin modificar nada.
- `EstaVacia`: `_top == -1`. `EstaLlena`: `_top == capacidad - 1`.
- Complejidad de todas las operaciones: O(1).

## 6. Cola simple (`ColaSimple`)

- Atributos: `_datos`, `_front` (inicia en `0`) y `_rear` (inicia en `-1`).
- `Insertar` (Enqueue): si `_rear == capacidad - 1` lanza error; si no, `_rear++` y guarda el dato.
- `Extraer` (Dequeue): si `_front > _rear` lanza error; si no, toma `_datos[_front]`, lo limpia y hace `_front++`.
- `EstaVacia`: `_front > _rear`. `EstaLlena`: `_rear == capacidad - 1`.
- **Limitación:** los espacios liberados al inicio no se reutilizan. Puede marcar "llena" aunque haya casillas libres antes de `front`.

## 7. Cola circular (`ColaCircular`)

- Atributos: `_datos`, `_front` (`0`), `_rear` (`-1`) y `_count` (`0`).
- `Insertar`: si `_count == capacidad` lanza error; si no, `_rear = (_rear + 1) % capacidad`, guarda el dato y `_count++`.
- `Extraer`: si `_count == 0` lanza error; si no, toma `_datos[_front]`, lo limpia, `_front = (_front + 1) % capacidad` y `_count--`.
- `EstaVacia`: `_count == 0`. `EstaLlena`: `_count == capacidad`.
- El contador `_count` evita la ambigüedad entre cola llena y vacía (en ambos casos `front` y `rear` quedan contiguos).

## 8. Interfaz gráfica

### 8.1 `MainForm`
Contiene una etiqueta superior con los datos del alumno y un `TabControl` con tres pestañas. En el constructor llama a `Configurar` de cada panel indicando qué estructura crear y los textos de los botones (Push/Pop/Peek o Enqueue/Dequeue/Front).

### 8.2 `PanelEstructura`
| Control | Uso |
|---|---|
| `txtDato` | Dato a insertar (Enter también inserta). |
| `numCapacidad` + `btnCrear` | Cambia el tamaño del arreglo (1 a 20) y crea la estructura nueva. |
| `btnInsertar`, `btnExtraer`, `btnVer` | Operaciones principales. |
| `btnEstaVacia`, `btnEstaLlena` | Consultan isEmpty / isFull. |
| `btnReiniciar` | Limpia la estructura. |
| `lstArreglo` | Muestra cada posición del arreglo y sus punteros. |
| `lstRegistro` | Historial de acciones y errores con hora. |
| `lblPunteros` | Valores actuales de top / front / rear / count. |

Métodos privados importantes: `CrearEstructura()`, `Refrescar()` (redibuja arreglo y punteros) y `Registrar(string)` (agrega un mensaje al historial).

## 9. Cómo editar el diseño
Los archivos `*.Designer.cs` los genera el Diseñador de Visual Studio. Para cambiar la apariencia, abrir `MainForm.cs` o `PanelEstructura.cs` en vista Diseño y modificar los controles con el ratón o el panel de Propiedades. No es necesario editar el código a mano.

## 10. Casos de prueba sugeridos

| # | Estructura | Pasos | Resultado esperado |
|---|---|---|---|
| 1 | Pila | Push 10, 20, 30; Pop | Sale 30; top baja a 1. |
| 2 | Pila | Llenar (tamaño 5) y Push extra | Error de desbordamiento. |
| 3 | Pila | Pop con la pila vacía | Error de subdesbordamiento. |
| 4 | Cola simple | Enqueue A, B, C; Dequeue | Sale A; front pasa a 1. |
| 5 | Cola simple | Llenar, Dequeue dos veces, Enqueue | Error: rear está al final (no reutiliza espacio). |
| 6 | Cola circular | Llenar, Dequeue dos veces, Enqueue | Funciona; rear regresa a la posición 0. |
| 7 | Cola circular | Llenar y Enqueue extra | Error de desbordamiento. |
