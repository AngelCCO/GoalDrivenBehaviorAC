﻿public class Nurse : GAgent 
{
    new void Start() 
    {
        base.Start();
        SubGoal s1 = new SubGoal("treatPatient", 1, true);
        goals.Add(s1, 3);
    }

}