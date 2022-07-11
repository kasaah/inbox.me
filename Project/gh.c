#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {
int triangular_number = 1;
int n;

for (n=1; n<81; n=n+1)
triangular_number = triangular_number + n;

printf ("Triangular number %6i\n", triangular_number);

	return 0;
}
