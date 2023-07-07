using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collectable : MonoBehaviour
{

    public static int count=0;
    public TextMeshProUGUI countText;
    void Update()
    {
        countText.text = "" + count;
    }
}
