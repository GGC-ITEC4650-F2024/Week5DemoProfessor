using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float power;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) {
            GameObject g = Instantiate(bulletPrefab, transform.position, transform.rotation);
            Rigidbody r = g.GetComponent<Rigidbody>();
            r.velocity = transform.forward * power;
        }
    }
}
