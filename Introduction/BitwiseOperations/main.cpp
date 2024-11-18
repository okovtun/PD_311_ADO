#include<iostream>
#include<conio.h>
using namespace std;

void Print(char arr[], const int n);
void ShiftLeft(char arr[], const int n, int number_of_shifts);
void ShiftRight(char arr[], const int n, int number_of_shifts);

void main()
{
	setlocale(LC_ALL, "");
	/*cout << (111 ^ 111) << endl;
	cout << (49 & 1) << endl;
	cout << (-5 >> 2) << endl;*/
	/*const int n = 9;
	char bin[n] = "00000101";
	char key;
	do
	{
		Print(bin, n);
		key = _getch();
		key == 'a' ? ShiftLeft(bin, n, 1) : ShiftRight(bin, n, 1);
		system("CLS");
	} while (key!=27);*/
	cout << ULLONG_MAX << endl;
	cout << 22.56 << endl;
}
void Print(char arr[], const int n)
{
	for (int i = 0; i < n-1; i++)
	{
		cout << arr[i] << "\t";
	}
	cout << endl;
}
void ShiftLeft(char arr[], const int n, int number_of_shifts)
{
	for (int i = 0; i < number_of_shifts; i++)
	{
		//int buffer = arr[0];
		for (int i = 1; i < n; i++)
		{
			arr[i - 1] = arr[i];
		}
		arr[n - 2] = '0';
	}
}
void ShiftRight(char arr[], const int n, int number_of_shifts)
{
	ShiftLeft(arr, n, n - number_of_shifts);
}