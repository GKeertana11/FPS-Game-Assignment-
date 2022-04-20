using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoSpawner : MonoBehaviour
{
    public float time;
    public GameObject ammo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        time = time + Time.deltaTime;
        float x = Random.Range(799f, 235f);
        float z = Random.Range(799f, 235f);


        if (time > 5f)
        {
            Instantiate(ammo, new Vector3(x, 0.5f, z), Quaternion.identity);
            time = 0f;
        }

    }
}
