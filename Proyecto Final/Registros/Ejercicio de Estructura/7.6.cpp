#include <iostream>

using namespace std;

int hanoi(int Numero)
{
    if(Numero == 1)
        return 1;
    else
        return 2 * hanoi(Numero-1) + 1;
}

int main()
{
    int Disco ;
    cout<< "\n Torre de Hanoi \n\n";
    cout<< "Numero de discos: ";
	cin>> Disco;
    cout<<"\nLos Movimientos Obligatorio Son: ";
    cout<< hanoi(Disco);
    
    return 0;
}
