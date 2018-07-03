//  Projekt z Jêzyków assemblerowych - Algorytm KMP
//  Autor: Tomasz Halemba
//  Semestr: 5
//  Sekcja: 8
//  Rok akademicki : 2017 / 2018



#include <iostream>
#include<string>
using namespace std;



// function to calculate shift table
//
// parameters:
//
// shift - shift table
// pattern - pattern
// M- shift table and pattern size
//
void init_shift_cpp(int *shift, const char * pattern, int M)
{

	int a, b;
	shift[0] = -1;
	for (a = 0, b = -1; a < M - 1; a++, b++, shift[a] = b)
		while ((b >= 0) && (pattern[a] != pattern[b]))
			b = shift[b];
}


// function to find pattern in text using KMP algorythm  function to calculate shift table
//
// parameters:
//
// shift - shift table and text size in 0 index of table
// pattern - pattern
// M- shift table and pattern size
// text - text
//
int kmp_cpp(int *shift, const char * pattern, int M, const char * text)
{
	
	int a, b,n=shift[0];
	shift[0] = -1;
	for (a = 0, b = 0; (a < n) && (b < M); a++, b++)
	{
		while ((b >= 0) && text[a] != pattern[b])
			b = shift[b];
	}
	if (b == M) return a;
	return -1;

}