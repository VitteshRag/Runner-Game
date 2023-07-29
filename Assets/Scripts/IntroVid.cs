using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroVid : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(VideoDone());
    }

    IEnumerator VideoDone()
    {
        yield return new WaitForSeconds(25);
        SceneManager.LoadScene(1);
    }
}
