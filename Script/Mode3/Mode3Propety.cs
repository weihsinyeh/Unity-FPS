using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mode3Propety : MonoBehaviour
{
    private static int property_ball3, property_ball4, property_ball5;
    static public void set_property_ball3(int change)
    {
        property_ball3 = change;
    }
    static public int get_property_ball3()
    {
        return property_ball3;
    }
    static public void set_property_ball4(int change)
    {
        property_ball4 = change;
    }
    static public int get_property_ball4()
    {
        return property_ball4;
    }
    static public void set_property_ball5(int change)
    {
        property_ball5 = change;
    }
    static public int get_property_ball5()
    {
        return property_ball5;
    }
}
