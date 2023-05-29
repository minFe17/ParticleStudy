using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] ParticleSystem _dust;
    [SerializeField] float _speed;

    Rigidbody2D _rigidbody;
    bool _isRight = true;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        bool isFlip = false;
        float x = Input.GetAxisRaw("Horizontal") * _speed;
        if (_rigidbody.velocity.x > 0 && x < 0)
        {
            if (_isRight == true)
            {
                _isRight = false;
                isFlip = true;
            }
        }
        else if (_rigidbody.velocity.x < 0 && x > 0)
        {
            if (_isRight == false)
            {
                _isRight = true;
                isFlip = true;
            }
        }
        else if (_rigidbody.velocity.x == 0 && x > 0)
        {
            if(_isRight == false)
            {
                _isRight = true;
                isFlip = true;
            }
        }
        else if(_rigidbody.velocity.x == 0 && x< 0)
        {
            if(_isRight == true)
            {
                _isRight = false;
                isFlip = true;
            }
        }
            _rigidbody.AddForce(Vector2.right * x);
        if (isFlip == true)
            Flip();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
            CreateDust();
        }
    }

    void Flip()
    {
        transform.Rotate(new Vector3(0, 180, 0));
        CreateDust();
    }

    void CreateDust()
    {
        _dust.Play();
    }
}
