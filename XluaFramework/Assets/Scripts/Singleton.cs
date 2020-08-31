﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 伪单例模式
/// </summary>
/// <typeparam name="T"></typeparam>
public class Singleton<T> where T : class, new()
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new T();
                
            }
            return instance;
        }
    }
}