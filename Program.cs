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