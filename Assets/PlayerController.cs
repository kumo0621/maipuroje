using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        // 初期化処理が必要ならここに書きます
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // プレイヤーの移動を処理
        MovePlayer();
    }

    void MovePlayer()
    {
        // 入力を取得
        float moveHorizontal = Input.GetAxis("Horizontal");
        float linearVelocit = Input.GetKeyDown("KeCode.Space");
       //float moveVertical = Input.GetAxis("Vertical");

        // 移動方向を決定
       Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);

        // プレイヤーを移動させる
        Vector2 linearVelocity = rb2D.linearVelocity;
        linearVelocity.y = moveHorizontal  * speed;
        rb2D.linearVelocity = linearVelocity;
    }
}