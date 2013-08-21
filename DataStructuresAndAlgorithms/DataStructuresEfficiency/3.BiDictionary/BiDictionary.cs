using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

public class BiDictionary<T, K, L>
{
    private MultiDictionary<T, L> firstKeyTable;
    private MultiDictionary<K, L> secondKeyTable;
    private MultiDictionary<string, L> bothKeysTable;

    public BiDictionary()
    {
        this.firstKeyTable = new MultiDictionary<T, L>(true);
        this.secondKeyTable = new MultiDictionary<K, L>(true);
        this.bothKeysTable = new MultiDictionary<string, L>(true);
    }

    public void Add(T firstKey, K secondKey, L value)
    {
        if (this.firstKeyTable.Contains(firstKey, value))
        {
            this.firstKeyTable[firstKey].Add(value);
        }
        else
        {
            this.firstKeyTable.Add(firstKey, value);
        }

        if (this.secondKeyTable.Contains(secondKey, value))
        {
            this.secondKeyTable[secondKey].Add(value);
        }
        else
        {
            this.secondKeyTable.Add(secondKey, value);
        }

        if (this.bothKeysTable.Contains(firstKey.ToString() + secondKey.ToString(), value))
        {
            this.bothKeysTable[firstKey.ToString() + secondKey.ToString()].Add(value);
        }
        else
        {
            this.bothKeysTable.Add(firstKey.ToString() + secondKey.ToString(), value);
        }
    }

    public IEnumerable FindByFistKey(T key)
    {
        return this.firstKeyTable[key];
    }

    public IEnumerable FindBySecondKey(K key)
    {
        return this.secondKeyTable[key];
    }

    public IEnumerable FindByBothKeys(T firstKey, K secondKey)
    {
        return this.bothKeysTable[firstKey.ToString() + secondKey.ToString()];
    }
}