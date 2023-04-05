// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class YatchuProjectServerTarget : TargetRules //�� ���� ������Ʈ �̸��� �°� �����մϴ�.
{
    public YatchuProjectServerTarget(TargetInfo Target) : base(Target) //�� ���� ������Ʈ �̸��� �°� �����մϴ�.
    {
        Type = TargetType.Server;
        DefaultBuildSettings = BuildSettingsVersion.V2;
        ExtraModuleNames.Add("YatchuProject"); //�� ���� ������Ʈ �̸��� �°� �����մϴ�.
    }
}
