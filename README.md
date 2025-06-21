# FASE 3 - FUNCIONES DE NEGOCIO (3 DIAS)

# OBJETIVO: Implementar ventas, pagos y entregas

# | ELIAS | Ventas: Carrito, stock y medios de pago

    - Formulario donde se agregan productos a un carrito
    - Seleccion de cantidad por producto
    - Calculo del total en tiempo real
    - Seleccion de medio de pago
    - Al confirmar, registar venta y descontar stock automaticamente
    - Validar que no se venda mas de lo que hay en stock

# | MATIAS | Pagos parciales en reparaciones

    - Agregar boto para registra pagos sobre una reparacion
    - Permitir cargar multiples pagos con distintos medios
    - Mostrar total abonado y saldo restante
    - Evitar que se pague mas del precio final

# | GASTON | Entrega de reparaciones + historial

    - Boton para marcar reparaciones como entregadas (solo si esta totalmente pagada)
    - Guardar fecha de entrega
    - Crear vista de historial de reparaciones y ventas por clientes

# TESTEO

    - Hacer venta con 3 productos y confirmar que el stock baje
    - Registrar 2 pagos parciales en una reparacion y validar saldo restante
    - Marcar como entregada una reparacion totalmente paga
    - Ver que el historial muestre todos los datos correctamente 
