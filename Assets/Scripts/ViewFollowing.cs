using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewFollowing : MonoBehaviour
{

    public Transform target;
    public float soomthspeed = 0.125f;
    public Vector3 offset;
    public Vector3 offset_inverted;
    public bool isFollowing = true;


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.position;
        transform.position = target.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFollowing)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, soomthspeed);
            transform.position = smoothedPosition;
        }else{
            offset_inverted = new Vector3(transform.position.x * -1.0f - target.position.x, offset.y, offset.z);
            Vector3 desiredPosition = target.position + offset_inverted;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, soomthspeed);
            transform.position = smoothedPosition;
        }
    }
}
