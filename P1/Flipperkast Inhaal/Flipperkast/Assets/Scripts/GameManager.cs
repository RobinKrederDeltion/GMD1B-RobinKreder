using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


    public int lives;
    public int score;
    public Text tekstvakje;

    void Update()
    {
        tekstvakje.text = score.ToString();
    }

}


