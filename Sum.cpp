#include<iostream>

using namespace std;

int main(){
	
	unsigned short int val1,val2,sum;
	
	cout << "Please enter first value: ";
	cin >> val1;
	cin.ignore();
	
	cout << "Please enter second value: ";
	cin >> val2;
	cin.ignore();
	
	sum = val1 + val2;
	
	cout << "Sum of two values: " << sum;
	
	return 0;
}
