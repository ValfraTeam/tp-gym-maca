-- 🏋️ CONSULTAS PARA SISTEMA GYM
-- Base de datos: SistemaGym

-- 1. Ver todos los clientes
SELECT * FROM Clientes;

-- 2. Ver todas las suscripciones
SELECT * FROM Suscripciones;

-- 3. Ver relaciones N:M (Clientes con sus Suscripciones)
SELECT 
    c.Id as ClienteId,
    c.Nombre, 
    c.Apellido, 
    s.Nombre as Suscripcion,
    s.Precio,
    sc.FechaInicio,
    sc.FechaFin,
    CASE 
        WHEN GETDATE() BETWEEN sc.FechaInicio AND sc.FechaFin THEN 'ACTIVA'
        ELSE 'VENCIDA'
    END as Estado
FROM Clientes c 
JOIN SuscripcionClientes sc ON c.Id = sc.ClienteId 
JOIN Suscripciones s ON sc.SuscripcionId = s.Id;

-- 4. Ver solo suscripciones activas
SELECT 
    c.Nombre + ' ' + c.Apellido as Cliente,
    s.Nombre as Suscripcion,
    sc.FechaInicio,
    sc.FechaFin,
    DATEDIFF(day, GETDATE(), sc.FechaFin) as DiasRestantes
FROM Clientes c 
JOIN SuscripcionClientes sc ON c.Id = sc.ClienteId 
JOIN Suscripciones s ON sc.SuscripcionId = s.Id
WHERE GETDATE() BETWEEN sc.FechaInicio AND sc.FechaFin;

-- 5. Contar registros por tabla
SELECT 'Clientes' as Tabla, COUNT(*) as Registros FROM Clientes
UNION ALL
SELECT 'Suscripciones', COUNT(*) FROM Suscripciones
UNION ALL
SELECT 'SuscripcionClientes', COUNT(*) FROM SuscripcionClientes;
