﻿using HueMicIndicator.Hue.State.Color;

namespace HueMicIndicator.ViewModels.Setup;

public abstract class LightColorSetupViewModelBase : LightFieldSetupViewModel
{
    protected LightColorSetupViewModelBase(LightField field) : base(field) { }

    public override bool ConflictsWith(LightFieldSetupViewModel other)
        => other is LightColorSetupViewModelBase;

    public abstract HueColor GetHueColor();
}