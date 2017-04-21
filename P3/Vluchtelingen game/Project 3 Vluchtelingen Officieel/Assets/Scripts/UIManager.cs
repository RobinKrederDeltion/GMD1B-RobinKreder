using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour 
{
    
    public Text tekstVakje;
    public string actieveString;

	void Update () {
        tekstVakje.text = actieveString;
	}
}
