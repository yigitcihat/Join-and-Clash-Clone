using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TeamMemberNavMeshController : MonoBehaviour
{

    public GameObject _player;
    [SerializeField] GameObject other;
    public Animator anim;
    public Material material;
    private Touch theTouch;
    private void Start()
    {

        anim = GetComponent<Animator>();

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            _player.gameObject.tag = "Player";
            anim.SetBool("isRunning", true);
            gameObject.GetComponent<SkinnedMeshRenderer>().material = material;
            _player.transform.parent = other.transform;

            theTouch = Input.GetTouch(0);

            if (Input.touchCount > 0)
            {
                anim.SetBool("isRunning", true);

            }

        }

    }
    
}
