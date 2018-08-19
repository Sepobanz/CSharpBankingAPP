//========================================================================
// This conversion was produced by the Free Edition of
// Java to C# Converter courtesy of Tangible Software Solutions.
// Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
//========================================================================

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
namespace bankingapp
{
	/// 
	/// <summary>
	/// @author Patsf
	/// </summary>
	public class Validation
	{

		private string lineEnd;

		public Validation()
		{
			this.lineEnd = "\n";
		}
		public Validation(string lineEnd)
		{
			this.lineEnd = lineEnd;
		}

		public virtual string isPresent(string value, string name)
		{
			string msg = "";
			if (value.Length == 0)
			{
				msg = name + " is required." + lineEnd;
			}
			return msg;
		}

		public virtual string isDouble(string value, string name)
		{
			string msg = "";
			try
			{
				double.Parse(value);
			}
			catch (System.FormatException)
			{
				msg = name + " must be a valid number." + lineEnd;
			}
			return msg;
		}

		public virtual string isInteger(string value, string name)
		{
			string msg = "";
			try
			{
				int.Parse(value);
			}
			catch (System.FormatException)
			{
				msg = name + " must be an integer." + lineEnd;
			}
			return msg;
		}

		public virtual string isLong(string value, string name)
		{
			string msg = "";
			try
			{
				long.Parse(value);
			}
			catch (System.FormatException)
			{
				msg = name + " must be an long number." + lineEnd;
			}
			return msg;
		}

	}

}