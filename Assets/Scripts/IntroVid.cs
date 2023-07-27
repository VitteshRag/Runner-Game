using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroVid : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Intro;
    public GameObject AudioManager;

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(VideoDone());
    }

    IEnumerator VideoDone()
    {
        yield return new WaitForSeconds(25);
        Intro.SetActive(false);
        Menu.SetActive(true);
        AudioManager.SetActive(true);
    }
}
