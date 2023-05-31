using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CibleController : MonoBehaviour
{
    public float rotationSpeed = 1f;
    
    private void FixedUpdate() {
        transform.eulerAngles -= Vector3.forward * rotationSpeed;
    }
    
}
