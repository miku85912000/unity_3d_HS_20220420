
using UnityEngine;

/// <summary>
/// 學習 非靜態api
/// api 文件上沒有static
/// </summary>
public class learnapinonststic : MonoBehaviour
{
    public Transform Tra1;
    public Light lightA;
    public Transform Tra2;
    void Start()
    {
        // 非靜態屬性 properties
        // 1. get
        //  條件
        //  - 該類別類型欄位
        // -實體物件
        // 欄位存放實體物件
        // - 欄位名稱,非靜態屬性名稱
        //
        Debug.Log("目標座標:" + Tra1.position);
        print("光 顏色:" + lightA.color);





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