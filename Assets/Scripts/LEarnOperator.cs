using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEarnOperator : MonoBehaviour
{
    private float a = 10;
    private float b = 3;

    private float c = 99;
    private float d = 1;

    private int jue = 3;
    private int hp = 100;
    private void Start()
  {
         
        // �[�k +
        // ��v -
        // ���k *
        // ���k /
        // �l�� %
        print("�[�k" + (a + b));
        print("��k" + (a - b));
        print("���k" + (a * b));
        print("���k" + (a / b));
        print("�l��" + (a % b));



        //  �p�� <
        //  �j�� >
        //  �p�󵥩� <=
        //  �j�󵥩� >=
        //  ������ !=
        //  ���� ==

        print ("�p��" + (a < b)); //f
        print ("�j��" + (a > b)); //t
        print ("�p�󵥩�" + (a <= b)); //f
        print ("�j�󵥩�" + (a >= b)); //t
        print ("������" + (a != b)); //t
        print ("����" + (a == b)); //f

        // �޿�B��
        // && ��f�hf 
        // || ��t�ht
        print("ture && ture" + (true && true)); //t
        print("ture && false" + (true && false)); //f
        print("false && ture" + (false && true)); //f
        print("false && false" + (false && false)); //f

        print("ture || ture" + (true || true)); //t
        print("ture  || false" + (true || false)); //t
        print("false  || ture" + (false || true));//t
        print("false  || false" + (false || false));//f



        // �C���q���d��
        // �_�ۻݤj��T���A��q�ݤj��0�C��i�q��
        print("�O�_�q�� : " + (jue >= 0 && hp > 0));

        //�A���޿�B��
        print("!true : " + (!true));
        print("!false : " + (!false));
    
    }













    
}
