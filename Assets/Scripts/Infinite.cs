using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infinite : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] section;
    public int zPos = 30;
    public bool createSec = false;
    public int secNum;
    // Update is called once per frame
    void Update()
    {
        if (createSec == false)
        {
            createSec = true;
            StartCoroutine(GenerateSec());
        }
    }

    IEnumerator GenerateSec()
    {
        secNum = Random.Range(0, section.Length);
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 30;
        yield return new WaitForSeconds(1);
        createSec = false;
    }
}
