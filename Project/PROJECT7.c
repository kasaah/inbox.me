#include <stdio.h>
int main (){
char firstname;
char lastname;
char fullname;
printf ("Enter the person's first name:");
scanf("%c", &firstname);
printf("Enter the person's last name:");
scanf("%c", &lastname);
fullname= firstname+lastname;
printf("your full name:%c", fullname);
return 0;
}
