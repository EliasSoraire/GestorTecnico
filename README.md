# GESTOR TECNICO

# FASE 2 - ABMs y conexion (3 dias)

OBJETIVO: Tener los formularios basicos conectados a la bdd y funcionando

## | ELIAS | Clientes: ABM + busqueda

    - Crear formulario para agregar, editar y eliminar clientes
    - Agregar campos: DNI, nombre, apellido, telefono, direccion y email
    - Implementar busqueda por DNI y nombre
    - Validar que no se ingresen duplicados o campos vacios

## | MATIAS | Productos: ABM + listado

    - Crear formulario para cargar productos con nombre, tipo, modelo, precio y stock
    - Implementar edicion y eliminacion
    - Mostrar los productos en un dgv con filtros por nombre o tipo
    - Validar stock numerico, precio validos y campos obligatorios

## | GASTON | Reparaciones: Alta + listado simple 

    - Formulario para registrar reparaciones basicas:
        - Cliente (seleccion)
        - Tipo de equipo, modelo, descripcion del problema, precio estimado
    - Mostrar listado de reparaciones con filtros 
    - Asegurarse de que se relacione bien con cliente

# TESTEO
    - Cargar datos de prueba: Clientes, productos y reparaciones
    - Verificar que el dgv se actualice
    - Buscar cliente y que traiga resultados correctos
    - Probar validaciones de campos vacios y repetidos 
