using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileIO
{
    public static byte[] ReadLuaFile(string path)
    {
        path = Application.dataPath + "/Lua/" + path + ".lua";
        if (!File.Exists(path))
        {
            Debug.LogError("该文件不存在");
            return null;
        }
        FileStream fileStream = new FileStream(path, FileMode.Open);
        byte[] data = new byte[fileStream.Length];
        fileStream.Read(data, 0, data.Length);
        fileStream.Close();
        return data;
    }
}