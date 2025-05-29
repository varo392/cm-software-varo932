 Cambios 

 1-Sobre los items.sc 
    Se creo un contructor simple para limpiar sectores de memoria.
    Se creo un contructor sobre cargado con los parametros que son necesarios para su funcionamiento. 
    Se usaron en ambos contructores la etiqueta this, esta etiquitas evita la creacion de copias de variables ya que es un puntero de variable, evitando la duplicacion de espacio en la memoria ram y su vez garantizando la buenas practicas.
    Se creo la funcion de imprimir un item 
    

2- Se modifico el codigo eliminando el ciclo anterior donde habian mas de 100 lineas codigo.
    Se agrego la biblioteca System.Linq;
    La biblioteca enteriormente agregada, permite hacer consultas muchas mas precisas y mas compactas, por lo cual se eliminar el ciclo for, y se pasa a utilizar la consulta where, list y se modifica las opciones necesarias para cada caso especifico. 

3- Se modifico el Program.sc 
    Se cambio la asignacion de las variables a la hora de crear cada item ahora se hacer por contructos sobre cargados.
    Se crearon funciones para imprimir en pantalla 

