﻿using System.Text.Json.Serialization;

namespace SpaceTraders.Api.Utilities;

[AttributeUsage(AttributeTargets.Interface, AllowMultiple = false)]
public class JsonInterfaceConverterAttribute : JsonConverterAttribute
{
    public JsonInterfaceConverterAttribute(Type converterType) : base(converterType)
    {
    }
}