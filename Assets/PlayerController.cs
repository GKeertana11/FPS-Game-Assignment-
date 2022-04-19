using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    Animator anim;
    public GameObject bullet;

    public Transform bulletPoint;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        anim = player.GetComponent<Animator>();
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Fire");
            anim.SetBool("Reload", false);
            RaycastHit Hitinfo;
            Vector3 point = new Vector3(cam.pixelWidth / 2, cam.pixelHeight / 2, 0);
            Ray ray = cam.ScreenPointToRay(point);

            if (Physics.Raycast(ray.origin, ray.direction, out Hitinfo))
            {
                Debug.Log(Hitinfo.transform.tag);
                if (Hitinfo.transform.tag == "Enemy")
                {
                    Destroy(Hitinfo.transform.gameObject);
                }



            }
        }
        if (Input.GetKey(KeyCode.R))
        {

           // anim.SetBool("Fire", false);

            anim.SetBool("Reload", true);
        }
    }
  /*  private void WhenPlayerHitEnemy()
    {
        /*  RaycastHit hitInformation;
          if (Physics.Raycast(bulletPoint.position, bulletPoint.forward, out hitInformation, 100f))
          {
              Instantiate(bullet, bulletPoint.transform.position, Quaternion.identity);
              GameObject hitEnenimes = hitInformation.collider.gameObject;
              if (hitEnenimes.tag == "Enemy")
              {
                  Debug.Log("Dead");
                  hitEnenimes.GetComponent<EnemyAnim>().Damage();

              }
          }*/
       
          /*  RaycastHit Hitinfo;
            Vector3 point = new Vector3(cam.pixelWidth / 2, cam.pixelHeight / 2, 0);
            Ray ray = cam.ScreenPointToRay(point);
            if (Physics.Raycast(ray.origin, ray.direction, out Hitinfo))
            {
                if (Hitinfo.transform.tag == "Enemy")
                {
                Debug.Log("destroyed");
                    Destroy(Hitinfo.transform.gameObject);
                }



            }*/
        }
    

