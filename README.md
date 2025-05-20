# Kata-CompositePattern

**Kata 2: Menú de Restaurante**
Problema
Crea un sistema para representar un menú de restaurante. Cada elemento del menú tiene un nombre y un precio. Los menús pueden contener submenús y elementos individuales.

Instrucciones
Crea una interfaz MenuComponent con métodos getPrice() y showDetails().
Implementa una clase MenuItem para representar un elemento individual.
Implementa una clase Menu para representar un menú que contenga otros MenuComponent.
En el cliente, crea un menú con submenús y calcula el precio total.
Salida Esperada
Elemento: Pizza, Precio: 10
Elemento: Ensalada, Precio: 5 
Menú: Almuerzo, Precio Total: $15

**Kata 4: Sistema de Productos**
Problema
Crea un sistema para representar productos y paquetes de productos. Cada producto tiene un nombre y un precio. Los paquetes pueden contener productos y otros paquetes.

Instrucciones
Crea una interfaz ProductComponent con métodos getPrice() y showDetails().
Implementa una clase Product para productos individuales.
Implementa una clase ProductPackage para paquetes de productos.
En el cliente, crea una estructura de productos y paquetes y calcula el precio total.
Salida Esperada
Producto: Laptop, Precio: 1000
Producto: Mouse, Precio: 50
Paquete: Oficina, Precio Total: $1050
