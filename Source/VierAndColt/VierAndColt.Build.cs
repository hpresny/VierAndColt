// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class VierAndColt : ModuleRules
{
	public VierAndColt(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
