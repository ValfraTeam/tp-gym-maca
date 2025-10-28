# Sistema de Gestión de Gimnasio

## 📋 Descripción del Proyecto

Este es un sistema de gestión para un gimnasio desarrollado en C# con arquitectura en capas. El sistema permite administrar clientes, suscripciones, clases, pagos y generar reportes.

## 🚀 Tecnologías Utilizadas

- **.NET 8.0** - Framework de desarrollo
- **C#** - Lenguaje de programación
- **Windows Forms** - Interfaz de usuario
- **Entity Framework Core** - ORM para acceso a datos
- **SQL Server** - Base de datos

## 🏗️ Arquitectura del Proyecto

El proyecto está estructurado siguiendo los principios de **Clean Architecture** con separación clara de responsabilidades en 4 capas principales:

### 📁 Estructura de Carpetas

```
TP_GYM_Grupo4-main/
├── Gym.sln                          # Archivo de solución de Visual Studio
└── src/
    ├── Gym.Domain/                   # Capa de Dominio
    │   ├── Entities/                 # Entidades del negocio
    │   └── Interfaces/               # Interfaces de repositorios
    ├── Gym.Application/              # Capa de Aplicación
    │   ├── Services/                 # Servicios de aplicación
    │   └── ServiceContainer.cs       # Gestión de dependencias
    ├── Gym.Infrastructure/           # Capa de Infraestructura
    │   ├── Data/                     # Contexto de base de datos
    │   └── Repositories/             # Implementaciones de repositorios
    └── Gym.Presentation/             # Capa de Presentación
        ├── Forms/                    # Formularios Windows Forms
        └── Program.cs                # Punto de entrada de la aplicación
```

### 🏛️ Capas de la Arquitectura

#### 1. **Gym.Domain** - Capa de Dominio
**Propósito**: Contiene la lógica de negocio y las entidades principales.

