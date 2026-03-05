using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{

    public abstract class MaterialFactory
    {
        public abstract Guia CrearGuia();

        public abstract Examen CrearExamen();
    
    
    }
    public abstract class Guia
    {
        public abstract  void Mostrar();

    }
    public abstract class Examen
    {
        public abstract void Aplicar();

    }

    public class ExamenEnPapel : Examen 
    {
        public override void Aplicar()
        {
            Console.WriteLine("Se Aplica examen en papel");
        }
    }

    public class GuiaImpresa : Guia
    {
        public override void Mostrar()
        {
            Console.WriteLine("Se Aplica guia impresa");
        }
    }

    public class GuiaPDF : Guia
    {
        public override void Mostrar()
        {
            Console.WriteLine("Se Aplica guia PDF");
        }
    }

    public class ExamenOnline : Examen
    {
        public override void Aplicar()
        {
            Console.WriteLine("Se Aplica examen en linea");
        }
    }

    

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

    public class MaterialPresencialFactory: MaterialFactory
    {
        public override Guia CrearGuia() {  return new GuiaImpresa(); }

        public override Examen CrearExamen() { return new ExamenEnPapel(); }


    }
    public class MaterialVirtualFactory : MaterialFactory
    {
        public override Guia CrearGuia() { return new GuiaPDF(); }

        public override Examen CrearExamen() { return new ExamenOnline(); }


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

    internal class Program
    {
        static void Main(string[] args)
        {
            MaterialFactory fabrica;
            fabrica = new MaterialPresencialFactory();

            Guia guia = fabrica.CrearGuia();
            Examen examen = fabrica.CrearExamen();

            guia.Mostrar();
            examen.Aplicar();

            Console.WriteLine("");

            fabrica = new MaterialVirtualFactory();

            guia = fabrica.CrearGuia();
            examen = fabrica.CrearExamen();

            guia.Mostrar();
            examen.Aplicar();

            fabrica = new MaterialHibridoFactory();

            guia = fabrica.CrearGuia();
            examen = fabrica.CrearExamen();

            guia.Mostrar();
            examen.Aplicar();


            Console.ReadKey();




        }
    }
}
