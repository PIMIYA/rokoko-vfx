using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewFollowing : MonoBehaviour
{

    public Transform target;
    public float soomthspeed = 0.125f;
    public Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + offset;
    }
}
