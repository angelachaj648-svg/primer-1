//Solicitar al usuario la cantidad n de números enteros y almacenarlos en un arreglo. Luego, recorrer el arreglo para calcular el promedio general. Después, mostrar en pantalla el promedio y listar únicamente los valores que están por encima del promedio. Finalmente, indicar cuántos números cumplen esa condición.

Console.Write("Ingrese la cantidad de números: ");
int n = int.Parse(Console.ReadLine());

int[] numeros = new int[n];
int suma = 0;


for (int i = 0; i < n; i++)
{
	Console.Write($"Número {i + 1}: ");
	numeros[i] = int.Parse(Console.ReadLine());
	suma += numeros[i];
}


double promedio = (double)suma / n;

Console.WriteLine($"El promedio es: {promedio}");


Console.WriteLine("Números por encima del promedio:");
int contador = 0;

for (int i = 0; i < n; i++)
{
	if (numeros[i] > promedio)
	{
		Console.WriteLine(numeros[i]);
		contador++;
	}
}


Console.WriteLine($"Cantidad de números por encima del promedio: {contador}");



