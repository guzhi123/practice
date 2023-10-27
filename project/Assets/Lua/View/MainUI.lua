---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by Administrator.
--- DateTime: 2023/10/26 21:22
---

--UI=CS.UnityEngine.UI
MainUI = {}

local this = MainUI
this.uiName = "Layout_1/Canvas_Main"

function MainUI.Init(root)
    this.root = root
    this.button_Store = this.root.transform:Find("Buttons/Button_Store"):GetComponent("Button")
    CS.UIUtil.SetButtonEventLua(this.button_Store, this.OnButtonClick_Store)
    MainUI.OnShow()
end
function MainUI.OnButtonClick_Store()
    UISystem.OpenView(UIEnum.StoreUI)
    UISystem.CloseView(UIEnum.MainUI)
end
function MainUI.OnShow()
    this.root:SetActive(true)

end
function MainUI.OnHide()
    this.root:SetActive(false)

end