int firstDuplicate(int[] a) {
    Dictionary<int, int> x = new Dictionary<int,int>();
    foreach(int i in a) {
        if(x.ContainsKey(i))
            return i;
        else
            x.Add(i,1);
    }
    return -1;
}