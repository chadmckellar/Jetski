// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Jetski : ModuleRules
{
	public Jetski(ReadOnlyTargetRules Target) : base(Target)
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
			"Jetski",
			"Jetski/Variant_Platforming",
			"Jetski/Variant_Platforming/Animation",
			"Jetski/Variant_Combat",
			"Jetski/Variant_Combat/AI",
			"Jetski/Variant_Combat/Animation",
			"Jetski/Variant_Combat/Gameplay",
			"Jetski/Variant_Combat/Interfaces",
			"Jetski/Variant_Combat/UI",
			"Jetski/Variant_SideScrolling",
			"Jetski/Variant_SideScrolling/AI",
			"Jetski/Variant_SideScrolling/Gameplay",
			"Jetski/Variant_SideScrolling/Interfaces",
			"Jetski/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
