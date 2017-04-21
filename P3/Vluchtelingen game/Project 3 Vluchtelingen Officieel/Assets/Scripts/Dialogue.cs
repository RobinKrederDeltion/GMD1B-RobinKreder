using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public List<string> conversation = new List<string>();
    public GameObject managers;
    public int event1;
    public int event2;
    public int event3;

    public void EventCheck()
    {
        if (managers.GetComponent<DialogueManager>().stringNumber == event1)
        {
            managers.GetComponent<GameManager>().eventNumber = event1;
        }
        if (managers.GetComponent<DialogueManager>().stringNumber == event2)
        {
            managers.GetComponent<GameManager>().eventNumber = event2;
        }
        if (managers.GetComponent<DialogueManager>().stringNumber == event3)
        {
            managers.GetComponent<GameManager>().eventNumber = event3;
        }
        managers.GetComponent<GameManager>().EventStart();
    }
}

