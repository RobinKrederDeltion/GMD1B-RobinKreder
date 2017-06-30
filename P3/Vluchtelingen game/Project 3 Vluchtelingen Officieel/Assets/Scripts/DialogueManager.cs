using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public float length;
    public RaycastHit hit;
    public GameObject cam;
    public GameObject panel;
    public GameObject managers;
    public bool convo;
    public int stringNumber;
    
   
    //panel wordt bij start automatisch uit gezet
    void Start()
    {
        panel.SetActive(false);
    }


    void Update()
    {
        //Wanneer de Raycast collide met een object met de tag "NPC" en op Activate "E" drukt, dan wordt het tekstvakje active en gaat convo op true, als je dat niet doet is alles uit.
        Debug.DrawRay(cam.transform.position, cam.transform.forward * length, Color.blue);
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, length))   
        {
            if (Input.GetButtonDown("Activate"))
            {
                if (hit.collider.tag == ("NPC"))
                {
                    panel.SetActive(true);
                    convo = true;
                }
            }
        }

        if (convo == true)
        {
            InConversation();
        }
        
    }
    //Als er ja wordt gezegd dan wordt de stringnummer +1 en bij nee +3
    public void AnswerYes()
    {
        stringNumber += 1;
        hit.collider.GetComponent<Dialogue>().EventCheck();
    }

    public void AnswerNo()
    {
        stringNumber += 3;
        hit.collider.GetComponent<Dialogue>().EventCheck();
    }

    //hierbij wordt gecontroleerd of de int "stringNumber" gelijk of onder de lis is, anders is de panel en convo uit.
    void InConversation()
    {
        if (stringNumber < hit.collider.GetComponent<Dialogue>().conversation.Count)
        {
            managers.GetComponent<UIManager>().actieveString = hit.collider.GetComponent<Dialogue>().conversation[stringNumber];
        }
        else
        {
            panel.SetActive(false);
            stringNumber = 0;
            convo = false;
        }
    }
}
