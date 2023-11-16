using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Person
{
    public int number;
    public int price;
    public bool ifDouble;
}

public class PurchaseRecord : MonoBehaviour
{

    public GameObject doubleGameObject;
    public Button button_SourceStone;
    public Text text_Number;
    public Text text_Price;

    private void Awake()
    {
        string jsonreceive = PlayerPrefs.GetString("SourceStoneRecord");
        Debug.Log(jsonreceive);
        Person ps = JsonUtility.FromJson<Person>(jsonreceive);
        text_Number.text = ps.number.ToString();
        text_Price.text = ps.price.ToString();
        doubleGameObject.SetActive(ps.ifDouble);




    }
    private void Start()
    {
        button_SourceStone.onClick.AddListener(OnClickButton_SourceStone);
        Debug.Log("222");
    }
    private void OnClickButton_SourceStone()
    {
        Debug.Log("1111");
        Person person = new Person();
        person.number = 1;
        person.price = 6;
        person.ifDouble = false;
        string jsonStr = JsonUtility.ToJson(person);
        PlayerPrefs.SetString("SourceStoneRecord", jsonStr);

    }
    
}
