using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private Animator mAvatar;
    // Start is called before the first frame update
    void Start()
    {
        mAvatar = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mAvatar.SetTrigger("ATTACK");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            mAvatar.SetTrigger("DEATH");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            mAvatar.SetTrigger("RUN");
        }
    }
}
