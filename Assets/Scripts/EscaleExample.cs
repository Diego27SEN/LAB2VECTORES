using UnityEngine;

public class EscaleExample : MonoBehaviour
{
    //UNITY SCALE
    //public float escaleFactor = 2f;

    public float frequency = 2f;
    public float amplitude = 0.5f;

    private void Update()
    {
        //UNITY SCALE
        // transform.localScale = new Vector3 (escaleFactor, escaleFactor, escaleFactor);

        //MANUAL SCALE
        //Matrix4x4 localMatrix = Matrix4x4.identity;
        //localMatrix[0, 0] = escaleFactor.x;
        //localMatrix[1, 1] = escaleFactor.y;
        //localMatrix[2, 2] = escaleFactor.z;

        //transform. localScale = localMatrix. lossyScale;

        //PULSE SCALE

        float mult = 1 + Mathf.Sin(Time.time * frequency) * amplitude;

        transform.localScale = Vector3.one * mult;

    }
}
