using ProyectoEnCapas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEnCapas.Persistencia
{
    public class Alumno_Persistencia
    {
        public static List<Alumno> Alumnos = new List<Alumno>();

        public bool Agregar(Alumno alumno)
        {
            bool estado = false;
            if (alumno != null)
            {
                Alumnos.Add(alumno);
                estado = true;
            }
            return estado;
        }

        public List<Alumno> Listar()
        {

            return Alumnos;
        }




        public Alumno BuscarAlumno(int legajo)
        {

            Console.Clear();
            //LINQ
            return Alumnos.Where(x => x.legajo == legajo).FirstOrDefault();

        }

        public bool EliminarAlumno(int legajo)
        {
            bool seElimino = false;
            Alumno alumnoEncontrado = BuscarAlumno(legajo);
            if (alumnoEncontrado != null)
            {
                Alumnos.Remove(alumnoEncontrado);
                seElimino = true;

            }
            return seElimino;
        }

        

    }

    

}
