using UnityEngine;
using System.Collections;

public class Deathzone : MonoBehaviour {

    public GameData gameDataScript;

    void OnCollisionEnter(Collision c)
    {
        Destroy(c.gameObject);
        gameDataScript.lives += -1;
        GameObject.Find("Katapult").GetComponent<PinballSpawn>().activeBall = false;
    }
}
