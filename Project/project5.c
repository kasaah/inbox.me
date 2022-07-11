#include <stdio.h>
int main(){
	float interest;
	float principal;
	float rate;
	float finalvalue;
	int time;
	printf("Enter the amount to be invested:");
	scanf("%f", &principal);
	printf("Enter the rate of interest as a decimal:");
	scanf("%f", &rate);
	printf("Enter the term of the investment(in years):");
	scanf("%i", &time);
	interest = principal * rate * time;
	printf("your interest: %f",interest);
	finalvalue= principal + interest;
	printf("Your future value:%f", finalvalue);
	return 0; 
}
