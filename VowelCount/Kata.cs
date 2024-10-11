using System.Linq;
namespace VowelCount;

public static class Kata
{
	public static int GetVowelCount(string str)
	{
		char[] vowels = {'a', 'e', 'i', 'o', 'u'};
		return str.Count(c => vowels.Contains(c));
	}
}