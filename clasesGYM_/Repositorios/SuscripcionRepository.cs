using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace clasesGYM_.Repositorios
{
    public class SuscripcionRepository
    {
        // METODO: Crear nueva suscripcion en la base de datos
        public static void AgregarSuscripcion(Suscripcion suscripcion)
        {
            using (var context = new AplicationDbContext())
            {
                // Validar que el nombre no sea nulo o vacío
                if (string.IsNullOrWhiteSpace(suscripcion.Nombre))
                {
                    throw new ArgumentException("El nombre de la suscripción no puede estar vacío");
                }
                
                // Normalizar nombre a MAYÚSCULAS
                suscripcion.Nombre = suscripcion.Nombre.Trim().ToUpper();
                
                // Verificar si ya existe una suscripción con el mismo nombre (insensible a mayúsculas)
                var existente = context.Suscripciones.FirstOrDefault(s => s.Nombre.ToLower() == suscripcion.Nombre.ToLower());
                if (existente != null)
                {
                    throw new InvalidOperationException($"Ya existe una suscripción con el nombre '{existente.Nombre}'");
                }
                
                context.Suscripciones.Add(suscripcion);
                context.SaveChanges();
            }
        }
        
        // METODO: Obtener todas las suscripciones disponibles
        public static List<Suscripcion> ObtenerSuscripciones()
        {
            using (var context = new AplicationDbContext())
            {
                return context.Suscripciones.ToList();
            }
        }
        
        // METODO: Obtener una suscripcion especifica por su ID
        public static Suscripcion ObtenerSuscripcion(int suscripcionId)
        {
            using (var context = new AplicationDbContext())
            {
                return context.Suscripciones.Find(suscripcionId);
            }
        }
        
        // METODO: Eliminar una suscripcion de la base de datos por ID
        public static void EliminarSuscripcion(int id)
        {
            using (var context = new AplicationDbContext())
            {
                var suscripcion = context.Suscripciones.Find(id);
                if (suscripcion != null)
                {
                    context.Suscripciones.Remove(suscripcion);
                    context.SaveChanges();
                }
            }
        }
        
        // METODO: Actualizar los datos de una suscripcion existente
        public static void ActualizarSuscripcion(Suscripcion suscripcion)
        {
            using (var context = new AplicationDbContext())
            {
                var suscripcionExistente = context.Suscripciones.Find(suscripcion.Id);
                if (suscripcionExistente != null)
                {
                    suscripcionExistente.Nombre = suscripcion.Nombre;
                    suscripcionExistente.Precio = suscripcion.Precio;
                    context.SaveChanges();
                }
            }
        }

    }
}
