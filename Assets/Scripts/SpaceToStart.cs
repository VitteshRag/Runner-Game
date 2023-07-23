using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceToStart : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PlayerModel;
    public GameObject Player;
    public GameObject gameInfo;
    public GameObject SpacetoStart;
    public GameObject LevelControl;
    public GameObject MainCam;

    
    void Update()
    {
        if(Input.GetKey(KeyCode.Return))
        {
            PlayerModel.GetComponent<Animator>().Play("Running");
            Player.GetComponent<PlayerMovement>().enabled=true;
            Player.GetComponent<SpaceToStart>().enabled=false;
            MainCam.GetComponent<Animator>().Play("CameraPan");
            SpacetoStart.SetActive(false);
            gameInfo.SetActive(true);
            LevelControl.GetComponent<Distance>().enabled=true;

        }
    }
}
