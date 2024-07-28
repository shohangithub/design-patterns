
using Proxy_Problem;

Library library = new();

string[] fileNames = { "a", "b", "c" };
foreach (var fileName in fileNames)
    library.Add(new Ebook(fileName));

library.Open("a");
library.Open("b");