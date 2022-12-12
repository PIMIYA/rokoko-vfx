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
            if(transform.position.x > 0){
                offset_inverted = new Vector3(transform.position.x +0.125f, transform.position.y, transform.position.z);
                Vector3 smoothedPosition = Vector3.Lerp(transform.position, offset_inverted, soomthspeed);
                transform.position = smoothedPosition;
            }
            //offset_inverted = new Vector3(transform.position.x * 1.0f - target.position.x, target.position.y, offset.z);
            // Vector3 desiredPosition = target.position + offset_inverted;
            // Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, soomthspeed);
            // transform.position = smoothedPosition;
        }
    }
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class ViewFollowing : MonoBehaviour
// {

//     public Transform target;
//     public Transform dummy;
//     public float soomthspeed = 0.125f;
//     public float cor_L = 1.0f;
//     public float cor_R = 1.0f;
//     public Vector3 offset;
//     public Vector3 correction_offset;
//     public Vector3 previous_position;
//     public bool isFollowing = true;
//     public bool mirror = false;


//     // Start is called before the first frame update
//     void Start()
//     {
//         offset = transform.position - target.position;
//         transform.position = target.transform.position + offset;
//         dummy.position = target.position;
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         previous_position = target.position;
//         if (isFollowing)
//         {
//             Vector3 desiredPosition = target.position + offset;
//             Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, soomthspeed);
//             transform.position = smoothedPosition;
//             dummy.position = target.position;
//         }else{
//             if(target.position.x - previous_position.x > 0){
//                 Vector3 desiredPosition = target.position + offset;
//                 correction_offset = new Vector3(target.position.x * cor_L, target.position.y, target.position.z);
//             }
//             else{
//                 Vector3 desiredPosition = target.position + offset;
//                 correction_offset = new Vector3(target.position.x * cor_R, target.position.y, target.position.z);  
//             }
//             dummy.position = correction_offset;
//             // offset_inverted = new Vector3(transform.position.x * -1.0f - target.position.x, offset.y, offset.z);
//             // Vector3 desiredPosition = target.position + offset_inverted;
//             // Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, soomthspeed);
//             // transform.position = smoothedPosition;
//         }
//     }
// }
