using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemyHp = 5f;          //적의 체력 
    public float moveSpeed = 2f;        //이동 속도
    private Transform player;           //플레이어 추적용

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;    
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) return;

        //플레이어까지의 방향 구하기
        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * moveSpeed * Time.deltaTime;
        transform.LookAt(player.position);
    }

    public void TakeDamage(float damage)
    {
        enemyHp -= damage; // 체력에서 데미지 깎기
        if (enemyHp <= 0)
        {
            Destroy(gameObject); // 체력이 0 이하면 적을 파괴합니다.
        }
    }

}
