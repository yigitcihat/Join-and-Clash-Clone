using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    int i = 0;
    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Düşmanla temas sağlandı");
            Destroy(this.gameObject);
            Destroy(other.contacts[0].otherCollider.transform.gameObject);
        }
    }
}
