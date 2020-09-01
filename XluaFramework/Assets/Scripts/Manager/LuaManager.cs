using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuaManager : Singleton<LuaManager>, IEManager
{
    private LuaEntrance luaEntrance;
    public override void OnInit()
    {
        luaEntrance = new LuaEntrance();
        luaEntrance.OnInit();
    }
}
