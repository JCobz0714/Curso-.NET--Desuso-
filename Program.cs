/*
// Declaracion basica de un array
string[] personas = { "Juan", "Maria", "Pedro", "Ana"};

// Declaracion List Collection
// Dentro de la notacion diamante, se ingresa el tipo de dato
// que la lista va a contener
List<string> stringList = new List<string>();

// Agregar data a la List desde un array string[]
stringList.AddRange(personas);

// Agregar un solo elemento a la List
stringList.Add("Luis");

// Cuantos elementos tiene una lista (.Count)
Console.WriteLine($"La lista stringList tiene {stringList.Count} elementos");

// Metodo para imprimir todos los elementos de la lista
ImprimirLista(stringList);

// Eliminar un elemento de la lista
// Entre parentesis va la posicion del elemento que se desea eliminar
stringList.RemoveAt(3);

// Si quisiera eliminar un valor en especifico
stringList.Remove("Maria");

// Organizar los elementos de una lista (en este caso en orden alfabetico)
stringList.Sort();
  
void ImprimirLista(List<string> listaParaImprimir){
  // Bucle foreach para iterar sobre los elementos de la lista
  foreach(string elemento in listaParaImprimir) Console.WriteLine(elemento);
}

//Retorna true o false si el elemento existe en la lista
stringList.Contains("Javier");

//Buscar elementos en la lista que cumplan con la condicion dada
// la x de la expresion lambda representa el valor que va a tomar de la lista para
// la comparacion de la condicion
stringList.Exists(x => x.Length > 10);

//Buscar un elemento en la lista que contenga un caracter en especifico
//en este caso, que empiece con la letra "v"
stringList.Find(x => x.StartsWith("v"));
*/

/*
string[] canciones = {
"Passionfruit",
"Genero rural",
"Anestesia local 1",
"Anestesia local 2",
"Euphoria",
"Not like us",
"Type shit",
"Like that",
"Accordion",
"Billie jean"
};

//Creando una LinkedList
LinkedList<string> cancionesLinkedList = new LinkedList<string>(canciones);

//Agregar un elemento al inicio de la LinkedList
cancionesLinkedList.AddFirst("Primera cancion");

//Agregar un elemento al final de la LinkedList
cancionesLinkedList.AddLast("Ultima cancion");

//Imprimir toda la lista
foreach(string str in cancionesLinkedList){
  Console.WriteLine(str);
};

//Buscar el primer elemento de la LinkedList
//El signo de admiracion es para denotar que el valor que va a recibir no es nulo
LinkedListNode<string> primerElemento = cancionesLinkedList.First!;

//Buscar el primer elemento de la LinkedList
LinkedListNode<string> ultimoElemento = cancionesLinkedList.Last!;

//El ".Value" es para que me muestre el valor que almacena el nodo
Console.WriteLine($"Primera cancion: {primerElemento.Value}, ultima cancion {ultimoElemento.Value}");

//Los elementos pueden ser agregados o eliminados dependiendo de un elemento existente
//Agregando un elemento a la LinkedList despues de un valor especifico
cancionesLinkedList.AddAfter(primerElemento, "Segunda cancion");

//Agregando un elemento a la LinkedList Antes de un valor especifico
cancionesLinkedList.AddBefore(primerElemento, "Cancion previa");

//Para eliminar el primer elemento de la LinkedList
cancionesLinkedList.RemoveFirst();

//Para eliminar el ultimo elemento de la LinkedList
cancionesLinkedList.RemoveLast();
  
Console.WriteLine("Lista de canciones actualizada");

foreach(string str in cancionesLinkedList){
  Console.WriteLine(str);
};

//Buscar elementos en la LinkedList con el metodo Contains (Retorna true o false)
Console.WriteLine($"La cancion 'Passionfruit' esta en la lista: {cancionesLinkedList.Contains("Passionfruit")}");

//Accediendo a los datos con los metodos Next and Previous
Console.WriteLine($"La cancion que sigue despues de la primera es: {cancionesLinkedList.First!.Next!.Value}");

Console.WriteLine($"La cancion anterior a la ultima cancion es: {cancionesLinkedList.Last!.Previous!.Value}");
*/

//Crear un stack collection
Stack<string> miStack = new Stack<string>();

//Insertar elementos en el stack
miStack.Push("Uno");
miStack.Push("Dos");
miStack.Push("Tres");
miStack.Push("Cuatro");
miStack.Push("Cinco");
miStack.Push("Seis");

//Imprimir el contenido del stack
foreach (string s in miStack){
  Console.WriteLine(s);
}

//Mostrar el primer elemento del stack (o el ultimo elemento agregado)
string miPrimerElemento = miStack.Peek();
Console.WriteLine($"Este es mi primer elemento: {miPrimerElemento}");

//Mostrar y eliminar el primer elemento del stack
string elementoEliminado = miStack.Pop();
Console.WriteLine($"Este elemento ha sido eliminado: {elementoEliminado}");

foreach (string s in miStack){
  Console.WriteLine(s);
}

//Buscamos elementos con el metodo contains
var existeElemento = miStack.Contains("Dos");
Console.WriteLine($"Existe el elemento en la coleccion?: {existeElemento}");