string[] lines = System.IO.File.ReadAllLines(@"C:\Users\chris\source\repos\advent1\advent1\TextFile1.txt");
var totalsArray = new List<int>();
var str = "";
for (int i = 0; i < lines.Length; i++)
{
    if (lines[i] == "" || lines[i] == null)
    {
        str = str + lines[i] + ',';
    }
    else
    {
        str = str + lines[i] + '/';
    }
}
string[] seperate = str.Split(',');
for (int i = 0; i < seperate.Length; i++)
{
    var sepTotal = 0;
    var nums = seperate[i].Split('/');

    for (int j = 0; j < nums.Length; j++)
    {
        if (nums[j] == "")
        {
            continue;
        }
        else
        {
            sepTotal += Int32.Parse(nums[j]);
        }
    }
    totalsArray.Add(sepTotal);
}

var ordered = totalsArray.OrderByDescending(x => x);
var largest = ordered.ElementAt(0);
var largestIndex = totalsArray.IndexOf(largest);

var secondLargest = ordered.ElementAt(1);
var secondLargestIndex = totalsArray.IndexOf(secondLargest);

var thirdLargest = ordered.ElementAt(2);
var thirdLargestIndex = totalsArray.IndexOf(thirdLargest);
