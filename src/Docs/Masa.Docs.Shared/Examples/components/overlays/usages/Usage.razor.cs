﻿
namespace Masa.Docs.Shared.Examples.components.overlays.Usages;

public class Usage : Components.Usage
{
    protected override Type UsageWrapperType => typeof(UsageWrapper);

    public Usage() : base(typeof(MOverlay))
    {
    }
}