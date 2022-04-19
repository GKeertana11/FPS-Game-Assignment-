using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAnim : MonoBehaviour
{
    Animator anim;
   // public GameObject player;
    public Transform target;
    NavMeshAgent agent;
    public enum STATE
    {
        MOVE,
        ATTACK,
        DAMAGE,
        WIN
    }
    public STATE state = STATE.MOVE;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case STATE.MOVE:
                Move();
                break;
            case STATE.ATTACK:
                Attack();
                break;
            case STATE.DAMAGE:

                break;
            case STATE.WIN:
                break;
            default:
                break;
        }
    }

    public void Move()
    {
        anim.SetBool("Run", true);
        

        if(Vector3.Distance(target.position,this.transform.position)<15f)
        {
            state = STATE.ATTACK;
        }
        
    }

    public void Attack()
    {
       anim.SetBool("Run", false);
        anim.SetBool("Attack", true);
    }

    public void Damage()
    {
        anim.SetBool("Damage", true);
    }
    public void Win()
    {

    }

}
