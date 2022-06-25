using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LuaFramework;
using LuaInterface;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaState ls = new LuaState();
        ls.Start();
        LuaBinder.Bind(ls);
        ls.Require("Game");
        ls.Call("InitGame", false);
        ls.Dispose();
    }
}
