using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour {

    public Item itemHolder;
    public Inventory inv;
    public Image spriteHolder;

    public Text statNaam;
    public Text statCost;
    public Text statWeight;
    public Image statImage;


    private void Awake()
    {
        inv = GameObject.Find("Inventory").GetComponent<Inventory>();

        statNaam = GameObject.Find("Name").GetComponent<Text>();
        statCost = GameObject.Find("Cost").GetComponent<Text>();
        statWeight = GameObject.Find("Weight").GetComponent<Text>();
        statImage = GameObject.Find("Image").GetComponent<Image>();



        if (itemHolder != null)
        {
            print("Zit wat in");
            spriteHolder.sprite = itemHolder.sprite;
        }
    }

    public void OnClick()
    {
        if (inv.itemDragging != null && itemHolder == null)
        {
            itemHolder = inv.itemDragging;
            inv.itemDragging = null;
            spriteHolder.sprite = itemHolder.sprite;
        }

        else if (inv.itemDragging == null && itemHolder != null)
        {
            inv.itemDragging = itemHolder;
            itemHolder = null;
            spriteHolder.sprite = null;
        }
        
        if (inv.itemDragging != null && itemHolder != null)
        {
            inv.temp = itemHolder;
            itemHolder = inv.itemDragging;
            inv.itemDragging = inv.temp;
            inv.temp = null;
            spriteHolder.sprite = itemHolder.sprite;
        }
    }

    public void MouseEnter()
    {
        if (itemHolder != null)
        {
            inv.stats.SetActive(true);
            statNaam.text = itemHolder.itemName;
            statCost.text = itemHolder.cost.ToString();
            statWeight.text = itemHolder.weight.ToString();
            statImage.sprite = itemHolder.sprite;
;        }
    }

    public void MouseLeave()
    {
        inv.stats.SetActive(false);
        statNaam.text = null;
        statCost.text = null;
        statWeight.text = null;
        statImage.sprite = null;
    }
}
