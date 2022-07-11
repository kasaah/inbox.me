#include <iostream>
using namespace std;
class Rectangle
{
	int width, height;
	public:
		void setValues(int, int);
		int area(){
			return width*height;
		}
};
void Rectangle::setValues(int x, int y){
	width=x;
	height=y;
}

int main(int argc, char** argv) {
	Rectangle rect, rect2;//instance of the class rectangle
	rect.setValues(4,5);
	rect.setValues(10,5);
	cout<<"The area is:"<<rect.area()<<endl;
	cout<<"the area2 is :"<<rect2.area()<<endl;
	return 0;
}
