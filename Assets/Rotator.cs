using UnityEngine;

public class Rotator : MonoBehaviour
{
    private readonly Vector3 _rotation = new Vector3(15, 30, 45);

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(_rotation * Time.deltaTime);
    }
}