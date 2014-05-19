#pragma once
#include<string>
class ConfigTransformer
{
public:
	ConfigTransformer(void);
	~ConfigTransformer(void);

	static bool IsConfigModeStatic(std::string config);
};

