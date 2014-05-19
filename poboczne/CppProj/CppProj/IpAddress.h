#pragma once
#include<string>
class IpAddress
{

private:
	std::string strAddress;
	static const int IPv4AddressBytes=4;
	unsigned char _address[IPv4AddressBytes];	
	IpAddress(std::string);

public:	
	IpAddress();
	IpAddress(unsigned char * bytes);
	~IpAddress(void);
	static IpAddress * parse(std::string address);
	unsigned char * getAddressBytes();
	std::string toString();
};

