using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeHandler : MonoBehaviour
{
    public KnifeHandler Instance;
    private Rigidbody2D _rb;
    public float knifeSpeed = 10f;

    private void Awake() {
        Instance = this;
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Cible")
        {
            //J'ai touché la cible
            _rb.velocity = Vector2.zero;
        }
    }

    public void ThrowKnife()
    {
        try
        {
             _rb.velocity = Vector2.up * knifeSpeed;
        }
        catch (System.Exception)
        {
            Debug.LogError("Error while setting Knife's velocity");
            throw;
        }
    }
}
