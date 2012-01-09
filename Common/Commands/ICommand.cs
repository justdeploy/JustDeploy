namespace JustDeploy.Commands
{
	public interface ICommand<out T>
	{
		string Name { get; }
		string Type { get; }
		T GetExtraData();
	}
}