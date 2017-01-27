using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLights : MonoBehaviour
{
    Light testLight;
    public float minWachtTijd;
    public float maxWachtTijd;

    // Use this for initialization
    void Start()
    {
        testLight = GetComponent<Light>();
        StartCoroutine(Flashing());

    }

    IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWachtTijd, maxWachtTijd));
            testLight.enabled = !testLight.enabled;
        }
    }
}

    