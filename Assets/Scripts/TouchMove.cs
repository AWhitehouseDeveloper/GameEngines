using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMove : MonoBehaviour
{
    private void OnEnable()
    {
        TouchManager.Instance.touchUpdateEvent += Move;
    }
    
    private void OnDisable()
    {
        if (TouchManager.Instance == null) return;
        TouchManager.Instance.touchUpdateEvent -= Move;
    }

    void Move(Vector2 postion)
    {
        Vector3 screen = new Vector3(postion.x, postion.y, 10);
        Vector3 world = Camera.main.ScreenToWorldPoint(screen);

        transform.position = world;
    }
}
