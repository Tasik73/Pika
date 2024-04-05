using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float jumpForce = 10f; // ���� ������ �����
    private bool isGrounded = true; // ���������� ��� ����������� ���������� ����� �� �����


    void Update()
    {
        // �������� ���������� �� ����� � ��������� ������
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        // ���������� ���� ����� ��� ������
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpForce);
        isGrounded = false; 
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // ��� ��������������� � ������ isGrounded � true
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
