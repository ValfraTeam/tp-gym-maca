using Gym.Domain.Interfaces;
using Gym.Infrastructure.Repositories;
using Gym.Infrastructure.Data;
using Gym.Application.Services;

namespace Gym.Application
{
    public static class ServiceContainer
    {
        private static ApplicationDbContext? _context;
        
        public static ApplicationDbContext Context
        {
            get
            {
                if (_context == null)
                {
                    _context = new ApplicationDbContext();
                }
                return _context;
            }
        }

        // Repositories
        public static IClienteRepository ClienteRepository => new ClienteRepository(Context);
        public static ISuscripcionRepository SuscripcionRepository => new SuscripcionRepository(Context);
        public static ISuscripcionClienteRepository SuscripcionClienteRepository => new SuscripcionClienteRepository(Context);
        public static IClaseRepository ClaseRepository => new ClaseRepository(Context);
        public static IPagoRepository PagoRepository => new PagoRepository(Context);

        // Services
        public static ClienteService ClienteService => new ClienteService(ClienteRepository, SuscripcionClienteRepository);
        public static SuscripcionClienteService SuscripcionClienteService => new SuscripcionClienteService(SuscripcionClienteRepository);
        public static SuscripcionService SuscripcionService => new SuscripcionService(SuscripcionRepository, SuscripcionClienteRepository);
        public static ClaseService ClaseService => new ClaseService(ClaseRepository);
    }
}
