using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public Text CountText;
    public Text WinText;

    private Rigidbody _rigidbody;
    private int _count;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _count = 0;
        SetCountText(_count);
        WinText.text = "";
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        _rigidbody.AddForce(movement * Speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pick-up"))
        {
            other.gameObject.SetActive(false);
            _count += 1;
            SetCountText(_count);
        }
        if (_count == 8)
        {
            WinText.text = "You win!";
        }       
    }

    private void SetCountText(int count)
    {
        CountText.text = "Count: " + count;
    }
}