using BenchmarkDotNet.Attributes;
using System.Text;

public class StringTest
{
	[Benchmark]
	public string concatStr1()
	{
		string result = string.Empty;
		int start = 65;
		while(start <= 90)
		{
			char ch = (char)(start++);
			result = result + ch.ToString();
		}
		return result;
	}
	
	[Benchmark]
	public string concatStrUsingStringBuilder()
	{
		var result = new StringBuilder(); 
		int start = 65;
		while(start <= 90)
		{
			char ch = (char)(start++);
			result.Append(ch.ToString());
		}
		return result.ToString();
	}
}