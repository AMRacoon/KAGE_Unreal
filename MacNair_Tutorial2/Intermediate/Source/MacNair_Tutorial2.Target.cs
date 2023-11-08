using UnrealBuildTool;

public class MacNair_Tutorial2Target : TargetRules
{
	public MacNair_Tutorial2Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MacNair_Tutorial2");
	}
}
