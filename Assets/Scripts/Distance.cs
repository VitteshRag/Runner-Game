using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Distance : MonoBehaviour
{
    public bool isAdding = false;
    public TextMeshProUGUI countDist;
    public TextMeshProUGUI countEndDist;
    int disRun;
    public float distSpeed;
    // Update is called once per frame
    void Update()
    {
        if(isAdding==false)
        {
            isAdding=true;
            StartCoroutine(AddingDis());
        }
    }
    IEnumerator AddingDis()
    {
        disRun+=1;
        countDist.text= "" +disRun;
        countEndDist.text= "" +disRun;
        yield return new WaitForSeconds(distSpeed);
        isAdding= false;
    }
}
