// CppProj.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "IpConfig.h"
#include "ConfigTransformer.h"
#include <iostream>
#include <iomanip>
#include <fstream>
using namespace std;

string readFromFile(char * path);
void saveToFile(string content, char * path);
void testRegex();
void testIpAddr();
void ipConfigTest();
void configTransformerTest();




int _tmain(int argc, _TCHAR* argv[])
{
	string text = readFromFile("testFile.txt");
	cout<<text;
	
	saveToFile(text, "testFileOut.txt");	
	
	//configTransformerTest();

	string s;
	scanf_s("&s", s);
	return 0;
}

void configTransformerTest()
{
	std::string dynamicContent =	"auto lo\n\n"
								"iface lo inet loopback\n"
								"iface eth0 inet dhcp\n\n"

								"allow-hotplug wlan0\n"
								"iface wlan0 inet manual\n"
								"wpa-roam /etc/wpa_supplicant/wpa_supplicant.conf\n"
								"iface default inet dhcp\n";
	std::string staticContent = "auto lo\n\n"
								"iface lo inet loopback\n"
								"iface eth0 inet static\n\n"

								"address 192.168.1.2\n"
								"netmask 255.255.255.0\n"
								"gateway 192.168.1.1\n"
								"broadcast 192.168.1.255\n"
								"network 192.168.1.0\n\n"

								"allow-hotplug wlan0\n"
								"iface wlan0 inet manual\n"
								"wpa-roam /etc/wpa_supplicant/wpa_supplicant.conf\n"
								"iface default inet dhcp\n";
	auto addr = IpAddress::parse("192.168.2.14");
	auto netmask = IpAddress::parse("255.255.253.0");
	auto gateway = IpAddress::parse("192.168.2.1");
	
	auto ipcfg = new IpConfig(IpAddress(*addr),IpAddress(*netmask),IpAddress(*gateway));
	auto newConfig = ConfigTransformer::UpdateConfig(dynamicContent,ipcfg);
	cout<<newConfig;
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

std::string readFromFile(char * path)
{
	std::ifstream ifs("testFile.txt");
	std::string content( (std::istreambuf_iterator<char>(ifs) ), (std::istreambuf_iterator<char>()) );
	return content;
}

void saveToFile(string content, char * path)
{
	ofstream outFile(path); 
	outFile<<content;
	outFile.close();
}

