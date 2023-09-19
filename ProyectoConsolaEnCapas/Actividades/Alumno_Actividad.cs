using ProyectoEnCapas.Persistencia;
using ProyectoEnCapas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEnCapas.Actividades
{
    public class Alumno_Actividad
    {

        Alumno_Persistencia alumno_Persistencia = new Alumno_Persistencia();

        public bool Agregar(Alumno alumno) { 
            return alumno_Persistencia.Agregar(alumno);
        }

        public List<Alumno> Listar() {
            return alumno_Persistencia.Listar();
        }

        public Alumno BuscarAlumno(int legajo) {
            return alumno_Persistencia.BuscarAlumno(legajo);
        }

        public bool EliminarAlumno(int legajo) {
            return alumno_Persistencia.EliminarAlumno(legajo);
        }

      


    }
}
