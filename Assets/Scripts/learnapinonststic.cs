
using UnityEngine;

/// <summary>
/// �ǲ� �D�R�Aapi
/// api ���W�S��static
/// </summary>
public class learnapinonststic : MonoBehaviour
{
    public Transform Tra1;
    public Light lightA;
    public Transform Tra2;
    void Start()
    {
        // �D�R�A�ݩ� properties
        // 1. get
        //  ����
        //  - �����O�������
        // -���骫��
        // ���s����骫��
        // - ���W��,�D�R�A�ݩʦW��
        //
        Debug.Log("�ؼЮy��:" + Tra1.position);
        print("�� �C��:" + lightA.color);





        Tra1.position = new Vector3(1, 1, 2f);
        lightA.color = new Color(1,1,1);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Q)) 
        { 
            Tra2.Rotate(0, 10, 0); 
        }

    }
}