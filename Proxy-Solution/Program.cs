using Proxy_Solution;

Library library = new();

string[] fileNames = { "a", "b", "c" };
foreach (var fileName in fileNames)
    library.Add(new EbookProxy(fileName));

library.Open("a");