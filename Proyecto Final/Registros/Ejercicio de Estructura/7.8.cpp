#include <iostream>

using namespace std;

long funcionRecursiva(int n)
{
	if(n == 0 || n == 1)
		return 1;
	else 
		if(n % 2 == 0)
			return 2 + funcionRecursiva(n-1);
		else 
			return 3 + funcionRecursiva(n-2);
}

int main()
{
	
	cout << funcionRecursiva(10);
	return 0;
}
