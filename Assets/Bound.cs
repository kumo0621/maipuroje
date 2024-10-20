using UnityEngine;

public class StopOnCollision : MonoBehaviour
{
    private Rigidbody2D rb2D;

    void Start()
    {
        // Rigidbody2Dコンポーネントを取得
        rb2D = GetComponent<Rigidbody2D>();
    }

    // 他のオブジェクトに衝突したときに呼び出される
    void OnCollisionEnter2D(Collision2D collision)
    {
        // 衝突した際に速度をゼロにする
        rb2D.linearVelocity = Vector2.zero;
    }
}
