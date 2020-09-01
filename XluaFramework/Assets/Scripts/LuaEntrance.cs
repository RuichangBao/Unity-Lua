using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using System.IO;
public class LuaEntrance : IEManager
{
    private LuaEnv luaEnv;
    public void OnInit()
    {
        BindLua();
        DoString("require 'Launcher'");
    }

    public void BindLua()
    {
        if (luaEnv == null)
            luaEnv = new LuaEnv();

        luaEnv.AddLoader(CustomLoader);
    }

    private byte[] CustomLoader(ref string filepath)
    {
        return FileIO.ReadLuaFile(filepath);
    }

    public void DoString(string str)
    {
        luaEnv.DoString(str);
    }
}
