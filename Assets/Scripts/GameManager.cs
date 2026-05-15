using UnityEngine;

public class GameManager : MonoBehaviour
{
   VectorM2 vectorTest = new VectorM2(4, 5);
   VectorM2 vectorTest2 = new VectorM2(-2, 1);

    void Start()
    {
        Debug.Log(vectorTest.Magnitude());
        Debug.Log(vectorTest.Normalize().Magnitude());
        Debug.Log(VectorM2.Dot(vectorTest, vectorTest2));
        Debug.Log(VectorM2.Angle(vectorTest, vectorTest2));
    }

    void Update()
    {
        VectorM2 vectorTest = new VectorM2(4, 5);
        VectorM2 vectorTest2 = new VectorM2(-2, 1);
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector3.zero, new Vector3(vectorTest.x, vectorTest.y, 0));
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(Vector3.zero, new Vector3(vectorTest2.x, vectorTest2.y, 0));

    }


}
