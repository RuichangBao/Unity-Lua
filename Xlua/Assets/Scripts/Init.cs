using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using XLua;
public class Init : MonoBehaviour
{
	public static LuaEnv luaenv;
	// Use this for initialization
	void Start()
	{
	    luaenv = new LuaEnv();
		string strLua= "print('hello world')";
		luaenv.DoString(strLua);
		luaenv.DoString(strLua);
		luaenv.Dispose();
		SceneManager.LoadScene("Test1");
	}

	// Update is called once per frame
	void Update()
	{

	}
}