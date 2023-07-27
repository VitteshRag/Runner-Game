using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public float speed;
    [SerializeField] public float lrspeed;
    [SerializeField] public float jumph;
    public GameObject IncreaseSpeedInfo;

    public float AirTime;
     bool isJumping = false;
     bool comingDown = false;
    public GameObject charModel;
    void Start()
    {
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
        StartCoroutine(IncreaseSpeed());
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > BoundryCheck.leftside)
            {
                transform.Translate(Vector3.left * Time.deltaTime * lrspeed, Space.World);
                //animator.SetBool("Left", true);
            }
        }
        else
        {
            //animator.SetBool("Left", false);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < BoundryCheck.rightside)
            {
                transform.Translate(Vector3.right * Time.deltaTime * lrspeed, Space.World);
                //animator.SetBool("Right", true);
            }
        }
        else
        {
            //animator.SetBool("Right", false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if(isJumping==false)
            {
                isJumping = true;
                charModel.GetComponent<Animator>().Play("Jump");
                StartCoroutine(JumpSeq());
            }
        }
        if(isJumping==true)
        {
            if(comingDown==false)
            transform.Translate(Vector3.up * Time.deltaTime * jumph, Space.World);
            else
                transform.Translate(Vector3.up * Time.deltaTime * -1*jumph, Space.World);

        }
    }
    IEnumerator JumpSeq()
    {
        yield return new WaitForSeconds(AirTime);
        comingDown = true;
        yield return new WaitForSeconds(AirTime);
        comingDown = false;
        isJumping = false;
    }
    
    IEnumerator IncreaseSpeed()
    {
        yield return new WaitForSeconds(10);
        IncreaseSpeedInfo.SetActive(true);
        speed+=0.001f;
    }
}
