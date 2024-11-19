using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    public GameObject startManu;
    public InputField usernameField;

    public void ConnectedToServer()
    {
        startManu.SetActive(false);
        usernameField.interactable = false;
        Client.Instance.ConnectToServer();
    }
}
