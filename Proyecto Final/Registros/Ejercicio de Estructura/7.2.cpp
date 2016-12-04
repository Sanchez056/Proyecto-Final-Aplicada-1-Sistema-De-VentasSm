#include <iostream>
#include <string.h>

using namespace std;

int polindromo(char *cad)
{
	int tam = strlen(cad);
	char aux[tam];
	for(int x = tam-1,y = 0; x >= 0; x--, y++)
		aux[y] = cad[x];
	if(strcmp(cad,aux) == 0)
		return 1;
	else 
		return 0;
}

void esPolindromo(char *cad)
{
	if(polindromo(cad))
		cout << "es polindromo";
	else
	{
		cout << "introduzca una cadena: ";
		cin >> cad;
		esPolindromo(cad);
	}
}

int main()
{
	char cad[5] = {'e','l','a',};
	esPolindromo(cad);
	
	return 0;
}
