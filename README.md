# Trabajo Practico N° 6

## Ejercicio 1

- ¿Qué es la propiedad TabIndex? ¿Para qué se utiliza?  
    Libreria: System.Windows.Controls
    **Control.TabIndex Property** 
    La propiedad *TabIndex* de un control determina dónde se coloca en el orden de tabulación.  
    Es una propiedad que se utiliza para determinar el orden de navegación lógico en un dispositivo.


- ¿Cómo funciona el foco en un control en particular?  
    El orden de tabulación es el orden en el que un usuario mueve el *foco de un control* a otro presionando la tecla Tab. Cada formulario tiene su propio orden de tabulación. De forma predeterminada, el orden de tabulación es el mismo que el orden en el que creó los controles. La numeración por orden de tabulación comienza con cero.
    Alternativamente, el orden de tabulación se puede establecer en la ventana Propiedades usando la propiedad TabIndex .

     Para eliminar un control del orden de tabulación, establezca la propiedad **TabStop** del control en falso en la ventana Propiedades .  
     Un control cuya propiedad TabStop se ha establecido en falsetodavía mantiene su posición en el orden de tabulación, aunque el control se omite cuando recorre los controles con la tecla Tab. 

- ¿Qué son los eventos? ¿Cómo se utilizan los eventos del teclado?  
    Un **evento** es un mensaje enviado por un objeto para señalar la ocurrencia de una acción. La acción puede ser causada por la interacción del usuario, como un clic en un botón, o puede resultar de alguna otra lógica del programa, como cambiar el valor de una propiedad. El objeto que genera el evento se llama *remitente del evento* . El *remitente del evento* no sabe qué objeto o método recibirá (manejará) los eventos que genera. El evento suele ser miembro del remitente del evento.

    Los eventos se utilizan mucho en el diseño de la interfaz gráfica, ya que nos permiten obtener datos relativos a las acciones efectuadas por el usuario de la aplicación.

- Los eventos del teclado ( keyboard events ) se disparan cuando el usuario interactúa con el teclado.  
     El evento keydown ( literalmente tecla abajo ) se dispara cuando el usuario presiona una tecla y continua disparándose mientras el usuario mantiene la tecla presionada.

     El evento keypress ( literalmente tecla presionada ) se dispara cuando un cierto carácter esta tecleado, por ejemplo dentro de un elemento input. Sigue disparándose mientras el usuario mantiene la tecla presionada

     El evento keyup ( literalmente tecla arriba ) se dispara cuando el usuario deja de presionar ( suelta ) una  tecla.

    Probablemente la más importante propiedad de los eventos de teclado es la propiedad key que devuelve el valor de la tecla presionada.
