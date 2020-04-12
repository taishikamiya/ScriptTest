using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
	private int hp = 100;
	private int mp = 53;
	private int power = 25;

    public void Attack()
    {
		Debug.Log(this.power + "のダメージを与えた");

    }
    public void Defence(int damage)
    {
		Debug.Log(damage + "のダメージを受けた");
		this.hp -= damage;
    }

    public void Magic()
    {
        if (this.mp >= 5)
        {
			this.mp -= 5;
			Debug.Log("魔法攻撃した。残りMPは" + this.mp + "。");
		}
        else
        {
			Debug.Log("MPが足りないため魔法が使えない。");
        }
	}
}

public class Test : MonoBehaviour {


	// Use this for initialization
	void Start () {

        //要素数5のint型array
		int[] array = { 10, 20, 30, 40, 50 };

        //順番に表示
        for(int i = 0; i < array.Length; i++)
        {
			Debug.Log(array[i]);
        }

        //逆順で表示
        for(int i = array.Length - 1; i >= 0; i--)
        {
			Debug.Log(array[i]);
        }


		Boss lastboss = new Boss();

		//lastboss.Attack();
		//lastboss.Defence(3);

        // 10回繰り返しMagic呼び出し
        for(int i = 0; i < 10; i++)
        {
			lastboss.Magic();
		}
        //+1回
        Debug.Log("11回目");
        lastboss.Magic();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
