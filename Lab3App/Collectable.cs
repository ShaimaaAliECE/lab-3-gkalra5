﻿using Lab3App;
using Lab3App.Lab3App;
using System;
using System.Collections.Generic;

public abstract class Collectable : Displayable
{
    public string Description { get; set; }
    public CollectionBoard Board { get; set; }
    protected Collectable(string description)
    {
        Description = description;
    }

    public virtual void AddMe(List<Collectable> list)
    {
        list.Add(this);
        Console.WriteLine($"{Description} Collected, Congrats!!!");

    }
    public abstract void Display();
}