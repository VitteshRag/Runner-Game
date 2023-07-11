using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collectable : MonoBehaviour
{

    public static int count=0;
    public TextMeshProUGUI countText;
    
    public TextMeshProUGUI countEndText;
    void Update()
    {
        countText.text = "" + count;
        countEndText.text = "" + count;
    }
}
