#include <stdio.h>
int main() {
char itemname;
float discountrate=0.2;
float originalprice=;
float saleprice;
float amountsaved;
float taxrate=0.65;
float totalprice;
//this is where the processing starts
printf("Enter the name of the item");
scanf("%c", &itemname);
printf("Enter the price of the item");
scanf("%f", &originalprice);
amountsaved=originalprice*0.2;
printf("your discount: &f", amountsaved);
saleprice=originalprice-amountsaved;
taxrate=saleprice*0.65;
totalprice=saleprice+taxrate;
printf("your total price:&f", totalprice);	
	return 0;
}
