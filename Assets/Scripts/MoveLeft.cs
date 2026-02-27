using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;
    private PlayerController player; //มีไว้เก็บข้อมูล

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>(); //ใน player จะหา "Player" แล้วหา Component สคริป PlayerController
    }

    void Update()
    {
        //GameObject go = GameObject.Find("Player");
        //PlayerController player = go.GetComponent<PlayerController>();
        if (!player.isGameOver)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }
    }
}
