#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {
	float degrees_celcius;
	float degrees_fahrenheit;
	degrees_fahrenheit = 27;
	degrees_celcius = degrees_fahrenheit - 32/1.8;
	printf ("27 degrees fahrenheit is %f\n", degrees_celcius, "degrees celcius\n");
	return 0;
}
