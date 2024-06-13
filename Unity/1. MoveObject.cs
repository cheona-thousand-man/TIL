using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveObject : MonoBehaviour
{
    public float speedMove = 1;
    public float speedRotate = 1;
    Vector3 right = new Vector3(0, 1, 0);
    Vector3 forward = new Vector3(0, 0, 1);

    // Start is called before the first frame update
    void Start()
    {
        //v3 = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //float positionVertical, positionHorizontal;
        //positionVertical = Input.GetAxis("Vertical");
        //positionHorizontal = Input.GetAxis("Horizontal");

            //positionVertical = positionVertical * speed * Time.deltaTime;
            //transform.Translate(Vector3.forward * positionVertical);

            //positionHorizontal = positionHorizontal * speed * Time.deltaTime;
            //transform.Translate(Vector3.right * positionHorizontal);


            //transform.Rotate(Vector3.up * positionVertical);
            //transform.Rotate(Vector3.right * positionHorizontal);

            //transform.Translate(v3);

            //if (Input.GetKey(KeyCode.LeftArrow))
            //{
            //    transform.Rotate(v3);
            //}
            //else if (Input.GetKey(KeyCode.RightArrow))
            //{
            //    transform.Rotate(-v3);
            //}
        if (Input.GetButton("Jump"))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 1, 0));
        }

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    v3.y = 0.1f;
        //    v3.x = 0;
        //    //transform.Rotate(v3);
        //    transform.Translate(v3);
        //}
        //else if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    v3.y = -0.1f;
        //    v3.x = 0;
        //    //transform.Rotate(v3);
        //    transform.Translate(v3);
        //}
        //else if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    v3.y = 0;
        //    v3.x = 0.1f;
        //    //transform.Rotate(v3);
        //    transform.Translate(v3);
        //}
        //else if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    v3.y = 0;
        //    v3.x = -0.1f;
        //    //transform.Rotate(v3);
        //    transform.Translate(v3);
        //}

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        h = h * Time.deltaTime;
        v = v * Time.deltaTime;
        transform.Translate(forward * h * speedMove);
        transform.Rotate(right * v * speedRotate * 10);
    }
}
