
using UnityEngine;

public class Car : MonoBehaviour
{
    // �T���Ź� >����
    // ���V�W���C������
    // �K�[����
    // ��������O

    // ���y�k
    // �׹��� ������� ���ۭq�W�� ���w �� �����Ÿ�
    // �׹�����ƪ��s������

    // ��j�򥻭׹���
    // ���} : ���\�~���s���A��ܦb�ݩʭ��O
    // public
    // �p�H : �����\�~���s���A����ܦb�ݩʭ��O(�w�]�ȥi�ٲ�
    // private

    // 1. unity �H�ݩʭ��O��Ƭ��D
    // 2. �٭�쫰�������ȥ�����...>reset

    // ����ݩʻy�k
    // [�ݩʦW��(��)]

    // 1. ���� Tooltip
    // 2. ���D header
    // 3. �d�� range
    [Range (1,50)]
    [Tooltip("�T�������q�A���O��")]

    public int weight = 3;

    [Header("�T��������"), Range(1,10)]
    public float height = 3.5f;

    [Header("�T�����~�P�W��")]

    public string brand = "banz";

    [Header("�O�_���ѵ�")]
    [Tooltip("�]�w�T���O�_���ѵ�")]

    public bool hasskywindow = true;
}
// abcdefghijklmnopqrstuvwxyz
// abcdefghijklmnopqrstuvwxyz
// abcdefghujklmnopqrstuvwxyz
// abcdefgh8jklmnioqrtuvwxyz
