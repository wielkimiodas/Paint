// CppProj.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "IpConfig.h"
#include <iostream>
#include <iomanip>
#include <fstream>
using namespace std;

char* readFromFile(char * path);
void saveToFile(char * path);
void testRegex();
void testIpAddr();
void ipConfigTest();



int _tmain(int argc, _TCHAR* argv[])
{
	//char * text = readFromFile("testFile.txt");
	//printf("%s",text);
	//saveToFile("testFileOut.txt");	
	
	ipConfigTest();

	string s;
	scanf_s("&s", s);
	return 0;
}

void ipConfigTest()
{
	auto addr = IpAddress::parse("192.168.1.14");
	auto netmask = IpAddress::parse("255.255.255.0");
	auto gateway = IpAddress::parse("192.168.1.1");
	auto cfg = new IpConfig(IpAddress(*addr),IpAddress(*netmask),IpAddress(*gateway));
	auto net = cfg->getBroadcast();
	cout<<net->toString();
}

void testIpAddr()
{
	string content = "192.167.1.166";
	auto addr = IpAddress::parse(content);
	auto addr2 = new IpAddress(addr->getAddressBytes());
	cout<<"addr2 "<<addr2->toString();
}

void testRegex()
{
	string content = "192.168.1.1222";
	auto addr = IpAddress::parse(content);
}

char* readFromFile(char * path)
{
	ifstream inFile(path,ios::beg);
	char * input = NULL;
	if(inFile.is_open())
	{
		streampos fsize = 0;
		fsize = inFile.tellg();
		inFile.seekg(0, std::ios::end);
		fsize = inFile.tellg() - fsize;
		input = new char[fsize];
		inFile.seekg (0, ios::beg);
		inFile.read (input, fsize);
		inFile.close();
	}
	return input;
}

void saveToFile(char * path)
{
	ofstream outFile(path); 
	outFile<<"mds";
	outFile.close();
}

