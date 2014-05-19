#include "stdafx.h"
#include "IpAddress.h"
#include<string>
#include <regex>
#include<iostream>
using namespace std;

IpAddress::IpAddress()
{
	for(int i=0;i<IPv4AddressBytes;i++)
	{
		_address[i] = 0;
	}
}

IpAddress::IpAddress(unsigned char * bytes)
{
	for(int i=0;i<IPv4AddressBytes;i++)
	{
		_address[i] = bytes[i];
	}
}

IpAddress::IpAddress(std::string address)
{
	for(int i=0;i<IPv4AddressBytes;i++)
	{
		_address[i]=0;
	}

	std::regex ip_part_regex("[[:digit:]]{1,3}");
	auto words_begin = sregex_iterator(address.begin(), address.end(), ip_part_regex);
    auto words_end = sregex_iterator();

	int j=0;
	for (std::sregex_iterator i = words_begin; i != words_end; ++i) {
        std::smatch match = *i;
        std::string match_str = match.str();
		{
			if(j>=IPv4AddressBytes)
				break;			
			_address[j++] = stoi(match_str);
		}
    }
}

IpAddress::~IpAddress(void)
{
}

IpAddress *IpAddress::parse(string address)
{
	if(address.empty())
		throw std::invalid_argument("address is null");
	std::regex ip_regex("[[:digit:]]{1,3}\\.[[:digit:]]{1,3}\\.[[:digit:]]{1,3}\\.[[:digit:]]{1,3}", std::regex_constants::icase);

	auto words_begin = std::sregex_iterator(address.begin(), address.end(), ip_regex);
    auto words_end = std::sregex_iterator();

	IpAddress * ip = 0;

	for (std::sregex_iterator i = words_begin; i != words_end; ++i) {
        std::smatch match = *i;
        std::string match_str = match.str();
		if(match_str.length()>0)
		{
			ip = new IpAddress(address);
		}
		else
		{
			throw std::invalid_argument("address in incorrect format");
		}
    }
		
	return ip;
}

unsigned char * IpAddress::getAddressBytes()
{
	return _address;
}

std::string IpAddress::toString()
{
	string res = "";
	for(int i=0;i<IPv4AddressBytes;i++)
	{
		int part = _address[i];
		string a  = std::to_string(part);
		res.append(a);
		if(i<IPv4AddressBytes-1)
			res+= ".";
	}	
	return res;
}


