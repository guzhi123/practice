using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;

public class Main : MonoBehaviour
{
    private byte[] CustomLoader_Editor(ref string filePath)
    {
        string path = Application.dataPath + "/Lua/" + filePath + ".Lua";

        if (File.Exists(path))
        {
            Debug.Log(filePath + "文件存在");
            return File.ReadAllBytes(path);
        }
        else
        {
            Debug.LogError("编辑器Lua文件重定向失败" + filePath);
        }
        return null;
    }
    private void Start()
    {
        LuaEnv luaEnv = new LuaEnv();
        luaEnv.AddLoader(CustomLoader_Editor);

        luaEnv.DoString("require('Main')");

        luaEnv.Tick();
        luaEnv.Dispose();

    }

}
