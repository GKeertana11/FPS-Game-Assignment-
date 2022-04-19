using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.F))
            {
            anim.SetBool("Fire", true);
            anim.SetBool("Reload", false);
           }
        if(Input.GetKey(KeyCode.R))
        {
            anim.SetBool("Fire", false);
            anim.SetBool("Reload", true);
        }
    }
}
