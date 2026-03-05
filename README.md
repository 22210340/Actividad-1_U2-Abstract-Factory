## Actividad-1_U2-Abstract-Factory

# REPORTE DE PRÁCTICA  

---

**TECNOLÓGICO NACIONAL DE MÉXICO**  
**INSTITUTO TECNOLÓGICO DE TIJUANA**

**SUBDIRECCIÓN ACADÉMICA**  
**DEPARTAMENTO DE SISTEMAS Y COMPUTACIÓN**

---

**SEMESTRE:**  
Enero – Junio 2025  

**CARRERA:**  
Ingeniería en Sistemas Computacionales  

**MATERIA:**  
Patrones de Diseño  

**DOCENTE:**  
Maribel Guerrero Luis  

**ALUMNO:**  
Kevin Jonathan Rivas Perez  

**PRÁCTICA:**  
Implementación del Patrón de Diseño Abstract Factory agregando Guía en Modalidad Híbrida (semipresencial)

**FECHA:**  
4 de marzo de 2026  


---

# 1. Introducción al patrón Abstract Factory

El patrón de diseño **Abstract Factory** pertenece a la categoría de **patrones creacionales**, los cuales se encargan de controlar la forma en que se crean los objetos dentro de un sistema. Su objetivo principal es proporcionar una interfaz para crear **familias de objetos relacionados o dependientes sin especificar sus clases concretas**.

Este patrón permite que el sistema sea más **flexible, escalable y fácil de mantener**, ya que desacopla la creación de los objetos de la lógica principal del programa. En lugar de instanciar directamente clases específicas, el programa utiliza una **fábrica abstracta** que define los métodos necesarios para crear los diferentes tipos de objetos.

El uso de Abstract Factory es especialmente útil cuando una aplicación debe soportar múltiples configuraciones o modalidades. En este caso, el patrón permite crear diferentes tipos de materiales educativos como **guías y exámenes**, dependiendo de la modalidad del curso, como presencial, virtual o híbrida.

Al utilizar este enfoque, el cliente del sistema puede cambiar la modalidad simplemente cambiando la fábrica utilizada, sin modificar la estructura general del programa. Esto mejora significativamente la **modularidad del software** y facilita la incorporación de nuevas variantes en el futuro.

---

# 2. Código Implementado

En esta práctica se implementó el patrón **Abstract Factory** utilizando el lenguaje **C#**. El sistema simula la generación de materiales académicos para diferentes modalidades de enseñanza.

Se definieron dos productos principales:

- **Guía**
- **Examen**

Posteriormente se implementaron diferentes versiones de estos productos para cada modalidad:

### Modalidad Presencial
- Guía Impresa  
- Examen en Papel  

### Modalidad Virtual
- Guía en PDF  
- Examen en Línea  

### Modalidad Híbrida
- Guía Híbrida  
- Examen Mixto  

Cada modalidad cuenta con su propia fábrica encargada de crear los objetos correspondientes.

A continuación se muestra el código implementado (Modalidad Hibrida):

```csharp
//
public class GuiaHibrida : Guia
{
    public override void Mostrar()
    {
        Console.WriteLine("Mostrando la guia en modalidad híbrida");
    }
}

public class ExamenMixto : Examen
{
    public override void Aplicar()
    {
        Console.WriteLine("Se aplica examen mixto");
    }
}

public class MaterialHibridoFactory : MaterialFactory
{
    public override Guia CrearGuia()
    {
        return new GuiaHibrida();
    }

    public override Examen CrearExamen()
    {
        return new ExamenMixto();
    }
}

fabrica = new MaterialHibridoFactory();

guia = fabrica.CrearGuia();
examen = fabrica.CrearExamen();

guia.Mostrar();
examen.Aplicar();
//
```

# 3. Conclucion
Este metodo permite comprender como pueden crearce diferentes familias de objetos sin depender de clases en especificas. Esta practica se basa en crear materiales educativos para diferentes modalidades, una de las principales ventajas observadas durante la implementación fue la facilidad para agregar nuevas modalidades sin modificar el código existente. Esto demuestra que el patrón Abstract Factory ayuda a mejorar la organización del código, la reutilización y la escalabilidad del sistema, permitiendo que el software pueda evolucionar fácilmente a medida que se agregan nuevas funcionalidades.

En conclusión, el uso de este patrón de diseño facilita la creación de sistemas más modulares, mantenibles y extensibles, características fundamentales en el desarrollo profesional de software.
