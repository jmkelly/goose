namespace GooseHtml;

public record Lang(): Attribute("lang", "en-US")
	{
		public override string ToString()
		{
			return base.ToString();
		}
	}
