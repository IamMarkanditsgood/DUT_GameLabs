using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRotation : MonoBehaviour
{
    [SerializeField] private Transform target;
    // ???????? ????????
    [SerializeField] private float rotationSpeed = 1f;
    //??????? ???? ???????? (????? ?????? ?? ????????? ??? x=0)
    [SerializeField] private float deadZone = 0.1f;
    //??????????? ???????? ( "0" - ?? ???????, "1" - ?????? ? "-1" - ?????)
    private float rotateDirection = 0;

    void LateUpdate()
    {
        if (transform.InverseTransformPoint(target.position).x > deadZone / 2)
        {
            rotateDirection = -1f;
        }
        else if (transform.InverseTransformPoint(target.position).x < -deadZone / 2)
        {
            rotateDirection = 1f;
        }
        else
        {
            if (transform.InverseTransformPoint(target.position).y < 0)
            {
                rotateDirection = 1f;
            }
            else
            {
                rotateDirection = 0;
            }

        }
        transform.rotation *= Quaternion.Euler(0, 0, rotationSpeed * -rotateDirection);
    }
}
