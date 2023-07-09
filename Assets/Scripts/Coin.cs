using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    private float rotateSpeed=1.0f;
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
