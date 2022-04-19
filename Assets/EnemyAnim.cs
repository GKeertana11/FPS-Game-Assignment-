using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnim : MonoBehaviour
{
    Animator anim;
    public Transform target;
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
        anim.SetBool("Move", true);

        if(Vector3.Distance(target.position,this.transform.position)<15f)
        {
            state = STATE.ATTACK;
        }
    }

    public void Attack()
    {
        anim.SetBool("Attack", true);
    }

    public void Damage()
    {
       
    }
    public void Win()
    {

    }
}
