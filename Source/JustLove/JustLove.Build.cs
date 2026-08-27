// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class JustLove : ModuleRules
{
	public JustLove(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"JustLove",
			"JustLove/Variant_Platforming",
			"JustLove/Variant_Platforming/Animation",
			"JustLove/Variant_Combat",
			"JustLove/Variant_Combat/AI",
			"JustLove/Variant_Combat/Animation",
			"JustLove/Variant_Combat/Gameplay",
			"JustLove/Variant_Combat/Interfaces",
			"JustLove/Variant_Combat/UI",
			"JustLove/Variant_SideScrolling",
			"JustLove/Variant_SideScrolling/AI",
			"JustLove/Variant_SideScrolling/Gameplay",
			"JustLove/Variant_SideScrolling/Interfaces",
			"JustLove/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
