using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    [SerializeField] GameObject parent;
    public Material mater;
    // Update is called once per frame
    void Update()
    {
        if (parent.tag == "Player")
        {
            gameObject.GetComponent<SkinnedMeshRenderer>().material = mater;
        }
    }
}
