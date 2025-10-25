using System;
using clasesGYM_.Repositorios;
using clasesGYM_; // para acceder a las entidades

namespace frontGYM_
{
	internal static class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ejemplo de uso del backend clasesGYM_:");
			
			// Ejemplo: crear instancia de repositorio
			var planRepo = new SuscripcionRepository();
			
			try
			{
				// Aquí puedes usar los métodos del repositorio
				Console.WriteLine("Repositorio inicializado correctamente.");
				
				// TODO: Agregar lógica real según tus necesidades
				// Ejemplo: planRepo.ObtenerPlanes();
				// Ejemplo: planRepo.CrearPlan(nuevoPlan);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error al usar el backend: {ex.Message}");
			}
		}
	}
}