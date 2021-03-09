using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tarea_Libro

{
    class Libro
    {
        private string nombre;
        private int año;
        private List<Autor> autores = new List<Autor>();
        private Editorial editorial;
        public string Nombre { get => nombre; set => nombre = value; }
        public int Año { get => año; set => año = value; }
        public Libro(string nombre, int año, Editorial editorial)
        {
            this.nombre = nombre;
            this.año = año;
            this.editorial = editorial;

        }
        public void AgregarAutor(string nombre, string nacionalidad, int añodenacimiento)
        {
            autores.Add(new Autor(nombre, nacionalidad, añodenacimiento));
        }
 
        public void Imprime()
        {
            Console.WriteLine($"{nombre} , {año} ");
            foreach(Autor a in autores)
            {
                a.Imprime();
            }
            editorial.Imprime();
        }
    }
    class Autor
    {
        private string nombre;
        private string nacionalidad;
        private int añodenacimiento;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public int Añodenacimiento { get => añodenacimiento; set => añodenacimiento = value; }

        public Autor(string nombre, string nacionalidad, int añodenacimiento)
        {
            Nombre = nombre;
            Nacionalidad = nacionalidad;
            Añodenacimiento = añodenacimiento;
        }
        
        public void Imprime()
        {
            
            Console.WriteLine($"    {nombre} , {nacionalidad} , ({añodenacimiento})");
        }
    }

    class Editorial
    {
        private string nombre;
        private string pais;


        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
        public Editorial(string nombre, string pais)
        {
            Nombre = nombre;
            Pais = pais;

        }
        public void Imprime()
        {
            Console.WriteLine($"    {nombre} , {pais}");
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
            Libro l1 = new Libro("Los juegos del hambre", 2009, new Editorial("Océano","México"));
            l1.AgregarAutor("Suzanne Collins", "Hartford, Connecticut, Estados Unidos", 1962 );
            l1.Imprime();
                Console.WriteLine("Hasta la proxima");
            Console.ReadKey();

            }
        }
}

