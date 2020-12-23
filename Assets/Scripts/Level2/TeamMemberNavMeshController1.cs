using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TeamMemberNavMeshController1 : MonoBehaviour
{

    public GameObject _player;
    [SerializeField] GameObject other;
    public Animator anim;
    public Material material;
    private Touch theTouch;
    public float moveSpeed = 3f;
    private NavMeshAgent _playerTarget;
    public bool isTouch = false;
    private void Start()
    {
        _playerTarget = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
       
    }
    private void Update()
    {
        if (isTouch)
        {
            anim.SetBool("isRunning", true);

            _playerTarget.destination = other.transform.position;
            _playerTarget.speed = moveSpeed;

            theTouch = Input.GetTouch(0);

            if (Input.touchCount > 0)
            {
                anim.SetBool("isRunning", true);

            }
            
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            isTouch = true;

        }

    }
    
}
