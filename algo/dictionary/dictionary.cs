using System;
using System.Collections.Generic;

public class Dict {

    public void PMain() {
        //Dictionary<key, value>
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        //add element to Dictionary
        Add(1, "Apple", dictionary);
        Add(2, "Banana", dictionary);
        Add(3, "Orange", dictionary);

        Show(dictionary);
    }

    public void Add(int key, string value, Dictionary<int, string> dictionary) {
        dictionary.Add(key, value);
    }

    public void Show(Dictionary<int, string> dictionary) {
        foreach (var item in dictionary) {
            Console.WriteLine($"Key: {item.Key} & Value: {item.Value}");
        }
    }
}