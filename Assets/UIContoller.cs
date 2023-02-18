using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIContoller : MonoBehaviour
{
    public GameObject chatChat;
    public GameObject loc;
    public GameObject tokTok;

    public GameObject desktop;
    public GameObject cC;
    public GameObject loC;
    public GameObject tT;

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

    public void TurnOffChatChat()
    {
        chatChat.SetActive(false);
    }

    public void TurnOffToktokt()
    {
        tokTok.SetActive(false);
    }

    public void TurnOffLoc()
    {
        loc.SetActive(false);
    }

    public void BlockChatChat()
    {
        cC.SetActive(false);
    }

    public void BlocktokTok()
    {
        tT.SetActive(false);
    }

    public void BlockloC()
    {
        loC.SetActive(false);
    }

    public void ActivatecC()
    {
        cC.SetActive(true);
    }

    public void ActivateloC()
    {
        loC.SetActive(true);
    }

    public void ActivatetokTok()
    {
        tT.SetActive(true);
    }


}
