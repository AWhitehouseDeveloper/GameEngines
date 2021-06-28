using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2;
    public GameObject shot;

    Vector2 input;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

        transform.Translate(input * speed * Time.deltaTime);

        if (Input.GetButtonDown("Fire1"))
        {
            OnFire();
        }
    }

    void OnFire()
    {
        Instantiate(shot, transform.position, Quaternion.identity);
    }
}
