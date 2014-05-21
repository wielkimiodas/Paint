#ifndef ConfigTransformer_h
#define ConfigTransformer_h
#pragma once
#include<string>
#include "IpConfig.h"
#include "IpAddress.h"

class ConfigTransformer
{
private:
	static std::string ChangeConfigMode(std::string oldConfig, bool toStatic);
	static bool IsConfigModeStatic(std::string config);

public:
	ConfigTransformer(void);
	~ConfigTransformer(void);
	
	static std::string ChangeConfigToDynamic(std::string oldConfig);
	static std::string ChangeConfigToStatic(std::string oldConfig, IpConfig ipConfig);
	static void Test();
};

#endif