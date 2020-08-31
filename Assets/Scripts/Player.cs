using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static string myName;
    InputField UsernameField;
    TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
       // UsernameField.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    // Update is called once per frame
    void Update()
    {
        myName = GetComponent<TextMeshProUGUI>().text;
    }

    public void ValueChangeCheck()
    {
        myName = UsernameField.GetComponent<TextMeshProUGUI>().text;
    }

  /*  public string userName
    {
        get
        {
            if (myName == string.Empty)
                myName = PlayerPrefs.GetString("playerName", "Player");
            return myName;
        }
        set
        {
            myName = value;
            PlayerPrefs.SetString("playerName", myName);
        } 
    } 

    public void Awake()
    {
        UsernameField.text = myName;
    }

    public void SetUserName(string text)
    {
        userName = text;
    } */
}
