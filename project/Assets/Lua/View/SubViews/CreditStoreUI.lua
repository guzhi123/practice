---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by Administrator.
--- DateTime: 2023/10/28 19:40
---
CreditStoreUI=UIBase:new()
local this = CreditStoreUI
this.uiName = "Store/Buttons/Button_Credit"


function CreditStoreUI.Init(root)
    this.root = root
    this.ifCommodityPrefab = true
    this.button_Credit = this.root:GetComponent("Button")
    CS.UIUtil.SetButtonEventLua(this.button_Credit, this.OnButtonClick_Credit)
    this.commodities = this.root.transform:Find("commodities")
    this.commodityPrefab = CS.UIUtil.GetPrefabLua("Prefabs/commodity")

    --this.commodityPrefabButton = this.commodityPrefab.transform:Find("Button_commodity"):GetComponent("Button")
    --CS.UIUtil.SetButtonEventLua(this.commodityPrefabButton,this.OnButtonClick_Commodities)

end

function CreditStoreUI.OnButtonClick_Credit()

    if this.ifCommodityPrefab then
        this.ifCommodityPrefab = false
        for i = 1, 10, 1 do
            local go = CS.UnityEngine.GameObject.Instantiate(this.commodityPrefab, this.commodities.transform)
            local button = go.transform:Find("Button_commodity"):GetComponent("Button")
            local img = go.transform:Find("Image_completed").gameObject

            CS.UIUtil.SetButtonEventLua(button, function() this.OnButtonClick_Commodities(img) end)
        end
    end

end
function CreditStoreUI.OnButtonClick_Commodities(img)
    img:SetActive(true)
    CS.UnityEngine.GameObject.Instantiate(this.commodityPrefab, BagUI.articlesParent)
end
