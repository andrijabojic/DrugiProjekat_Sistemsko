using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

class CacheItem
{
    private string _JSON;
    private int _count;
    private DateTime _timestamp;
    public CacheItem(string json)
    {
        _JSON = json;
        _count = 1;
        _timestamp = DateTime.Now;
    }
    public void IncCount() { _count++; }
    public string JSON {
        get { return _JSON; }
        set { _JSON = value; }
    }
    public int Count
    {
        get { return _count; }
    }
    public DateTime Timestamp
    {
        get { return _timestamp; }
    }
}
