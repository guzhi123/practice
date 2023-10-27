using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;
using XLua;

public class Main : MonoBehaviour
{
    private byte[] CustomLoader_Editor(ref string filePath)
    {
        string path = Application.dataPath + "/Lua/" + filePath + ".Lua";

        if (File.Exists(path))
        {
            Debug.Log(filePath + "�ļ�����");
            return File.ReadAllBytes(path);
        }
        else
        {
            Debug.LogError("�༭��Lua�ļ��ض���ʧ��" + filePath);
        }
        return null;
    }
    private void Start()
    {
        LuaEnv luaEnv = new LuaEnv();
        luaEnv.AddLoader(CustomLoader_Editor);

        luaEnv.DoString("require('Manager/UISystem')");

        luaEnv.Tick();
        luaEnv.Dispose();

    }


}
public static class SliderEventTestClass
{
    [CSharpCallLua]
    public static List<Type> csharpCallLuaList = new List<Type>()
    {
        typeof(UnityAction<float>)
    };

}

