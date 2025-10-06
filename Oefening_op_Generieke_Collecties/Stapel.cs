using System;
using System.Collections.Generic;
using System.Text;

public class Stapel<T>
{
    private List<T> elementen;

    public Stapel()
    {
        elementen = new List<T>();
    }

    // Opzetten
    public void Opzetten(T item)
    {
        elementen.Add(item);
    }

    // Afhalen
    public T Afhalen()
    {
        if (elementen.Count == 0)
            throw new InvalidOperationException("De stapel is leeg!");

        T boven = elementen[^1]; // laatste element
        elementen.RemoveAt(elementen.Count - 1);
        return boven;
    }

    // Leegmaken
    public void Leegmaken()
    {
        elementen.Clear();
    }

    // ToString
    public override string ToString()
    {
        var sb = new StringBuilder();
        int indent = 0;

        for (int i = elementen.Count - 1; i >= 0; i--)
        {
            sb.AppendLine(new string(' ', indent * 2) + elementen[i]);
            indent++;
        }

        return sb.ToString();
    }
}