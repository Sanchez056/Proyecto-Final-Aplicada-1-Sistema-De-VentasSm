#include <iostream>

using namespace std;

void mostrarArreglo(const int[], int); 
int busquedaBinaria(const int[], int, int);
void ordenarArreglo(int[], int); 
void intercambiar(int&, int&); 
int main()
{
  int clave =0;
  const int tamano = 15;
  int arreglo[tamano] = {25,17,13,16,41,32,12,115,95,84,54,63,78,21,10};
  ordenarArreglo(arreglo,tamano);
  cout << "Elementos del arreglo: " << endl;
  mostrarArreglo(arreglo,tamano);
  return 0;
}

void mostrarArreglo(const int arreglo[], int tamano)
{
	
  for (int i = tamano-1; i > 1 ; i--)
    cout << arreglo[i] << endl;
}

int busquedaBinaria(const int arreglo[], int tamano, int clave)
{
  int Iarriba = tamano-1;
  int Iabajo = 0;
  int Icentro;
  while (Iabajo <= Iarriba)
	{
      Icentro = (Iarriba + Iabajo)/2;
      if (arreglo[Icentro] == clave)
 		return Icentro;
      else
 		if (clave < arreglo[Icentro])
   			Iarriba=Icentro-1;
 		else
   			Iabajo=Icentro+1;
    }
  return -1;
}
void ordenarArreglo(int arreglo[], int tamano)
{
  for (int i = 0; i< tamano -1 ; i++)
    for (int j = 0; j< tamano -1 ; j++)
      if (arreglo[j] > arreglo[j+1])
 		intercambiar(arreglo[j],arreglo[j+1]);
}
void intercambiar(int &a, int &b)
{
  int tmp = b;
  b = a;
  a = tmp;
}
