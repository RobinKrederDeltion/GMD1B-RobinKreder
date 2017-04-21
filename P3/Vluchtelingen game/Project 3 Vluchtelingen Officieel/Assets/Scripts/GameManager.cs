using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static bool inConvo;
    public int eventNumber;

    public void EventStart()
    {

        if (eventNumber == 1)
        {
            Event1();
        }
        if (eventNumber == 2)
        {
            Event2();
        }
        if (eventNumber == 3)
        {
            Event3();
        }
    }

    void Event1()
    {
        print("1");
        // potentiele eventen, zoals doodgaan of een powerup spawnen
    }
    void Event2()
    {
        print("2");
    }
    void Event3()
    {
        print("3");
    }
}
