#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	int n;
	int triangular_number = 1;
	for (n = 1; n <= 200; ++n)
	triangular_number = triangular_number + n;
	printf ("200th Triangular_number is %i\n", triangular_number);
	return 0;
}
