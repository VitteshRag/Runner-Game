using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
        // Start is called before the first frame update
        public GameObject thePlayer;
    public GameObject charModel;
    public GameObject MainCam;
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMovement>().enabled = false;
        charModel.GetComponent<Animator>().Play("Fall");
        MainCam.GetComponent<Animator>().Play("CamShake");
    }

}
