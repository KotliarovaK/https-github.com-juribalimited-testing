﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using DashworksTestAutomation.Utils;

namespace DashworksTestAutomation.Extensions
{
    public static class EnumExtensions
    {
        public static string GetValue(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            var attributes = (DescriptionAttribute[]) fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            return value.ToString();
        }

        //Usage EnumExtensions.GetAllValues<YourEnum>()
        public static IEnumerable<T> GetAllValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>().ToList();
        }

        public static T GetRandomValue<T>()
        {
            MemberInfo type = typeof(T);

            object randomValue = (T)Enum.ToObject(typeof(T), TestDataGenerator.RandomNum(Enum.GetNames(typeof(T)).Length));
            Logger.Write("Random value from <{0}> Enum is: '{1}'", type.Name, ((Enum)randomValue).GetValue());
            return (T)randomValue;
        }

        /// <summary>
        /// Get random value from appropriate Enum
        /// Example: EnumExtensions.GetRandomValue&gt;ServiceLevelLiteralEnum&gt;(1,2,3)
        /// </summary>
        /// <typeparam name="T">Enum Type</typeparam>
        /// <param name="fieldNumbers">Starts from 0</param>
        /// <returns></returns>
        public static T GetRandomValue<T>(params int[] fieldNumbers)
        {
            MemberInfo type = typeof(T);

            object randomValue = (T)Enum.ToObject(typeof(T), fieldNumbers[TestDataGenerator.RandomNum(fieldNumbers.Length)]);
            Logger.Write("Random value from <{0}> Enum is: '{1}'", type.Name, ((Enum)randomValue).GetValue());
            return (T)randomValue;
        }
    }
}