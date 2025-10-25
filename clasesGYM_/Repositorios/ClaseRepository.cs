using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesGYM_.Repositorios
{
    public class ClaseRepository
    {
        public static void AgregarClase(Clase clase)
        {
            using (var context = new AplicationDbContext())
            {
                context.Clases.Add(clase);
                context.SaveChanges();
            }
        }
        public static List<Clase> ObtenerClases()
        {
            using (var context = new AplicationDbContext())
            {
                return context.Clases.ToList();
            }
        }
        public static void EliminarClase(int id)
        {
            using (var context = new AplicationDbContext())
            {
                var clase = context.Clases.Find(id);
                if (clase != null)
                {
                    context.Clases.Remove(clase);
                    context.SaveChanges();
                }
            }
        }
        public static void ActualizarClase(Clase clase)
        {
            using (var context = new AplicationDbContext())
            {
                context.Clases.Update(clase);
                context.SaveChanges();
            }
        }
    }
}
