using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float speed = 2;
    public GameObject shot;

    Gamepad gamepad;
    Vector2 input;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");*/

        transform.Translate(input * speed * Time.deltaTime);

        gamepad = Gamepad.current;
        if (gamepad == null) return;

        input = gamepad.leftStick.ReadValue();

        if (gamepad.buttonSouth.wasPressedThisFrame)
        {
            OnFire();
        }

            if (Input.GetButtonDown("Fire1"))
        {
            OnFire();
        }
    }

    public void OnMove(InputValue inputValue)
    {
        input = inputValue.Get<Vector2>();
    }

    void OnFire()
    {
        Instantiate(shot, transform.position, Quaternion.identity);
    }
}
