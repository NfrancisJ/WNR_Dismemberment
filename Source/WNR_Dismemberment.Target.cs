// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class WNR_DismembermentTarget : TargetRules
{
	public WNR_DismembermentTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "WNR_Dismemberment" } );
	}
}
