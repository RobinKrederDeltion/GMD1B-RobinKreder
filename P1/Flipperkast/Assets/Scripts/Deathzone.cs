using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

    public GameManager gamedatascript;

    void OnCollisionEnter(Collision c)
    {
        Destroy(c.gameObject);
        gamedatascript.lives += -1;
        GameObject.Find("Katapult").GetComponent<Launcher>().activeball = false;
    }
}
