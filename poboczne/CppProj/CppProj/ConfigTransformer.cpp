#include "stdafx.h"
#include "ConfigTransformer.h"

using namespace std;

ConfigTransformer::ConfigTransformer(void)
{

}


ConfigTransformer::~ConfigTransformer(void)
{
}

bool ConfigTransformer::IsConfigModeStatic(string config)
{
	/*
	bool isConfigStatic = false;
    var res = Regex.Match(config, @"s*iface eth0 inet (?<mode>.+)");
    if (res.Groups["mode"].Success)
    {
        var mode = res.Groups["mode"].Captures[0].ToString().Trim();
        isConfigStatic = mode.Contains("static");
    }

    return isConfigStatic;
	*/

	bool isConfigStatic = false;


	return false;
}
