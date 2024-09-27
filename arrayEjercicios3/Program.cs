//1
using arrayEjercicios3;

int[] enteros = { 3, 6, 8, 4, 5 };
Console.WriteLine("El número 5 existe en el array:" + Array.Exists(enteros, n => n == 5));

//2
int[] mayorDiez = { 5, 6, 13, 9, 10, 17 };
Console.WriteLine("Primer número mayor a 10 en el array:" + Array.Find(mayorDiez, n => n > 10));

//3
int[] numeros = { 2, 4, 3, 7, 19, 10, 14 };
int[] pares = Array.FindAll(numeros, n => n % 2 == 0);
Console.WriteLine("Números pares en el array:");
Array.ForEach(pares, n => Console.Write(n + ", "));
Console.WriteLine(" ");

//4
int[] num3 = { 5, 3, 4 };
Array.ForEach(num3, n => Console.Write(n + ", "));
Array.Resize(ref num3, 5);
Console.WriteLine("Nuevo array:");
Array.ForEach(num3, n => Console.Write(n + ", "));

//5
string[] nombres = { "Jimena", "Alma", "Elena", "Alicia", "Beatriz" };
Array.ForEach(nombres, n => Console.Write(n + ", "));
Array.Sort(nombres);
Console.WriteLine("Nombres ordenados alfabeticamente");
Array.ForEach(nombres,n => Console.Write(n + ", "));
Console.WriteLine("");

//6
Persona jose = new("Jose", 56);
Persona alan = new("Alan", 34);
Persona mia = new("Mia", 22);
object[] people = { jose, alan, mia };
Array.Sort(people);
Array.ForEach(people, n => Console.Write(n + "; "));