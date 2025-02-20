﻿byte b = 5;     //1 byte
sbyte c = 1;    //1 byte

short s = 5;    //2 byte
ushort us = 5;  //2 byte

Int16 i16 = 2;  //2 byte
int i = 2;      //4 byte
Int32 i32 = 2;  //4 byte
Int64 i64 = 2;  //8 byte

uint ui = 2;    //4 byte
long l = 4;     //8 byte
ulong ul = 4;   //8 byte

//Reel Sayılar
float f = 5;    //4 byte
double d = 5;   //8 byte 
decimal de = 5; //16 byte

char ch = '2';          // 2 byte
string st = "mustafa";  // Sınırsız

bool bl = true;
bool b2 = false;

DateTime dt = DateTime.Now;
Console.WriteLine(dt);

//String ifadeler

string str1 = string.Empty;
str1="Yagiz Can";
string str2 = "Dinc";
string tamAd ="";
tamAd= str1 +" " +str2;
Console.WriteLine(tamAd);

//İnteger tanımlama işlemleri

int int1 = 5;
int int2 = 3;
int int3 = int1 * int2 ;
Console.WriteLine(int3);

//boolen

bool b1 = 10<3;
Console.WriteLine(b1);

//değişken dönüşümleri

string str20 = "20";
int int20 = 20;
string yeniDeger = str20 + int20.ToString();
Console.WriteLine(yeniDeger);

int int21 = int20 + Convert.ToInt32(str20); //toplama yaptı
Console.WriteLine(int21);

int int22 = int20 + int.Parse(str20);
Console.WriteLine(int22);

//datetime

string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(dateTime);

string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(dateTime2);

string hour = DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);