using System.Collections.Generic;
using UnityEngine;

public static class GlobalStore
{
    public static bool onDialog = false;
    public static List<string> ActiveDialog = new List<string> {""};
    public static Vector2 PlayerPosition;
}