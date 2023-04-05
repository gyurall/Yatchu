// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class YatchuProjectServerTarget : TargetRules //이 행은 프로젝트 이름에 맞게 변경합니다.
{
    public YatchuProjectServerTarget(TargetInfo Target) : base(Target) //이 행은 프로젝트 이름에 맞게 변경합니다.
    {
        Type = TargetType.Server;
        DefaultBuildSettings = BuildSettingsVersion.V2;
        ExtraModuleNames.Add("YatchuProject"); //이 행은 프로젝트 이름에 맞게 변경합니다.
    }
}
