using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EndScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ingameInfo;
    public GameObject EndgameInfo;
    void Start()
    {
        StartCoroutine(EndSeq());
    }
    
    IEnumerator EndSeq()
    {
        yield return new WaitForSeconds(3);
        ingameInfo.SetActive(false);
        EndgameInfo.SetActive(true);        
    }
}
