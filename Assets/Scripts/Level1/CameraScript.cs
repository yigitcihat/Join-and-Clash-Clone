using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] GameObject _player;
    Vector3 _distance;
    Vector3 _distanceNow;
    public bool _check = false;
 

    void Start()
    {
        _distance = new Vector3(0,transform.position.y,transform.position.z - _player.transform.position.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_check == false)
        {
            cameraFollowing();
        }

    }
    private void cameraFollowing()
    {

        _distanceNow = new Vector3(0, transform.position.y, transform.position.z - _player.transform.position.z);
        if (_distanceNow != _distance)
        {
            Vector3 _difference = _distance - _distanceNow;
            transform.position = Vector3.Lerp(transform.position, transform.position + _difference, 0.1f);
        }


    }

}