using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameData : MonoBehaviour {

    public int lives;
    public int score;
    public Text scoreboard;
    public Text livesboard;

    void Update()
    {
        scoreboard.text = score.ToString();
        livesboard.text = lives.ToString();
    }
}
