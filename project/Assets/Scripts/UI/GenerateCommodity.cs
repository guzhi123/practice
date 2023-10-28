using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateCommodity : MonoBehaviour
{
    public GameObject commodityPrefab;
    public Transform commodityParent;
    public Button commodityButton;
    private bool ifCommodityPrefab;

    private void Start()
    {
        ifCommodityPrefab = true;
        commodityButton.onClick.AddListener(generateCommodity);
    }

    private void generateCommodity()
    {
        if (ifCommodityPrefab)
        {
            for (int i = 0; i < 10; i++)
            {
                Instantiate(commodityPrefab, commodityParent);
                
            }
            ifCommodityPrefab = false;
        }

    }

}
