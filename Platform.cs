using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Platform : MonoBehaviour
    {
    public float speed;
    public Vector3 direction;
    public bool isActive;


    public void Update()
    {
        {
            if (!isActive) {
                transform.position += direction * speed * Time.deltaTime;
            }
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isActive = true;
        }
        if (other.tag == "PlatformStop")
        {
            direction *= -1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isActive = false;
        }
    }

}
