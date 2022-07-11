#include <iostream>
using namespace std; 
//function prototypes
void display();
void calculate();

int main( ) 
{
	cout<<"I am in main"<<endl;
	display();	//function call
	cout<<"I am in main again"<<endl;
	calculate();	//function call
	return 0;
}
	void display()
	{
	cout<<"I am now in display"<<endl;
	}
	void calculate()
	{
		cout<<"now in calculate"<<endl;
	}

