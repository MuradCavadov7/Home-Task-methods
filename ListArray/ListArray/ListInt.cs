namespace ListArray;
class ListInt
{
    private int[] _indexer;
    public ListInt()
    {
        _indexer = new int[0];
    }
    public int this[int i]
    {
        get
        {
            return _indexer[i];
        }
        set
        {
            if (i >= 0 && i < _indexer.Length)
                _indexer[i] = value;
        }
    }

    public void Add(int number)
    {
        Array.Resize(ref _indexer, _indexer.Length + 1);
        _indexer[^1] = number;
    }
    public void Add(params int[] numbers)
    {
        foreach (int number in numbers)
        {
            Add(number);
        }

    }

    public bool Contains(int number)
    {

        foreach (int i in _indexer)
        {
            if (i == number)
            {
                return true;
            }
        }
        return false;
    }

    public int Pop()
    {
        int lastElement = _indexer[^1];
        if (_indexer.Length != 0)
        {
            Array.Resize(ref _indexer, _indexer.Length - 1);
        }
        return lastElement;
    }

    public int Sum()
    {
        int sum = 0;
        for (int i = 0; i < _indexer.Length; i++)
        {
            sum += _indexer[i];
        }
        return sum;
    }


    public int IndexOf(int num)
    {
        for (int i = 0; i < _indexer.Length; i++)
        {
            if (_indexer[i] == num)
                return i;
        }
        return -1;
    }

    public int LastIndexOf(int num)
    {
        int lastIndexOf = 0;
        for (int i = 0; i < _indexer.Length; i++)
        {
            if (_indexer[i] == num)
            {
                lastIndexOf = i;

            }
        }
        return lastIndexOf;
    }
    public void Insert(int num, int index)
    {
        Array.Resize(ref _indexer, _indexer.Length + 1);

        for ( int i=_indexer.Length-1; i > index;  i-- )
        {
            //Onemli Duyuru:Insertin for hissesin komek alib yazmisam
            _indexer[i]= _indexer[i-1];
        }
        _indexer[index]= num;
    }
    public float Average()
    {
        float average = 0;
        int count = 0;
        for (int i = 0; i < _indexer.Length; i++)
        {
            average += _indexer[i];
            count++;
        }
        return average / count;
    }

    public override string ToString()
    {
        string result = "";
        foreach (int num in _indexer)
        {
            if (result != String.Empty)
            {
                result += ", ";
            }
            result += num;
        }
        return result;
    }
}

