---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by Administrator.
--- DateTime: 2023/10/26 21:23
---
require("View/MainUI")
require("View/StoreUI")

require("View/OperatorUI")
require("View/SquadsUI")

UISystem = {}
local this = UISystem

this.uiDic = {}
this.uiRoot = nil

function UISystem.Init()
    print("UISystem.Init() ")
    this.uiDic[UIEnum.StoreUI] = StoreUI
    this.uiDic[UIEnum.MainUI] = MainUI
    this.uiDic[UIEnum.OperatorUI] = OperatorUI
    this.uiDic[UIEnum.SquadsUI] = SquadsUI

    this.uiRoot = CS.UnityEngine.GameObject.Find("UIRoot")
    this.SetUIRoot()
    this.OpenView(UIEnum.MainUI)

end

function UISystem.SetUIRoot()
    for key, view in pairs(this.uiDic) do
        local root = this.uiRoot.transform:Find(view.uiName).gameObject
        view.Init(root)
    end
end

function UISystem.OpenView(uiEnum)
    this.uiDic[uiEnum].OnShow()

end

function UISystem.CloseView(uiEnum)
    this.uiDic[uiEnum].OnHide()

end