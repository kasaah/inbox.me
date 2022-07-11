#include <stdio.h>
int main (){
	int age;//1 represent registered & and 2 represent not registered
	int status;
	printf ("Enter your age and status in the format: (age)(status)");
	scanf ("%i %i", &age, &status);
	if (age>=18 &&status==1)
	{printf("you can vote");
	}
	else {
		printf("Go home");
	}
	return 0;
}
