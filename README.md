# Sistema de Gestión de Gimnasio

## Descripción del Proyecto

Este es un sistema de gestión para un gimnasio desarrollado en C# con arquitectura en capas. El sistema permite administrar clientes, suscripciones, clases, pagos y generar reportes.

## Arquitectura del Proyecto

El proyecto está estructurado siguiendo los principios de capas con separación clara de responsabilidades en 4 capas principales:

### 📁 Estructura de Carpetas

```
TP_GYM_Grupo4-main/
├── Gym.sln                          # Archivo de solución de Visual Studio
└── src/
    ├── Gym.Domain/                   # Capa de Dominio
    │   ├── Entities/                 # Entidades del negocio
    │   └── Interfaces/               # Interfaces de repositorios
    ├── Gym.Application/              # Capa de Aplicación
    │   └── Services/                 # Servicios de aplicación
    ├── Gym.Infrastructure/           # Capa de Infraestructura
    │   ├── Data/                     # Contexto de base de datos
    │   └── Repositories/             # Implementaciones de repositorios
    └── Gym.Presentation/             # Capa de Presentación
        ├── Forms/                    # Formularios Windows Forms
        └── Program.cs                # Punto de entrada de la aplicación
```

## 🏗️ Capas de la Arquitectura

### 1. **Gym.Domain** - Capa de Dominio
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
  - `IClienteRepository.cs` - Operaciones CRUD para clientes
  - `ISuscripcionRepository.cs` - Operaciones para suscripciones
  - `ISuscripcionClienteRepository.cs` - Operaciones para relación cliente-suscripción
  - `IClaseRepository.cs` - Operaciones para clases
  - `IPagoRepository.cs` - Operaciones para pagos

### 2. **Gym.Application** - Capa de Aplicación
**Propósito**: Contiene la lógica de aplicación y casos de uso.

**Contenido**:
- **Services/**: Servicios de aplicación
  - `ClienteService.cs` - Lógica de negocio para gestión de clientes
  - `SuscripcionService.cs` - Lógica para gestión de suscripciones
  - `SuscripcionClienteService.cs` - Lógica para relación cliente-suscripción
- `ServiceContainer.cs` - Contenedor de inyección de dependencias

### 3. **Gym.Infrastructure** - Capa de Infraestructura
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
  - `PlanRepository.cs` - Implementación del repositorio de planes

### 4. **Gym.Presentation** - Capa de Presentación
**Propósito**: Interfaz de usuario Windows Forms.

**Contenido**:
- **Forms/**: Formularios organizados por módulos
  - **Cliente/**: Gestión de clientes (Alta, Modificación, Eliminación)
  - **Suscripcion/**: Gestión de suscripciones
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
   - Entidad independiente para las clases del gimnasio

## 🚀 Tecnologías Utilizadas

- **.NET 8.0** - Framework de desarrollo
- **C#** - Lenguaje de programación
- **Windows Forms** - Interfaz de usuario
- **Entity Framework Core** - ORM para acceso a datos
- **SQL Server** - Base de datos

## 📋 Funcionalidades Principales

### Gestión de Clientes
- ✅ Alta de nuevos clientes
- ✅ Modificación de datos de clientes
- ✅ Eliminación de clientes
- ✅ Búsqueda por DNI
- ✅ Listado de todos los clientes

### Gestión de Suscripciones
- ✅ Alta de nuevas suscripciones
- ✅ Asignación de suscripciones a clientes
- ✅ Control de fechas de inicio y fin
- ✅ Validación de suscripciones activas

### Gestión de Clases
- ✅ Alta de nuevas clases
- ✅ Modificación de clases existentes
- ✅ Gestión de horarios y capacidad

### Gestión de Pagos
- ✅ Registro de pagos
- ✅ Generación de facturas
- ✅ Historial de pagos por cliente

### Reportes
- ✅ Reporte de clientes
- ✅ Reporte de ganancias
- ✅ Estadísticas del gimnasio

## 🔧 Configuración del Proyecto

### Requisitos Previos
- Visual Studio 2022 o superior
- .NET 8.0 SDK
- SQL Server
- Entity Framework Core Tools

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

#### Opción 1: Crear Migración desde macOS (Recomendado)
```bash
# 1. Navegar al directorio del proyecto
cd TP_GYM_Grupo4-main

# 2. Limpiar el proyecto
dotnet clean

# 3. Crear migración (solo desde Infrastructure)
dotnet ef migrations add InitialCreate --project src/Gym.Infrastructure

# 4. Aplicar migración en Windows
dotnet ef database update --project src/Gym.Infrastructure --startup-project src/Gym.Presentation
```

#### Opción 2: Todo en Windows
```bash
# 1. Navegar al directorio del proyecto
cd TP_GYM_Grupo4-main

# 2. Limpiar el proyecto
dotnet clean

# 3. Compilar el proyecto
dotnet build

# 4. Crear migración
dotnet ef migrations add InitialCreate --project src/Gym.Infrastructure --startup-project src/Gym.Presentation

# 5. Aplicar migración
dotnet ef database update --project src/Gym.Infrastructure --startup-project src/Gym.Presentation
```

### Comandos Útiles para Migraciones

#### Limpiar Base de Datos (Si es necesario)
```sql
-- Conectar a SQL Server y ejecutar:
DROP DATABASE IF EXISTS SistemaGym_;
CREATE DATABASE SistemaGym_;
```

#### Verificar Migraciones Aplicadas
```bash
dotnet ef migrations list --project src/Gym.Infrastructure
```

#### Eliminar Última Migración (Si hay errores)
```bash
dotnet ef migrations remove --project src/Gym.Infrastructure
```

### Pasos para Ejecutar el Proyecto

1. **Clonar el repositorio**
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

## 🏛️ Patrones de Diseño Implementados

- **Repository Pattern**: Para abstraer el acceso a datos
- **Dependency Injection**: Para inyección de dependencias
- **Clean Architecture**: Separación clara de responsabilidades
- **Service Layer Pattern**: Para encapsular la lógica de negocio

## 📝 Notas de Desarrollo

- El proyecto sigue las convenciones de nomenclatura de C#
- Se implementa validación de datos en la capa de aplicación
- Las relaciones de base de datos están configuradas con Entity Framework
- La interfaz de usuario utiliza Windows Forms con diseño responsivo

## 👥 Equipo de Desarrollo

**Grupo 4** - Proyecto de Sistema de Gestión de Gimnasio

---

*Este README proporciona una visión general completa de la estructura y funcionamiento del sistema de gestión de gimnasio.*
