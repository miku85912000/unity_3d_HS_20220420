using UnityEngine;

    //MonoBehaviour

public class LearnMethod : MonoBehaviour
{
    private void Start()
    {
        // �I�s��k
        // ��k�W��()
        Test();
        PrintColorText();
    }
    // ��k�y�k
    // �Ǧ^���� ��k�ۭq�W��(){��k���e}
    // �L�Ǧ^void
    // ��k�W��unity�ߺD�Τj�g�}�Y
    private void Test()
    {
        //��X(���e)
        print("hello world");
    }
    // �ۭq��k
    // �ݭn�I�s�~�|����

    // unity���J�f
    // �}�l�ƥ�
    // ����C����|����@��
    // ��l�Ƴ]�w: ��l���B �T���R����
    private void PrintColorText()
    {
        print( "<color=yellow>����T��</color>" );
        print( "<color=red>red�T��</color>" );
        print( "<color=#003399>�Ŧ�T��</color>" );

    }
}
