using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class UIController : MonoBehaviour
{

    public Canvas internalCanvas;
    public Button button_Store;

    private void Awake()
    {
        button_Store = transform.GetChild(1).GetChild(3).GetComponent<Button>();
        //internalCanvas=transform.Find("Canvas").GetComponent<Canvas>();
        internalCanvas=GameObject.Find("Canvas_Store").GetComponent<Canvas>();
    }
    private void Start()
    {
        button_Store.onClick.AddListener(OpenStore);

    }

    private void OpenStore()
    {
        internalCanvas.gameObject.SetActive(true);
    }
}
