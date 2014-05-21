#include "stdafx.h"
#include "ConfigTransformer.h"
#include "IpConfig.h"
#include "IpAddress.h"
#include <regex>
#include <iostream>

using namespace std;

ConfigTransformer::ConfigTransformer(void)
{

}


ConfigTransformer::~ConfigTransformer(void)
{
}

string ConfigTransformer::UpdateConfig(string oldConfig, IpConfig * ipConfig)
{
	string newConfig;

    if (ipConfig == 0)
    {
        newConfig = ChangeConfigToDynamic(oldConfig);
    }
    else
    {
		newConfig = ChangeConfigToStatic(oldConfig, IpConfig(*ipConfig));
    }

    return newConfig;
}

bool ConfigTransformer::IsConfigModeStatic(string config)
{
	bool isConfigStatic = false;
	std::regex mode_regex("iface eth0 inet (dhcp|static)", std::regex_constants::icase);
	std::smatch mode_match;
	std::regex_search(config, mode_match, mode_regex);
	if(mode_match.size()==2)
		isConfigStatic = mode_match[1]=="static" ? true : false;

	return isConfigStatic;
}

string ConfigTransformer::ChangeConfigMode(string oldConfig, bool toStatic)
{
	string mode = toStatic ? "static" : "dhcp";
	std::regex mode_regex("iface eth0 inet (dhcp|static)", std::regex_constants::icase);
	string replacement = "iface eth0 inet " + mode;
	string res = std::regex_replace(oldConfig,mode_regex,replacement);
	return res;
}

string ConfigTransformer::ChangeConfigToDynamic(string oldConfig)
{
	string res = "";
    if (!IsConfigModeStatic(oldConfig))
    {
        //no changes required
        return oldConfig;
    }

	std::regex addr_removal("(address|netmask|gateway|broadcast|network)[[:space:]]+[[:digit:]]+\\.[[:digit:]]+\\.[[:digit:]]+\\.[[:digit:]]+\n", std::regex_constants::icase);
	string replacement = "";
	res = std::regex_replace(oldConfig,addr_removal,replacement);
	res = ChangeConfigMode(res,false);

    return res;
}

std::string ConfigTransformer::ChangeConfigToStatic(std::string oldConfig, IpConfig ipConfig)
{
	string newAddress = ipConfig.getIpAddress()->toString();
	string newNetmask =ipConfig.getNetmask()->toString();
	string newNetwork = ipConfig.getNetwork()->toString();
	string newBcast = ipConfig.getBroadcast()->toString();
	string newGateway=ipConfig.getGateway()->toString();
	string res="";
	if(!IsConfigModeStatic(oldConfig))
	{
		std::regex mode_regex("iface eth0 inet (dhcp|static)", std::regex_constants::icase);
		string replacement =	"iface eth0 inet static\n"
			"\naddress " + newAddress +
			"\nnetmask " + newNetmask +
			"\nnetwork " + newNetwork +
			"\nbroadcast " + newBcast +
			"\ngateway " + newGateway;

		res = regex_replace(oldConfig,mode_regex,replacement);
	}
	else
	{
		string ipPattern = "[[:digit:]]+\\.[[:digit:]]+\\.[[:digit:]]+\\.[[:digit:]]+";
		std::regex addr_change("address " + ipPattern);
		std::regex netmask_change("netmask " + ipPattern);
		std::regex network_change("network " + ipPattern);
		std::regex bcast_change("broadcast " + ipPattern);
		std::regex gateway_change("gateway " + ipPattern);

		res = oldConfig;
		res = regex_replace(res,addr_change,"address " + newAddress);
		res = regex_replace(res,netmask_change,"netmask " + newNetmask);
		res = regex_replace(res,network_change,"network " + newNetwork);
		res = regex_replace(res,bcast_change,"broadcast " + newBcast);
		res = regex_replace(res,gateway_change,"gateway " + newGateway);
	}

	return res;
}

void ConfigTransformer::Test()
{
	std::string content =	"auto lo\n"
							"iface lo inet loopback\n"
							"iface eth0 inet dhcp  \n"

							"allow-hotplug wlan0\n"
							"iface wlan0 inet manual\n"
							"wpa-roam /etc/wpa_supplicant/wpa_supplicant.conf\n"
							"iface default inet dhcp\n";
 
    std::regex mode_regex("iface eth0 inet (dhcp|static)");
 	   
    std::smatch mode_match;
    
	std::regex_search(content, mode_match, mode_regex);
    std::cout << "matches for content:";
	
    for (size_t i = 0; i < mode_match.size(); ++i) {
        std::ssub_match sub_match = mode_match[i];
        std::string sub_match_str = sub_match.str();
        std::cout << '\n' << sub_match_str;
    }   
       
}
