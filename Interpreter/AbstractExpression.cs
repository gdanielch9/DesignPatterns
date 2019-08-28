using System;
using System.Collections.Generic;

namespace Interpreter
{
	/// <summary>
	/// The abstract expresson class.
	/// </summary>
	public abstract class AbstractExpression
	{
		/// <summary>
		/// Interpret the expression.
		/// </summary>
		/// <param name="context">The expression context to use.</param>
		/// <returns>The expression result (an integer in this example).</returns>
		public abstract int Interpret(Context context);
	}
}
