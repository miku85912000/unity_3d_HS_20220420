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
         
        // 加法 +
        // 減髮 -
        // 乘法 *
        // 除法 /
        // 餘數 %
        print("加法" + (a + b));
        print("減法" + (a - b));
        print("乘法" + (a * b));
        print("除法" + (a / b));
        print("餘數" + (a % b));



        //  小於 <
        //  大於 >
        //  小於等於 <=
        //  大於等於 >=
        //  不等於 !=
        //  等於 ==

        print ("小於" + (a < b)); //f
        print ("大於" + (a > b)); //t
        print ("小於等於" + (a <= b)); //f
        print ("大於等於" + (a >= b)); //t
        print ("不等於" + (a != b)); //t
        print ("等於" + (a == b)); //f

        // 邏輯運算
        // && 有f則f 
        // || 有t則t
        print("ture && ture" + (true && true)); //t
        print("ture && false" + (true && false)); //f
        print("false && ture" + (false && true)); //f
        print("false && false" + (false && false)); //f

        print("ture || ture" + (true || true)); //t
        print("ture  || false" + (true || false)); //t
        print("false  || ture" + (false || true));//t
        print("false  || false" + (false || false));//f



        // 遊戲通關範例
        // 寶石需大於三顆，血量需大於0。方可通關
        print("是否通關 : " + (jue >= 0 && hp > 0));

        //顛倒邏輯運算
        print("!true : " + (!true));
        print("!false : " + (!false));
    
    }













    
}
