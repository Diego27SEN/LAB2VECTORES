using System.Transactions;
using UnityEngine;

public class SpinExample : MonoBehaviour
{
   // public float spinSpeed = 90f; // Degrees per second

   // public float totalAngle = 0f;
   public float quaternionSpeed = 100f; // Degrees per second


    void Update()
    {
        //transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);

        // totalAngle *= 45f * Time.deltaTime;
        //float rad = totalAngle * Mathf.Deg2Rad;

        // Matrix4x4 localMatrix = Matrix4x4.identity;
        //localMatrix[0, 0] = Mathf.Cos(rad);
        // localMatrix[0, 2] = -Mathf.Sin(rad);
        //localMatrix[2, 0] = Mathf.Sin(rad);
        //localMatrix[2, 2] = Mathf.Cos(rad);

        //transform.rotation = localMatrix.rotation; 

        // QUATERNION   ROTATION

        Quaternion frameRotation = Quaternion.Euler(0, quaternionSpeed * Time.deltaTime, 0);
        transform.rotation = frameRotation * transform.rotation;

    }
}
