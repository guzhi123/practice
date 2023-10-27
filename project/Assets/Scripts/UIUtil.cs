using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

public static class UIUtil
{
    public static void SetButtonEventLua(Button button, LuaFunction luaFunction) 
    {
        UnityAction action = () => { 
            luaFunction.Call();
        };
        button.onClick.AddListener(action);
    }

}
