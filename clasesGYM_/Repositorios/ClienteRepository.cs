using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace clasesGYM_.Repositorios
{
    public class ClienteRepository
    {
        // MÉTODO: Agregar cliente
        public static void AgregarCliente(Cliente cliente)
        {
            using (var context = new AplicationDbContext())
            {
                // Verificar si ya existe un cliente con el mismo DNI
                var existente = context.Clientes.FirstOrDefault(c => c.Dni == cliente.Dni);
                if (existente != null)
                {
                    throw new InvalidOperationException($"Ya existe un cliente con el DNI '{cliente.Dni}'");
                }
                
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
        }

        // MÉTODO: Obtener cliente por ID
        public static Cliente ObtenerCliente(int clienteId)
        {
            using (var context = new AplicationDbContext())
            {
                return context.Clientes.Find(clienteId);
            }
        }

        // MÉTODO: Obtener todos los clientes
        public static List<Cliente> ObtenerClientes()
        {
            using (var context = new AplicationDbContext())
            {
                return context.Clientes.ToList();
            }
        }

        // MÉTODO: Actualizar datos del cliente
        public static void ActualizarCliente(Cliente cliente)
        {
            using (var context = new AplicationDbContext())
            {
                var clienteExistente = context.Clientes.Find(cliente.Id);
                if (clienteExistente != null)
                {
                    clienteExistente.Nombre = cliente.Nombre;
                    clienteExistente.Apellido = cliente.Apellido;
                    clienteExistente.Direccion = cliente.Direccion;
                    clienteExistente.Telefono = cliente.Telefono;
                    context.SaveChanges();
                }
            }
        }

        // MÉTODO: Eliminar cliente
        public static void EliminarCliente(int clienteId)
        {
            using (var context = new AplicationDbContext())
            {
                var cliente = context.Clientes.Find(clienteId);
                if (cliente != null)
                {
                    context.Clientes.Remove(cliente);
                    context.SaveChanges();
                }
            }
        }
    }
}
