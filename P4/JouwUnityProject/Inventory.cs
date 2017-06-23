using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public Item itemDragging;
    public Item temp;
    public GameObject stats;


    void Start()
    {
        stats = GameObject.Find("StatsPanel");
        stats.SetActive(false);
    }


}


