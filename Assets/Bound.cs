using UnityEngine;

public class StopOnCollision : MonoBehaviour
{
    private Rigidbody2D rb2D;

    void Start()
    {
        // Rigidbody2D�R���|�[�l���g���擾
        rb2D = GetComponent<Rigidbody2D>();
    }

    // ���̃I�u�W�F�N�g�ɏՓ˂����Ƃ��ɌĂяo�����
    void OnCollisionEnter2D(Collision2D collision)
    {
        // �Փ˂����ۂɑ��x���[���ɂ���
        rb2D.linearVelocity = Vector2.zero;
    }
}
