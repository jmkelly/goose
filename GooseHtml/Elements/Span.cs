namespace GooseHtml;

public class Span : Element
{
	public Span(Class @class): base(@class)
	{

	}

	public Span(): base()
	{

	}

	public Span(Text value): base()
	{
		Add(value);
	}
}

