using UnityEngine;

public class TranslateExample : MonoBehaviour
{
    
    public float speed = 5f;
    //private void Update()
    //{
    //    transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
    //}

    private void Update()
    {
        Vector3 dir = new Vector3(0, 1, 0);
        Vector3 globaldir = transform.TransformDirection(dir);
        transform.Translate(globaldir * speed * Time.deltaTime, Space.World);
    }
}
