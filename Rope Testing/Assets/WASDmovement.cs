using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WASDmovement : MonoBehaviour
{
    float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0f;
        float vertical = 0f;

        if (Input.GetKey(KeyCode.W)) vertical = 1f;
        if (Input.GetKey(KeyCode.A)) vertical = -1f;
        if (Input.GetKey(KeyCode.S)) horizontal = 1f;
        if (Input.GetKey(KeyCode.D)) horizontal = -1f;

        Vector3 movement = new Vector3(horizontal, vertical, 0f).normalized;

        transform.Translate(movement * speed * Time.deltaTime);


    }
}
