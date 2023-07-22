using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeVolScene : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject Main;
    public GameObject SetVolume;
    
    public void SetVol()
    {
        Main.SetActive(false);
        SetVolume.SetActive(true);
    }
    public void GoBack()
    {
        Main.SetActive(true);
        SetVolume.SetActive(false);
    }
}
