using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrowmovement : MonoBehaviour
{
    //float speed = 5f;
    //public float addForce = 1f;

    //public float moveForce = 10f; // 控制移动的力度
    //public Rigidbody rb;

    public float speed = 2.0f;
    public GameObject character;

    // Start is called before the first frame update
    void Start()
    {   
        //// 获取 Rigidbody 组件
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //float horizontal = 0f;
        //float vertical = 0f;

        //if (Input.GetKey(KeyCode.UpArrow)) vertical = 1f;
        //if (Input.GetKey(KeyCode.DownArrow)) vertical = -1f;
        //if (Input.GetKey(KeyCode.RightArrow)) horizontal = 1f;
        //if (Input.GetKey(KeyCode.LeftArrow)) horizontal = -1f;

        //Vector3 movement = new Vector3(horizontal, vertical, 0f).normalized;

        //transform.Translate(movement * speed * Time.deltaTime);

        // 获取箭头键输入
        //float moveHorizontal = Input.GetAxis("Horizontal"); // 左右方向键
        //float moveVertical = Input.GetAxis("Vertical"); // 上下方向键

        //// 计算力的方向
        //Vector3 force = new Vector3(moveHorizontal, 0f, moveVertical);

        //// 添加力到 Rigidbody
        //rb.AddForce(force * moveForce);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }


    }
}
