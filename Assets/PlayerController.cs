using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    Animator anim;
    public GameObject bullet;

    public Transform bulletPoint;

    // Start is called before the first frame update
    void Start()
    {
        anim = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.F))
        {
            anim.SetBool("Fire", true);
            anim.SetBool("Reload", false);
            WhenPlayerHitEnemy();

        }
        if (Input.GetKey(KeyCode.R))
        {

            anim.SetBool("Fire", false);

            anim.SetBool("Reload", true);
        }
    }
    private void WhenPlayerHitEnemy()
    {
        RaycastHit hitInformation;
        if (Physics.Raycast(bulletPoint.position, bulletPoint.forward, out hitInformation, 100f))
        {
            Instantiate(bullet, bulletPoint.transform.position, Quaternion.identity);
            GameObject hitEnenimes = hitInformation.collider.gameObject;
            if (hitEnenimes.tag == "Enemy")
            {
                Debug.Log("Dead");
                hitEnenimes.GetComponent<EnemyAnim>().Damage();

            }
        }
    }
}
