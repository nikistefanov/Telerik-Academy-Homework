//Problem 15. Replace tags

//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
//Example:

//input	output
//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>	<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

using System;

class TagsToBeReplaced
{
    static void Main()
    {
        string beforeChanges = @"<p>Please visit <a href=""http://academy.telerik .com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        Console.WriteLine("Before:  {0}", beforeChanges);
        Console.WriteLine(new string('*', 60));
        string afterChanges = beforeChanges.Replace("<a href=\"", "[URL=")
                                           .Replace("\">", "]")
                                           .Replace("</a>", "[/URL]");
        Console.WriteLine("After:   {0}", afterChanges);
    }
}
