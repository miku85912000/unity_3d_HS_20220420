
using UnityEngine;

public class Car : MonoBehaviour
{
    // 汽車藍圖 >物件
    // 場頸上的遊戲物件
    // 添加元件
    // 選取此類別

    // 欄位語法
    // 修飾詞 資料類型 欄位自訂名稱 指定 值 結束符號
    // 修飾此資料的存取全縣

    // 兩大基本修飾詞
    // 公開 : 允許外部存取，顯示在屬性面板
    // public
    // 私人 : 不允許外部存取，不顯示在屬性面板(預設值可省略
    // private

    // 1. unity 以屬性面板資料為主
    // 2. 還原到城市內的值必須按...>reset

    // 欄位屬性語法
    // [屬性名稱(值)]

    // 1. 提示 Tooltip
    // 2. 標題 header
    // 3. 範圍 range
    [Range (1,50)]
    [Tooltip("汽車的重量，單位是噸")]

    public int weight = 3;

    [Header("汽車的高度"), Range(1,10)]
    public float height = 3.5f;

    [Header("汽車的品牌名稱")]

    public string brand = "banz";

    [Header("是否有天窗")]
    [Tooltip("設定汽車是否有天窗")]

    public bool hasskywindow = true;
}
// abcdefghijklmnopqrstuvwxyz
// abcdefghijklmnopqrstuvwxyz
// abcdefghujklmnopqrstuvwxyz
// abcdefgh8jklmnioqrtuvwxyz
