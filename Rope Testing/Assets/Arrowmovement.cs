using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrowmovement : MonoBehaviour
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

        if (Input.GetKey(KeyCode.UpArrow)) vertical = 1f;
        if (Input.GetKey(KeyCode.DownArrow)) vertical = -1f;
        if (Input.GetKey(KeyCode.RightArrow)) horizontal = 1f;
        if (Input.GetKey(KeyCode.LeftArrow)) horizontal = -1f;

        Vector3 movement = new Vector3(horizontal, vertical, 0f).normalized;

        transform.Translate(movement * speed * Time.deltaTime);


    }
}
