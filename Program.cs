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

void ImprimirLista(List<string> listaParaImprimir){
  // Bucle foreach para iterar sobre los elementos de la lista
  foreach(string elemento in listaParaImprimir) Console.WriteLine(elemento);
}