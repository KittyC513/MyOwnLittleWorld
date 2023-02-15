using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomEvent : MonoBehaviour
{
    public GameObject randEvent;
    public GameObject privateChat;
    public GameObject effectA;
    public GameObject effectB;
    public GameObject alert;
    public GameObject laptopUI;

    public GameObject chatChat;

    public GameObject tokTok;


    int numOfClick;
    // Start is called before the first frame update
    void Start()
    {
        numOfClick = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void RandomEvents()
    {
        //if the numOfClick equals zero, the randEven will be triggered
        if (numOfClick == 0)
        {
            randEvent.SetActive(true);
            numOfClick++;
            Debug.Log(2);
        }
        
    }

    public void RemoveRandomEvents()
    {
        randEvent.SetActive(false);
    }

    public void PrivateChat()
    {
        privateChat.SetActive(true);
    }

    public void RemovePrivateChat()
    {
        privateChat.SetActive(false);
    }

    public void EffectA()
    {
        effectA.SetActive(true);
    }

    public void EffectB()
    {
        effectB.SetActive(true);
    }

    public void RemoveEffectA()
    {
        effectA.SetActive(false);
    }

    public void RemoveEffectB()
    {
        effectB.SetActive(false);
    }

    public void Alerts()
    {
        alert.SetActive(true);
    }

    public void RemoveAlert()
    {
        alert.SetActive(false);
        laptopUI.SetActive(false);

    }

    public void ChatEvent()
    {
        chatChat.SetActive(true);
    }

    public void WatchVideo()
    {
        tokTok.SetActive(true);
    }

}
