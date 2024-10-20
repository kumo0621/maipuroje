using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        // �������������K�v�Ȃ炱���ɏ����܂�
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // �v���C���[�̈ړ�������
        MovePlayer();
    }

    void MovePlayer()
    {
        // ���͂��擾
        float moveHorizontal = Input.GetAxis("Horizontal");
        float linearVelocit = Input.GetKeyDown("KeCode.Space");
       //float moveVertical = Input.GetAxis("Vertical");

        // �ړ�����������
       Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);

        // �v���C���[���ړ�������
        Vector2 linearVelocity = rb2D.linearVelocity;
        linearVelocity.y = moveHorizontal  * speed;
        rb2D.linearVelocity = linearVelocity;
    }
}