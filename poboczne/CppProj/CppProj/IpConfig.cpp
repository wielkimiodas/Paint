#include "stdafx.h"
#include "IpConfig.h"


IpConfig::IpConfig(IpAddress ipAddress, IpAddress netmask, IpAddress gateway)
{	
	_address = ipAddress;
	_netmask = netmask;
	_gateway = gateway;
}

IpConfig::~IpConfig(void)
{
}

IpAddress * IpConfig::getIpAddress()
{
	return &_address;
}

IpAddress * IpConfig::getNetmask()
{
	return &_netmask;
}

IpAddress * IpConfig::getGateway()
{
	return &_gateway;
}

IpAddress * IpConfig::getNetwork()
{
	
	auto ipAdressBytes = _address.getAddressBytes();
	auto subnetMaskBytes = _netmask.getAddressBytes();
	
	const int size = sizeof(ipAdressBytes)/sizeof(unsigned char);
	unsigned char *networkAddress= new unsigned char[size];
    
	for (int i = 0; i < size; i++)
    {
        networkAddress[i] = (unsigned char)(ipAdressBytes[i] & (subnetMaskBytes[i]));
    }
 
	return new IpAddress(networkAddress);
}

IpAddress * IpConfig::getBroadcast()
{
	auto ipAdressBytes = _address.getAddressBytes();
	auto subnetMaskBytes = _netmask.getAddressBytes();

	const int size = sizeof(ipAdressBytes)/sizeof(unsigned char);

	unsigned char * broadcastAddress = new unsigned char[size];
    for (int i = 0; i < size; i++)
    {
		broadcastAddress[i] = (unsigned char) (ipAdressBytes[i] | (subnetMaskBytes[i] ^ 255));
    }
    return new IpAddress(broadcastAddress);
}
