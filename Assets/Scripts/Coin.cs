using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotateSpeed=0.5f;
    public AudioSource coinFX;
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0,Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        Collectable.count += 1;
        this.gameObject.SetActive(false);
    }
}
