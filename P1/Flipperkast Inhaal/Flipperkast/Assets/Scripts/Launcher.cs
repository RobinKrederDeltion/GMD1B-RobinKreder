using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour
{
    public float power;
    public GameObject prefab;
    public GameObject pinballSpawn;
    public bool activeball;

    void SpawnPinball()
    {
        GameObject pinball = (GameObject)Instantiate(prefab, pinballSpawn.GetComponent<Transform>().position, pinballSpawn.GetComponent<Transform>().rotation);
        pinball.GetComponent<Rigidbody>().velocity = pinballSpawn.GetComponent<Transform>().transform.forward * power;
    }


    void Update()
    
       
        {
            if (Input.GetButtonDown("Jump"))
            {
                if (GameObject.Find("GameManager").GetComponent<GameData>().lives > 0)
                {
                    if (activeball == false)
                    {
                        SpawnPinball();
                    }
                }
            activeball = true;
            }
        
        
    }


    
}
