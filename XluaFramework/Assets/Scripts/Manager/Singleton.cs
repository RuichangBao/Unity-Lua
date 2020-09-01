using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 伪单例模式
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class Singleton<T> where T : class, IEManager, new()
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new T();
                instance.OnInit();
            }
            return instance;
        }
    }

    public abstract void OnInit();
}