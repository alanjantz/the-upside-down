﻿using Assets.Utils.Attributes;
using System;
using System.Reflection;

namespace Assets.Utils.Extensions
{
    public static class AttributeExtensions
    {
        public static string GetStringValue(this Enum value)
        {
            Type type = value.GetType();

            FieldInfo fieldInfo = type.GetField(value.ToString());

            StringValueAttribute[] attribs = fieldInfo.GetCustomAttributes(
                typeof(StringValueAttribute), false) as StringValueAttribute[];

            return attribs.Length > 0 ? attribs[0].StringValue : null;
        }
    }
}
