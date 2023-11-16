using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_SourceStoneUI : MonoBehaviour
{

    public Button button_SourceStone;
    public GameObject prefabCommodity_SourceStone;
    public Transform commodityTransform;
    public GameObject button_SourceStoneContent;

    private void Start()
    {
        button_SourceStone.onClick.AddListener(OnClickButton_SourceStone);
    }

    private void OnClickButton_SourceStone()
    {
        button_SourceStoneContent.SetActive(true);
        for (int i = 1; i <= 6; i++)
        {
            Instantiate(prefabCommodity_SourceStone, commodityTransform);

        }
    }
}