**Contenido**:
- **Entities/**: Entidades del dominio
  - `Cliente.cs` - Información de los clientes del gimnasio
  - `Suscripcion.cs` - Planes de suscripción disponibles
  - `SuscripcionCliente.cs` - Relación entre clientes y suscripciones
  - `Clase.cs` - Clases disponibles en el gimnasio
  - `Pago.cs` - Pagos realizados por los clientes
  - `Administrador.cs` - Usuarios administradores del sistema

- **Interfaces/**: Contratos para repositorios
  - `IClienteRepository.cs` - Operaciones AMB  para clientes
  - `ISuscripcionRepository.cs` - Operaciones AMB para suscripciones
  - `ISuscripcionClienteRepository.cs` - Operaciones para relación cliente-suscripción
  - `IClaseRepository.cs` - Operaciones AMB para clases
  - `IPagoRepository.cs` - Operaciones para pagos

#### 2. **Gym.Application** - Capa de Aplicación
**Propósito**: Contiene la lógica de aplicación y casos de uso.

**Contenido**:
- **Services/**: Servicios de aplicación
  - `ClienteService.cs` - Lógica de negocio para gestión de clientes
  - `SuscripcionService.cs` - Lógica para gestión de suscripciones
  - `SuscripcionClienteService.cs` - Lógica para relación cliente-suscripción
  - `ClaseService.cs` - Lógica para gestión de clases
- `ServiceContainer.cs` - Contenedor de inyección de dependencias

#### 3. **Gym.Infrastructure** - Capa de Infraestructura
**Propósito**: Implementa el acceso a datos y servicios externos.

**Contenido**:
- **Data/**: 
  - `ApplicationDbContext.cs` - Contexto de Entity Framework Core
- **Repositories/**: Implementaciones concretas de repositorios
  - `ClienteRepository.cs` - Implementación del repositorio de clientes
  - `SuscripcionRepository.cs` - Implementación del repositorio de suscripciones
  - `SuscripcionClienteRepository.cs` - Implementación del repositorio de relación cliente-suscripción
  - `ClaseRepository.cs` - Implementación del repositorio de clases
  - `PagoRepository.cs` - Implementación del repositorio de pagos

#### 4. **Gym.Presentation** - Capa de Presentación
**Propósito**: Interfaz de usuario Windows Forms.

**Contenido**:
- **Forms/**: Formularios organizados por módulos
  - **Cliente/**: Gestión de clientes (Alta, Modificación, Eliminación)
  - **Suscripcion/**: Gestión de suscripciones (Alta, Baja, Modificación)
  - **Clases/**: Gestión de clases
  - **Pago/**: Gestión de pagos
  - **Reportes/**: Generación de reportes
- `Inicio.cs` - Formulario principal de inicio
- `Menu.cs` - Menú principal del sistema
- `Program.cs` - Punto de entrada de la aplicación

## 🗄️ Base de Datos

El sistema utiliza **SQL Server** con **Entity Framework Core** para el acceso a datos.

### Configuración de Base de Datos
- **Servidor**: localhost,1433
- **Base de datos**: SistemaGym

### Entidades Principales y Relaciones

1. **Cliente** ↔ **SuscripcionCliente** ↔ **Suscripcion**
   - Relación muchos a muchos entre clientes y suscripciones
   - Tabla intermedia `SuscripcionClientes` con fechas de inicio y fin

2. **Cliente** → **Pago**
   - Un cliente puede tener múltiples pagos

3. **Clase**
   - Entidad independiente para las clases del gimnasio (NO HAY RELACIONES)

## 📋 Funcionalidades Principales

### Gestión de Clientes
- ✅ Alta de nuevos clientes
- ✅ Modificación de datos de clientes
- ✅ Eliminación lógica de clientes
- ✅ Búsqueda por DNI
- ✅ Listado de todos los clientes activos

### Gestión de Suscripciones
- ✅ Alta de nuevas suscripciones
- ✅ Baja de suscripciones (eliminación lógica)
- ✅ Modificación de suscripciones
- ✅ Asignación de suscripciones a clientes
- ✅ Control de fechas de inicio y fin
- ✅ Validación de suscripciones activas

### Gestión de Clases
- ✅ Alta de nuevas clases
- ✅ Modificación de clases existentes
- ✅ Eliminación lógica de clases
- ✅ Gestión de horarios y capacidad

### Gestión de Pagos
- ✅ Registro de pagos
- ✅ Historial de pagos por cliente

### Reportes
- ✅ Reporte de clientes
- ✅ Reporte de ganancias
- ✅ Estadísticas del gimnasio

## 🗑️ Flujo de Eliminación Lógica

El sistema implementa **eliminación lógica** en lugar de eliminación física para preservar la integridad de los datos y permitir auditoría completa.

### 🔄 Proceso de Eliminación Lógica

```
Usuario → Form → Service → Repository → Database
   ↓       ↓       ↓         ↓           ↓
Eliminar → Eliminar → Eliminar → Desactivar → EstaActivo = false
```

### 📋 Entidades con Eliminación Lógica

Todas las entidades principales incluyen el campo `EstaActivo`:

- **Cliente**: `public bool EstaActivo { get; set; } = true;`
- **Suscripcion**: `public bool EstaActivo { get; set; } = true;`
- **Clase**: `public bool EstaActivo { get; set; } = true;`

### 🎯 Comportamiento del Sistema

#### Al Eliminar un Registro:
1. **Usuario hace clic en "Eliminar"** en el formulario
2. **Formulario llama al servicio** (`EliminarCliente()`, `EliminarSuscripcion()`, etc.)
3. **Servicio llama al repositorio** (`Desactivar()`)
4. **Repositorio marca** `EstaActivo = false` en la base de datos
5. **Registro se mantiene** en la base de datos pero aparece como "eliminado"

#### Al Listar Registros:
- **Servicios devuelven solo registros activos** (`EstaActivo = true`)
- **Los registros "eliminados" no aparecen** en los listados normales
- **Los datos se preservan** para auditoría y reportes históricos

### ✅ Beneficios de la Eliminación Lógica

- **📊 Preservación de Datos**: Los registros eliminados se mantienen en la base de datos
- **🔍 Auditoría Completa**: Se puede rastrear todo el historial de operaciones
- **📈 Reportes Históricos**: Los reportes pueden incluir datos de registros "eliminados"
- **🔄 Recuperación**: Los datos pueden ser reactivados si es necesario
- **🛡️ Integridad**: No se pierden relaciones con otros datos
- **📋 Cumplimiento**: Facilita el cumplimiento de regulaciones de retención de datos

### 🔧 Implementación Técnica

#### Interfaces de Repositorio:
```csharp
public interface IClienteRepository
{
    void Eliminar(int id);        // Eliminación física (mantenido para casos especiales)
    void Desactivar(int id);      // Eliminación lógica (usado por defecto)
    List<Cliente> ObtenerActivos(); // Solo registros activos
}
```

#### Servicios:
```csharp
public void EliminarCliente(int id)
{
    _clienteRepository.Desactivar(id); // Usa eliminación lógica
}
```

#### Repositorios:
```csharp
public void Desactivar(int id)
{
    var cliente = _context.Clientes.Find(id);
    if (cliente != null)
    {
        cliente.EstaActivo = false; // Marca como inactivo
        _context.SaveChanges();
    }
}
```

### Instalación de Entity Framework Core Tools
```bash
dotnet tool install --global dotnet-ef
```

## 🗄️ Configuración de Base de Datos y Migraciones

### Configuración de Conexión
El proyecto está configurado para usar **SQL Server** en Windows con la siguiente cadena de conexión:
```csharp
"Server=localHost;Database=SistemaGym_;Trusted_Connection=True;TrustServerCertificate=True;"
```

### Pasos para Crear y Aplicar Migraciones

### Comandos Útiles para Migraciones

#### Limpiar Base de Datos
```sql
-- Conectar a SQL Server y ejecutar:
DROP DATABASE IF EXISTS SistemaGym_;
CREATE DATABASE SistemaGym_;
```
- o directamente eliminen desde su SQL SERVER la BD

#### Verificar Migraciones Aplicadas
```bash
dotnet ef migrations list --project src/Gym.Infrastructure
```

#### Eliminar Última Migración (Si hay errores)
```bash
dotnet ef migrations remove --project src/Gym.Infrastructure
```

#### Hacer en Windows
```bash
# 1. Navegar al directorio del proyecto
cd "la raiz del proyecto"

# 2. Limpiar el proyecto
dotnet clean

# 3. Compilar el proyecto
dotnet build

# 4. Crear migración
dotnet ef migrations add InitialCreate --project src/Gym.Infrastructure --startup-project src/Gym.Presentation

# 5. Aplicar migración- con esto actualizan la BD
dotnet ef database update --project src/Gym.Infrastructure --startup-project src/Gym.Presentation
```

## 🚀 Pasos para Ejecutar el Proyecto

1. **Clonar el repositorio** No hace falta hacerlo si ya lo clonaron antes
   ```bash
   git clone [URL_DEL_REPOSITORIO]
   cd TP_GYM_Grupo4-main
   ```

2. **Configurar la base de datos** 
   - Asegúrate de que SQL Server esté ejecutándose
   - Ejecuta las migraciones siguiendo los pasos anteriores

3. **Compilar el proyecto**
   ```bash
   dotnet build
   ```

4. **Ejecutar la aplicación**
   ```bash
   dotnet run --project src/Gym.Presentation
   ```

## 📝 Notas de Desarrollo

- El proyecto sigue las convenciones de nomenclatura de C#
- Se implementa validación de datos en la capa de aplicación
- Las relaciones de base de datos están configuradas con Entity Framework
- La interfaz de usuario utiliza Windows Forms con diseño responsivo
- Se implementa eliminación lógica para preservar la integridad de los datos

## 👥 Equipo de Desarrollo

**Grupo 4** - Proyecto de Sistema de Gestión de Gimnasio

---

*Este README proporciona una visión general completa de la estructura y funcionamiento del sistema de gestión de gimnasio.*