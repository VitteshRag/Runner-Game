using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public float speed;
    [SerializeField] public float lrspeed;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > BoundryCheck.leftside)
            {
                animator.SetBool("Left", true);
                transform.Translate(Vector3.left * Time.deltaTime * lrspeed, Space.World);
            }
        }
        else
        {
            animator.SetBool("Left", false);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < BoundryCheck.rightside)
            {
                animator.SetBool("Right", true);
                transform.Translate(Vector3.right * Time.deltaTime * lrspeed, Space.World);
            }
        }
        else
        {
            animator.SetBool("Right", false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("Jumping", true);
        }
        else
        {
            animator.SetBool("Jumping", false);
        }
    }
}
