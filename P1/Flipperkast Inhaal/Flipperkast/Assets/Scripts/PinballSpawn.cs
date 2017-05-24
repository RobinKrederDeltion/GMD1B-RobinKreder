using UnityEngine;
using System.Collections;

public class PinballSpawn : MonoBehaviour {

    public float power;
    public GameObject prefab;
    public GameObject pinballSpawn;
    public bool activeBall;

    void SpawnPinball()
    {
        GameObject pinball = (GameObject)Instantiate(prefab, pinballSpawn.GetComponent<Transform>().position, pinballSpawn.GetComponent<Transform>().rotation);

        pinball.GetComponent<Rigidbody>().velocity = pinballSpawn.GetComponent<Transform>().transform.forward * power;
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if(GameObject.Find("GameManager").GetComponent<GameData>().lives > 0)
            {
                if (activeBall == false)
                {
                    SpawnPinball();
                }
                else print("Nope");
            }
            else
            {
                print("GameOver");
            }

            activeBall = true;
        }
    }
}
