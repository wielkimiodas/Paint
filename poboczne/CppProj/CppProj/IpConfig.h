#ifndef IpConfig_h
#define IpConfig_h
#pragma once
#include<string>
#include "IpAddress.h"
class IpConfig
{

private:
	IpAddress _address;
	IpAddress _network;
	IpAddress _gateway;
	IpAddress _netmask;
	IpAddress _broadcast;

public:
	IpConfig(IpAddress ipAddress, IpAddress netmask, IpAddress gateway);
	~IpConfig(void);
	IpAddress * getNetwork();
	IpAddress * getBroadcast();
	IpAddress * getIpAddress();
	IpAddress * getNetmask();
	IpAddress * getGateway();
};
#endif


