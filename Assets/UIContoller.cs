using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIContoller : MonoBehaviour
{
    public GameObject chatChat;
    public GameObject loc;
    public GameObject tokTok;

    public GameObject desktop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenChatchat()
    {
        chatChat.SetActive(true);
    }

    public void OpenLOC()
    {
        loc.SetActive(true);
    }

    public void OpenToktok()
    {
        tokTok.SetActive(true);
    }

    public void ShutdownLaptop()
    {
        desktop.SetActive(false);
    }
}
