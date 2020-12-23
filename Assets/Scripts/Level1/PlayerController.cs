using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float moveSpeed = 3f;
	public GameObject character;

	private Rigidbody characterBody;
	private Touch theTouch;
	private Vector2 touchStartPosition, touchEndPosition;
	public bool theyAreRunning;

	public Animator anim;
	void Start()
	{
		characterBody = character.GetComponent<Rigidbody>();
		anim = GetComponent<Animator>();
	}

	void FixedUpdate()
	{
		
		if (Input.touchCount > 0)
		{
			
			theTouch = Input.GetTouch(0);
			characterBody.velocity = new Vector3(1 * Time.deltaTime , 0, 10 * Time.deltaTime * moveSpeed);
			anim.SetBool("isRunning", true);
			if (Input.touchCount > 0)
			{
				if (theTouch.phase == TouchPhase.Began )
				{
					theyAreRunning = true;
					touchStartPosition = theTouch.position;

				}
				
				else if (theTouch.phase == TouchPhase.Moved)
				{
					touchEndPosition = theTouch.position;

					float x = touchEndPosition.x - touchStartPosition.x;
					float y = touchEndPosition.y - touchStartPosition.y;

					characterBody.velocity =new Vector3(x * Time.deltaTime , y, 10 * Time.deltaTime * moveSpeed);
					theyAreRunning = true;
				}
                else if (theTouch.phase == TouchPhase.Ended)
                {
					anim.SetBool("isRunning", false);
				}
                
			}

		}
        else
        {
			characterBody.velocity = Vector3.zero;
			
			theyAreRunning = false;

		}
	}
	public void CollisionDetected(TeamMemberNavMeshController childScript)
	{
		Debug.Log("child collided");
	}

}