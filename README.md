# PruebMasivian
La API fue creado en Net Core, para resolver la prueba se tuvo en cuenta lo siguiente:
Encontre que el arbol binario es de tipo busqueda, esto indica que los valores mayores van hacia la izquierda y hacia la derecha los menores.

La api tiene 2 servicios :

1. Un servicio que se llama CrearArbol el cual recibe un arreglo que equivale al arbol que se desea crear.  El servicio retorna
   la creacíón del arbol e indica la posición de los numeros, (si estan en la derecha o en la izquiera).
   La forma de ingresar es http://Urlservidor/v1/ArbolBinario/CrearArbol+arreglo
2. Un servicio que se llama MostrarAncestroArreglo que recibe el mismo arreglo con el cual se creao el arbol mas los dos nodos y retorna 
   cual es el ancestro mas cercano. La forma de ingresar http://Urlservidor/v1/ArbolBinario/GetAncestroArreglo+arreglo-ValorNodo1-ValorNodo2


