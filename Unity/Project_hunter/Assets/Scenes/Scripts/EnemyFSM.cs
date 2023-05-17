using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFSM : MonoBehaviour
{
    enum EnemyState
    {
        Idle,
        Move,
        Attack,
        Return,
        Damaged,
        Die
    }

    EnemyState m_State;
    public float findDistance = 8f;
    Transform player;

    public float attackDistance = 2f;
    public float moveSpeed = 5f;
    CharacterController cc;

    float currentTime = 0;
    float attackDelay = 2f;

    public int attackPower = 3;

    Vector3 originPos;

    public float moveDistance = 20f;

    public int hp = 15;
    int maxHp = 15;

    // Start is called before the first frame update
    void Start()
    {
        m_State = EnemyState.Idle;
        player = GameObject.Find("Player").transform;
        cc = GetComponent<CharacterController>();
        originPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        switch(m_State)
        {
            case EnemyState.Idle:
                Idle();
                break;
            case EnemyState.Move:
                Move();
                break;
            case EnemyState.Attack:
                Attack();
                break;
            case EnemyState.Return:
                Return();
                break;
            case EnemyState.Damaged:
                Damaged();
                break;
            case EnemyState.Die:
                Die();
                break;
        }

        void Idle()
        {
            if(Vector3.Distance(transform.position, player.position) < findDistance)
            {
                m_State=EnemyState.Move;
                print("상태 전환: Idle -> Move");
            }
        }

        void Move()
        {
            if (Vector3.Distance(transform.position, originPos) > moveDistance)
            {
                m_State = EnemyState.Return;
                print("상태 전환: Move -> Return");
            }

            else if (Vector3.Distance(transform.position, player.position) > attackDistance)
            {
                Vector3 dir = (player.position - transform.position).normalized;
                cc.Move(dir*moveSpeed*Time.deltaTime);
            }
            else
            {
                m_State = EnemyState.Attack;
                print("상태 전환: Move -> Attack");

                currentTime = attackDelay;
            }
        }

        void Attack()
        {
            if (Vector3.Distance(transform.position, player.position) < attackDistance)
            {
                currentTime += Time.deltaTime;
                if (currentTime > attackDelay)
                {
                    player.GetComponent<PlayerMove>().DamageAction(attackPower);
                    print("공격");
                    currentTime = 0;
                }
            }
            else
            {
                m_State = EnemyState.Move;
                print("상태 전환: Attack -> Move");
                currentTime = 0;
            }
        }

        void Return()
        {
            if(Vector3.Distance(transform.position, originPos) > 0.1f)
            {
                Vector3 dir = (originPos - transform.position).normalized;
                cc.Move(dir * moveSpeed * Time.deltaTime);
            }
            else
            {
                transform.position = originPos;
                hp = maxHp;
                m_State = EnemyState.Idle;
                print("상태 전환: Return -> Idle");
            }
        }

        void Damaged()
        {

        }

        void Die()
        {

        }
    }
}
