﻿using SampleProject.Domain.BaseModels;

namespace SampleProject.Domain.Models;

public class AnotherSampleModel : TrackableEntity
{
    public string Description { get; set; } = string.Empty;
}
