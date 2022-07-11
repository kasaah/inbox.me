#include<stdio.h>
int main(){
	int age;
	int status;
	printf("What is your age");
	scanf("%i", &age);
	printf("Enter your status");
	scanf("%i", status);
	if (age>=18 &&status==1)
	{printf("You can vote");
	}
	else {
		printf ("Go home");
	}
	return 0;
}
