// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class AM3_A2_BrowningGarreEditorTarget : TargetRules
{
	public AM3_A2_BrowningGarreEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "AM3_A2_BrowningGarre" } );
	}
}
