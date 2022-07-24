using System;

namespace Nml.Refactor.Me.Dependencies
{
	public interface ILogger
	{
		void LogError(Exception exception, string message);
		void LogTrace(string message);
	}
	
	public interface ILogger<T> : ILogger{}
}
