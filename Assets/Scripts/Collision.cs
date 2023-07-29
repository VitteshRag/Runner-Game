using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
        // Start is called before the first frame update
        public GameObject thePlayer;
    public GameObject charModel;
    public GameObject MainCam;
    public AudioSource deadFX;
    public AudioSource BGFX;
    public GameObject LevelControl;
    void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.Translate(Vector3.down*Time.deltaTime, Space.World);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMovement>().enabled = false;
        LevelControl.GetComponent<Distance>().enabled=false;
        BGFX.Pause();
        deadFX.Play();
        charModel.GetComponent<Animator>().Play("Fall");
        MainCam.GetComponent<Animator>().Play("CamShake");
        LevelControl.GetComponent<EndScreen>().enabled=true;
        LevelControl.GetComponent<Infinite>().enabled=false;
    }

}
