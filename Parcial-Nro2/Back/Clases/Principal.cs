using Back.ConeccionDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Principal
    {
        AppDbContext context = new AppDbContext();
        public void AltaProfesor(string nombre, string apellido, string email, long telefono)
        {
            Profesor profesor = new Profesor();
            profesor.Nombre = nombre;
            profesor.Apellido = apellido;
            profesor.Email = email; 
            profesor.Telefono = telefono;

            context.Profesores.Add(profesor);
            context.SaveChanges();
              
        }


        public void AltaCurso(string nombre, string descripcion, Profesor profesor)
        {
            Curso curso = new Curso();
            curso.Nombre = nombre;
            curso.Descripcion = descripcion;
            curso.Profesor = profesor;

            context.Cursos.Add(curso);
            context.SaveChanges();
        }


        public void AltaAlumno(string nombre, string apellido, long dni, DateTime fechaNaci)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = nombre;
            alumno.Apellido = apellido;
            alumno.DNI = dni;
            alumno.fechaNacimiento = fechaNaci;

            context.Alumnos.Add(alumno);
            context.SaveChanges();  
        }

        public void ModificarAlumno(Alumno alumnoMod, string nombre, string apellido, long dni, DateTime fechaNaci)
        {

            alumnoMod.Nombre = nombre;
            alumnoMod.Apellido = apellido;
            alumnoMod.DNI = dni;
            alumnoMod.fechaNacimiento = fechaNaci;

            context.Alumnos.Update(alumnoMod);
            context.SaveChanges();
        }

        public void EliminarAlumno(Alumno alumnoDelete)
        {
            context.Alumnos.Remove(alumnoDelete);
            context.SaveChanges();
        }


        public List<Alumno> GetAlumnos() 
        {
            var listaAlumnos = context.Alumnos.ToList();

            return listaAlumnos;
        }


        public List<Profesor> ObtenerProfesores()
        {
            var listaProf = context.Profesores.ToList();
            return listaProf;
        }
    }
}
