#include <iostream>
#include <string.h>
#include <stdlib.h>

using namespace std;

int numeroVocales(char *cad, int x)
{
	if(cad[x] == 'a' || cad[x] == 'e' || cad[x] == 'i' || cad[x] == 'o' || cad[x] == 'u' || cad[x] == 'A' || cad[x] == 'E' || cad[x] == 'I' || cad[x] == 'O' || cad[x] == 'U')
		return 1 + numeroVocales(cad, x+1);
	else
		if(cad[x] != '\0')
			return 0 + numeroVocales(cad, x+1);
	
}

int main()
{
	char array[10] = {'h', 'o', 'l', 'a', 'm', 'i','j','o','s'};
	cout << numeroVocales(array,0);
	return 0;
}
