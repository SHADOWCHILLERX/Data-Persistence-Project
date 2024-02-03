using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public MenuUIHandler menuUIHandler;

    public float Speed = 2.0f;
    public float MaxMovement = 2.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        // Find the GameObject with MenuCanvas attached to it
        GameObject menuCanvasObject = GameObject.Find("Canvas");

        // Get the MenuUIHandler component attached to the GameObject
        menuUIHandler = menuCanvasObject.GetComponent<MenuUIHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (menuUIHandler.canPlay)
        {
            float input = Input.GetAxis("Horizontal");

            Vector3 pos = transform.position;
            pos.x += input * Speed * Time.deltaTime;

            if (pos.x > MaxMovement)
                pos.x = MaxMovement;
            else if (pos.x < -MaxMovement)
                pos.x = -MaxMovement;

            transform.position = pos;
        }
        
    }
}
