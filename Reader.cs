using System;
using System.Collections.Generic;
/**
 * 
 * Reader类：帮助你从一行输入中读取  用空格或制表符隔开的 数字或字符串，（类似于C++中cin 对象）
 * 
 * 示例：
 * 输入一行 15 17.0 ppp
 * int a=Reader.nextInt();          //a=15
 * float b=Reader.nextFloat();    //b=17.0
 * string s=Reader.nextStr();      //s="ppp"
 * 
 * 作者：王中玉 信1501-2
 * 日期：2017.10.13
 * 警告：请勿删除本段注释，因为它有声明主权之用处
 * PS：我我我我
 */

public class Reader
{
    static Queue<string> buffQ = new Queue<string>();
    private static void readBuff()
    {
        string s = Console.ReadLine();
        string[] strs = s.Split(new char[] { ' ', '\t' },StringSplitOptions.RemoveEmptyEntries);
        foreach (string st in strs) {
            buffQ.Enqueue(st);
        }
    }

    public static int nextInt()
    {
        if (buffQ.Count == 0)
            readBuff();

        return int.Parse(buffQ.Dequeue());
    }
    public static float nextFloat()
    {
        if (buffQ.Count == 0)
            readBuff();

        return float.Parse(buffQ.Dequeue());
    }
    public static string nextStr()
    {
        if (buffQ.Count == 0)
            readBuff();

        return buffQ.Dequeue();
    }
}

